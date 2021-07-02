using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Data.Dtos;
using Avalara.StateSalesTax.Service.Contracts;
using Avalara.StateSalesTax.Service.Contracts.Factories;

namespace Avalara.StateSalesTax.Service.ServicesLibrary
{
    public class RetailTransactionTaxCalculationService : IRetailTransactionTaxCalculationService
    {
        private readonly ICalculatedTaxResponseDtoFactory _CalculatedTaxResponseDtoFactory;
        private readonly IRetailTransactionItemRateSelectionService _RateSelectionService;

        public RetailTransactionTaxCalculationService(ICalculatedTaxResponseDtoFactory calculatedTaxResponseDtoFactory, IRetailTransactionItemRateSelectionService rateSelectionService)
        {
            _CalculatedTaxResponseDtoFactory = calculatedTaxResponseDtoFactory;
            _RateSelectionService = rateSelectionService;
        }

        public async Task<CalculatedTaxResponseDto> CalculateTaxesAsync(List<RetailTransactionItemDto> requestTransactionItems, List<TaxRateDto> taxRateDtos)
        {
            var calculatedTaxResponseDto = await _CalculatedTaxResponseDtoFactory.GetCalculatedTaxResponseDtoAsync();

            foreach (var transactionItem in requestTransactionItems)
            {
                foreach (var taxRate in taxRateDtos)
                {
                    var breakdownItem =
                        await _CalculatedTaxResponseDtoFactory.GetCalculatedTaxResponseBreakdownItemDtoAsync();

                    var calculatedTaxRate = await _RateSelectionService.GetTaxRateAsync(transactionItem, taxRate);

                    // Only the amount rounded down to the dollar is taxed.
                    var taxableDollars = Math.Floor(transactionItem.PurchasePrice);

                    breakdownItem.TaxRate = calculatedTaxRate;

                    breakdownItem.TaxType = taxRate.TaxRateType;

                    breakdownItem.TransactionItemName = transactionItem.ItemName;

                    breakdownItem.TransactionItemPreTaxPrice = transactionItem.PurchasePrice;

                    breakdownItem.TaxAmount = taxableDollars * calculatedTaxRate;

                    calculatedTaxResponseDto.TaxBreakdown.Add(breakdownItem);
                }
            }

            calculatedTaxResponseDto.TotalTaxAmount = Math.Round(calculatedTaxResponseDto.TaxBreakdown.Sum(tb => tb.TaxAmount), 2);

            return calculatedTaxResponseDto;
        }
    }
}
