using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Data.Dtos;
using Avalara.StateSalesTax.Data.EntityFramework.DbContexts;
using Avalara.StateSalesTax.Service.Contracts;
using Avalara.StateSalesTax.Service.ServicesLibrary.TestHelpers.BaseClasses;
using Xunit;

namespace Avalara.StateSalesTax.Service.ServicesLibrary.Tests.TestClasses
{
    public class RetailTransactionTaxCalculationServiceTests : DbContextDependentBase
    {
        private readonly IRetailTransactionTaxCalculationService _TaxCalculationService;

        public RetailTransactionTaxCalculationServiceTests(StateSalesTaxDbContext dbContext, IRetailTransactionTaxCalculationService taxCalculationService) : base(dbContext)
        {
            _TaxCalculationService = taxCalculationService;
        }

        [Fact]
        public async Task GetTaxRateAsync_IsInterstate_IsFoodDrugRetailItem_CalculatesCorrectTaxAmount()
        {
            var retailTransactionItemDtos = new List<RetailTransactionItemDto>()
            {
                new RetailTransactionItemDto()
                {
                    ItemName = "Generic Food/Drug",
                    PurchasePrice = 100.00,
                    IsInterstatePurchase = true,
                    IsFoodOrDrugItem = true
                }
            };

            var taxRateDtos = new List<TaxRateDto>()
            {
                new TaxRateDto()
                {
                    FoodDrugInterstateRate = 0.5,
                    FoodDrugIntrastateRate = 0.25,
                    GeneralInterstateRate = 0.1,
                    GeneralIntrastateRate = 0.2
                }
            };


            var result = await _TaxCalculationService.CalculateTaxesAsync(retailTransactionItemDtos, taxRateDtos);

            Assert.Equal(50, result.TotalTaxAmount);
        }

        [Fact]
        public async Task GetTaxRateAsync_IsIntrastate_IsFoodDrugRetailItem_CalculatesCorrectTaxAmount()
        {
            var retailTransactionItemDtos = new List<RetailTransactionItemDto>()
            {
                new RetailTransactionItemDto()
                {
                    ItemName = "Generic Food/Drug",
                    PurchasePrice = 100.00,
                    IsInterstatePurchase = false,
                    IsFoodOrDrugItem = true
                }
            };

            var taxRateDtos = new List<TaxRateDto>()
            {
                new TaxRateDto()
                {
                    FoodDrugInterstateRate = 0.5,
                    FoodDrugIntrastateRate = 0.25,
                    GeneralInterstateRate = 0.1,
                    GeneralIntrastateRate = 0.2
                }
            };


            var result = await _TaxCalculationService.CalculateTaxesAsync(retailTransactionItemDtos, taxRateDtos);

            Assert.Equal(25, result.TotalTaxAmount);
        }

        [Fact]
        public async Task GetTaxRateAsync_IsInterstate_IsGeneralRetailItem_CalculatesCorrectTaxAmount()
        {
            var retailTransactionItemDtos = new List<RetailTransactionItemDto>()
            {
                new RetailTransactionItemDto()
                {
                    ItemName = "Non-food/Non-drug Retail Item",
                    PurchasePrice = 100.00,
                    IsInterstatePurchase = true,
                    IsFoodOrDrugItem = false
                }
            };

            var taxRateDtos = new List<TaxRateDto>()
            {
                new TaxRateDto()
                {
                    FoodDrugInterstateRate = 0.5,
                    FoodDrugIntrastateRate = 0.25,
                    GeneralInterstateRate = 0.1,
                    GeneralIntrastateRate = 0.2
                }
            };


            var result = await _TaxCalculationService.CalculateTaxesAsync(retailTransactionItemDtos, taxRateDtos);

            Assert.Equal(10, result.TotalTaxAmount);
        }

        [Fact]
        public async Task GetTaxRateAsync_IsIntrastate_IsGeneralRetailItem_CalculatesCorrectTaxAmount()
        {
            var retailTransactionItemDtos = new List<RetailTransactionItemDto>()
            {
                new RetailTransactionItemDto()
                {
                    ItemName = "Non-food/Non-drug Retail Item",
                    PurchasePrice = 100.00,
                    IsInterstatePurchase = false,
                    IsFoodOrDrugItem = false
                }
            };

            var taxRateDtos = new List<TaxRateDto>()
            {
                new TaxRateDto()
                {
                    FoodDrugInterstateRate = 0.5,
                    FoodDrugIntrastateRate = 0.25,
                    GeneralInterstateRate = 0.1,
                    GeneralIntrastateRate = 0.2
                }
            };


            var result = await _TaxCalculationService.CalculateTaxesAsync(retailTransactionItemDtos, taxRateDtos);

            Assert.Equal(20, result.TotalTaxAmount);
        }

        [Fact]
        public async Task GetTaxRateAsync_HasMultipleDifferentIntrastateItems_CalculatesCorrectTaxAmount()
        {
            var retailTransactionItemDtos = new List<RetailTransactionItemDto>()
            {
                new RetailTransactionItemDto()
                {
                    ItemName = "Non-food/Non-drug Retail Item",
                    PurchasePrice = 100.00,
                    IsInterstatePurchase = false,
                    IsFoodOrDrugItem = false
                },
                new RetailTransactionItemDto()
                {
                    ItemName = "Generic Food/Drug",
                    PurchasePrice = 100.00,
                    IsInterstatePurchase = false,
                    IsFoodOrDrugItem = true
                }
            };

            var taxRateDtos = new List<TaxRateDto>()
            {
                new TaxRateDto()
                {
                    FoodDrugInterstateRate = 0.5,
                    FoodDrugIntrastateRate = 0.25,
                    GeneralInterstateRate = 0.1,
                    GeneralIntrastateRate = 0.2
                }
            };


            var result = await _TaxCalculationService.CalculateTaxesAsync(retailTransactionItemDtos, taxRateDtos);

            Assert.Equal(45, result.TotalTaxAmount);
        }
    }
}
