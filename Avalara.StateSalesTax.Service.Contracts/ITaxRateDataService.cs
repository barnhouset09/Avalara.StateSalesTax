using System.Collections.Generic;
using Avalara.StateSalesTax.Data.Dtos;
using System.Threading.Tasks;

namespace Avalara.StateSalesTax.Service.Contracts
{
    /// <summary>
    /// Service responsible for retrieving non-domain-level TaxRate data from the database.
    /// </summary>
    public interface ITaxRateDataService
    {
        /// <summary>
        /// Gets a specific TaxRate by ID.
        /// </summary>
        /// <param name="id">The primary ID/key of the TaxRate being queried for.</param>
        /// <returns>A TaxRateDto if a TaxRate is found. Otherwise returns null.</returns>
        Task<TaxRateDto> GetTaxRateAsync(int id);

        /// <summary>
        /// Gets the list of all tax rates stored in the database.
        /// </summary>
        /// <returns>A list of TaxRateDtos. Otherwise returns null if none are found.</returns>
        Task<List<TaxRateDto>> GetAllTaxRatesAsync();

        /// <summary>
        /// Gets the list of all ACTIVE tax rates stored in the database.
        /// </summary>
        /// <returns>A list of TaxRateDtos with active EndDates. Otherwise returns null if none are found.</returns>
        Task<List<TaxRateDto>> GetAllActiveTaxRatesAsync();

        /// <summary>
        /// Gets the tax rates for a given zip code.
        /// </summary>
        /// <param name="zipCode">The zipcode of the tax rate being inquired about.</param>
        /// <returns>A list of TaxRateDtos.</returns>
        Task<List<TaxRateDto>> GetAllByZipCodeAsync(string zipCode);

        /// <summary>
        /// Gets the tax rates for a given zip code.
        /// </summary>
        /// <param name="zipCode">The zipcode of the tax rate being inquired about.</param>
        /// <returns>A list of TaxRateDtos.</returns>
        Task<List<TaxRateDto>> GetAllActiveByZipCodeAsync(string zipCode);

        /// <summary>
        /// Gets the state-level tax rates for a given state. These may be combined with county, city, and other tax rates as well.
        /// </summary>
        /// <param name="stateName">The provided state's name.</param>
        /// <returns>A list of TaxRateDto representing the historical state-level tax rates for the provided state. Returns null if no rates are found.</returns>
        Task<List<TaxRateDto>> GetStateTaxRateByNameAsync(string stateName);

        /// <summary>
        /// Gets the currently active state-level tax rate for a given state. These may be combined with county, city, and other tax rates as well.
        /// </summary>
        /// <param name="stateName">The provided state's name.</param>
        /// <returns>An individual TaxRateDto representing the currently active tax rates for the provided state. Returns null if no rates are found.</returns>
        Task<TaxRateDto> GetActiveStateTaxRateByNameAsync(string stateName);
    }
}
