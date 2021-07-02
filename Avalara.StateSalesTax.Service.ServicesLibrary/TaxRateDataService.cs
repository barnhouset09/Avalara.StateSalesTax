using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Avalara.StateSalesTax.Data.Dtos;
using Avalara.StateSalesTax.Data.EntityFramework.DbContexts;
using Avalara.StateSalesTax.Service.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Avalara.StateSalesTax.Service.ServicesLibrary
{
    public class TaxRateDataService : ITaxRateDataService
    {
        private readonly StateSalesTaxDbContext _DbContext;
        private readonly IConfigurationProvider _ConfigurationProvider;

        public TaxRateDataService(StateSalesTaxDbContext dbContext, IConfigurationProvider configurationProvider)
        {
            _DbContext = dbContext;
            _ConfigurationProvider = configurationProvider;
        }

        public async Task<TaxRateDto> GetTaxRateAsync(int id)
        {
            if (!await _DbContext.TaxRates.AnyAsync(t => t.Id == id))
                return null;
            
            var result = await _DbContext.TaxRates.Where(t => t.Id == id).ProjectTo<TaxRateDto>(_ConfigurationProvider)
                .FirstOrDefaultAsync();

            return result;
        }

        public async Task<List<TaxRateDto>> GetAllTaxRatesAsync()
        {
            if (!await _DbContext.TaxRates.AnyAsync())
                return null;

            var result = await _DbContext.TaxRates
                .ProjectTo<TaxRateDto>(_ConfigurationProvider)
                .ToListAsync();

            return result;
        }

        public async Task<List<TaxRateDto>> GetAllActiveTaxRatesAsync()
        {
            if (!await _DbContext.TaxRates.Where(t => t.EndDate > DateTime.UtcNow).AnyAsync())
                return null;

            var result = await _DbContext.TaxRates
                .Where(t => t.EndDate > DateTime.UtcNow)
                .ProjectTo<TaxRateDto>(_ConfigurationProvider)
                .ToListAsync();

            return result;
        }

        public async Task<List<TaxRateDto>> GetAllByZipCodeAsync(string zipCode)
        {
            if (!await _DbContext.ZipCodes.AnyAsync(t => t.Code == zipCode))
                return null;

            // There appears to be a set of tax rates in NC that have a "99" in front of the county FIPS code that are for additional taxes.
            // Find them, append the "99", then search to see if any of the other tax rates exist.
            var possibleOtherTaxesJurisdictionCodes =
                await _DbContext.TaxRates.Include(t => t.FipsJurisdictionCode.ZipCodes)
                    .Where(t => t.FipsJurisdictionCode.ZipCodes.Any(z => z.Code == zipCode) && t.FipsJurisdictionTypeCode.Code == "00")
                    .Select(t => "99" + t.FipsJurisdictionCode.Code)
                    .ToListAsync();

            var specialApplicationTaxRates =
                await _DbContext.TaxRates
                    .Where(t => possibleOtherTaxesJurisdictionCodes.Contains(t.FipsJurisdictionCode.Code))
                    .ProjectTo<TaxRateDto>(_ConfigurationProvider)
                    .ToListAsync();

            // To be used to find any state-level authority tax rates of the same state from the rates found by the zip code.
            var stateFipsCodeId = await _DbContext.TaxRates.Include(t => t.FipsJurisdictionCode.ZipCodes)
                .Where(t => t.FipsJurisdictionCode.ZipCodes.Any(z => z.Code == zipCode))
                .Select(t => t.FipsStateCodeId)
                .FirstOrDefaultAsync();

            var stateTaxRates = await _DbContext.TaxRates
                .Where(t => t.FipsStateCodeId == stateFipsCodeId && t.FipsJurisdictionCode == null && t.FipsJurisdictionTypeCode.Code == "45")
                .ProjectTo<TaxRateDto>(_ConfigurationProvider)
                .ToListAsync();

            var countyTaxRates = await _DbContext.TaxRates.Include(t => t.FipsJurisdictionCode.ZipCodes)
                .Where(t => t.FipsJurisdictionCode.ZipCodes.Any(z => z.Code == zipCode) && t.FipsJurisdictionTypeCode.Code == "00")
                .ProjectTo<TaxRateDto>(_ConfigurationProvider)
                .ToListAsync();

            var result = specialApplicationTaxRates.Union(stateTaxRates).Union(countyTaxRates).ToList();

            return result;
        }

        public async Task<List<TaxRateDto>> GetAllActiveByZipCodeAsync(string zipCode)
        {
            if (!await _DbContext.ZipCodes.AnyAsync(z => z.Code == zipCode && z.FipsJurisdictionCode.TaxRates.Any(t => t.EndDate > DateTime.UtcNow)))
                return null;

            // There appears to be a set of tax rates in NC that have a "99" in front of the county FIPS code that are for additional taxes.
            // Find them, append the "99", then search to see if any of the other tax rates exist.
            var possibleOtherTaxesJurisdictionCodes =
                await _DbContext.TaxRates.Include(t => t.FipsJurisdictionCode.ZipCodes)
                    .Where(t => t.FipsJurisdictionCode.ZipCodes.Any(z => z.Code == zipCode) && t.FipsJurisdictionTypeCode.Code == "00" && t.EndDate > DateTime.UtcNow)
                    .Select(t => "99" + t.FipsJurisdictionCode.Code)
                    .ToListAsync();

            var specialApplicationTaxRates =
                await _DbContext.TaxRates
                    .Where(t => possibleOtherTaxesJurisdictionCodes.Contains(t.FipsJurisdictionCode.Code) && t.EndDate > DateTime.UtcNow)
                    .ProjectTo<TaxRateDto>(_ConfigurationProvider)
                    .ToListAsync();

            // To be used to find any state-level authority tax rates of the same state from the rates found by the zip code.
            var stateFipsCodeId = await _DbContext.TaxRates.Include(t => t.FipsJurisdictionCode.ZipCodes)
                .Where(t => t.FipsJurisdictionCode.ZipCodes.Any(z => z.Code == zipCode) && t.EndDate > DateTime.UtcNow)
                .Select(t => t.FipsStateCodeId)
                .FirstOrDefaultAsync();

            var stateTaxRates = await _DbContext.TaxRates
                .Where(t => t.FipsStateCodeId == stateFipsCodeId && t.FipsJurisdictionCode == null && t.FipsJurisdictionTypeCode.Code == "45" && t.EndDate > DateTime.UtcNow)
                .ProjectTo<TaxRateDto>(_ConfigurationProvider)
                .ToListAsync();

            var countyTaxRates = await _DbContext.TaxRates.Include(t => t.FipsJurisdictionCode.ZipCodes)
                .Where(t => t.FipsJurisdictionCode.ZipCodes.Any(z => z.Code == zipCode) && t.FipsJurisdictionTypeCode.Code == "00" && t.EndDate > DateTime.UtcNow)
                .ProjectTo<TaxRateDto>(_ConfigurationProvider)
                .ToListAsync();

            var result = specialApplicationTaxRates.Union(stateTaxRates).Union(countyTaxRates).ToList();

            return result;
        }

        public async Task<List<TaxRateDto>> GetStateTaxRateByNameAsync(string stateName)
        {
            // TODO: Add a lookup table for state names and abbreviations, tie them to the TaxRates.
            // We're only concerned with NC for this project so this should be alright for now.
            if (!await _DbContext.TaxRates.AnyAsync(t => t.FipsStateCode.Description.ToLower() == stateName.ToLower() && t.FipsJurisdictionTypeCode.Code == "45"))
                return null;

            var result = await _DbContext.TaxRates.Where(t =>
                    // FipsJurisdictionCode of 45 = "State Taxing Authority", so this will return only state-level tax rates.
                    t.FipsStateCode.Description.ToLower() == stateName.ToLower() && t.FipsJurisdictionTypeCode.Code == "45")
                .ProjectTo<TaxRateDto>(_ConfigurationProvider)
                .ToListAsync();

            return result;
        }

        public async Task<TaxRateDto> GetActiveStateTaxRateByNameAsync(string stateName)
        {
            // TODO: Add a lookup table for state names and abbreviations, tie them to the TaxRates.
            // We're only concerned with NC for this project so this should be alright for now.
            if (!await _DbContext.TaxRates.AnyAsync(t => t.FipsStateCode.Description.ToLower() == stateName.ToLower() && t.FipsJurisdictionTypeCode.Code == "45" && t.EndDate > DateTime.UtcNow))
                return null;

            var result = await _DbContext.TaxRates.Where(t =>
                    // FipsJurisdictionCode of 45 = "State Taxing Authority", so this will return only state-level tax rates.
                    t.FipsStateCode.Description.ToLower() == stateName.ToLower() && t.FipsJurisdictionTypeCode.Code == "45" && t.EndDate > DateTime.UtcNow)
                .ProjectTo<TaxRateDto>(_ConfigurationProvider)
                .FirstOrDefaultAsync();

            return result;
        }
    }
}
