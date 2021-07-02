using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Data.Dtos;
using Avalara.StateSalesTax.Service.Contracts;

namespace Avalara.StateSalesTax.Service.ServicesLibrary
{
    public class TaxCalculationService : ITaxCalculationService
    {
        private readonly ITaxRateDataService _TaxRateDataService;
        private readonly IRetailTransactionTaxCalculationService _RetailTransactionTaxCalculationService;

        public TaxCalculationService(ITaxRateDataService taxRateDataService, IRetailTransactionTaxCalculationService retailTransactionTaxCalculationService)
        {
            _TaxRateDataService = taxRateDataService;
            _RetailTransactionTaxCalculationService = retailTransactionTaxCalculationService;
        }

        public async Task<CalculatedTaxResponseDto> CalculateTaxesAsync(RetailTransactionDto request)
        {
            var taxRateDtos = await _TaxRateDataService.GetAllActiveByZipCodeAsync(request.ZipCode);

            if (taxRateDtos == null)
                return null;

            CalculatedTaxResponseDto response =
                await _RetailTransactionTaxCalculationService.CalculateTaxesAsync(request.TransactionItems,
                    taxRateDtos);

            return response;
        }
    }
}
