using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avalara.StateSalesTax.API.WebApi.Controllers;
using Avalara.StateSalesTax.Data.Dtos;
using Avalara.StateSalesTax.Data.EntityFramework.DbContexts;
using Avalara.StateSalesTax.Service.Contracts;
using Avalara.StateSalesTax.Service.ServicesLibrary.TestHelpers.BaseClasses;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Avalara.StateSalesTax.API.WebApi.Tests.TestClasses
{
    public class TaxRateCalculationControllerTests : DbContextDependentBase
    {
        private readonly ITaxCalculationService _TaxCalculationService;
        public TaxRateCalculationControllerTests(StateSalesTaxDbContext dbContext, ITaxCalculationService taxCalculationService) : base(dbContext)
        {
            _TaxCalculationService = taxCalculationService;
        }

        [Fact]
        public async Task CalculateTaxes_ForItemsInWakeForest_CalculatesTaxAmountAndBreakdownCorrectly()
        {
            var controller = new TaxRateCalculationController(_TaxCalculationService);

            var retailTransactionDto = new RetailTransactionDto()
            {
                ZipCode = "27587",
                TransactionItems = new List<RetailTransactionItemDto>()
                {
                    new RetailTransactionItemDto()
                    {
                        ItemName = "Aspirin",
                        PurchasePrice = 5.99,
                        IsFoodOrDrugItem = true,
                        IsInterstatePurchase = false
                    },
                    new RetailTransactionItemDto()
                    {
                        ItemName = "EVGA nVidia GeForce RTX 3090 TI Graphics Card OC",
                        PurchasePrice = 2999.99,
                        IsFoodOrDrugItem = false,
                        IsInterstatePurchase = false
                    }
                }
            };

            var actionResult = await controller.CalculateTaxes(retailTransactionDto) as OkObjectResult;

            Assert.True(actionResult != null);

            var result = actionResult.Value as CalculatedTaxResponseDto;

            // Is it calculated correctly?
            Assert.True(Math.Floor(result.TotalTaxAmount - 217.53) == 0);

            // Is the breakdown tax data correct?
            // Aspirin breakdown:
            var aspirinBreakdownOtherSpecialTax =
                result.TaxBreakdown
                    .FirstOrDefault(tb =>
                        tb.TransactionItemName == "Aspirin" && tb.TaxType == "Other Special Applications");

            var aspirinBreakdownCountyTax =
                result.TaxBreakdown
                    .FirstOrDefault(tb =>
                        tb.TransactionItemName == "Aspirin" && tb.TaxType == "County");

            var aspirinBreakdownStateTax =
                result.TaxBreakdown
                    .FirstOrDefault(tb =>
                        tb.TransactionItemName == "Aspirin" && tb.TaxType == "State Taxing Authority");

            var hasAspirinOtherSpecialTaxBreakdown = aspirinBreakdownOtherSpecialTax != null;
            var hasAspirinCountyTaxBreakdown = aspirinBreakdownCountyTax != null;
            var hasAspirinStateTaxBreakdown = aspirinBreakdownStateTax != null;

            Assert.True(hasAspirinOtherSpecialTaxBreakdown);
            Assert.True(hasAspirinCountyTaxBreakdown);
            Assert.True(hasAspirinStateTaxBreakdown);

            // Are Aspirin tax rates selected correctly?
            var hasCorrectAspirinOtherSpecialTaxRate = Math.Abs(aspirinBreakdownOtherSpecialTax.TaxRate - 0) == 0;
            var hasCorrectAspirinCountyTaxRate = Math.Abs(aspirinBreakdownCountyTax.TaxRate - 0) == 0;
            var hasCorrectAspirinStateTaxRate = Math.Abs(aspirinBreakdownStateTax.TaxRate - 0.02) == 0;

            Assert.True(hasCorrectAspirinOtherSpecialTaxRate);
            Assert.True(hasCorrectAspirinCountyTaxRate);
            Assert.True(hasCorrectAspirinStateTaxRate);

            // Are Aspirin taxed amounts calculated correctly?
            var hasCorrectAspirinOtherSpecialTaxAmount = Math.Abs(aspirinBreakdownOtherSpecialTax.TaxAmount - 0) == 0;
            var hasCorrectAspirinCountyTaxAmount = Math.Abs(aspirinBreakdownCountyTax.TaxAmount - 0) == 0;
            var hasCorrectAspirinStateTaxAmount = Math.Abs(aspirinBreakdownStateTax.TaxAmount - 0.1) == 0;

            Assert.True(hasCorrectAspirinOtherSpecialTaxAmount);
            Assert.True(hasCorrectAspirinCountyTaxAmount);
            Assert.True(hasCorrectAspirinStateTaxAmount);


            // Video card breakdown:
            var gfxCardBreakdownOtherSpecialTax =
                result.TaxBreakdown
                    .FirstOrDefault(tb =>
                        tb.TransactionItemName == "EVGA nVidia GeForce RTX 3090 TI Graphics Card OC" && tb.TaxType == "Other Special Applications");

            var gfxCardBreakdownCountyTax =
                result.TaxBreakdown
                    .FirstOrDefault(tb =>
                        tb.TransactionItemName == "EVGA nVidia GeForce RTX 3090 TI Graphics Card OC" && tb.TaxType == "County");

            var gfxCardBreakdownStateTax =
                result.TaxBreakdown
                    .FirstOrDefault(tb =>
                        tb.TransactionItemName == "EVGA nVidia GeForce RTX 3090 TI Graphics Card OC" && tb.TaxType == "State Taxing Authority");

            var hasGfxCardOtherSpecialTaxBreakdown = gfxCardBreakdownOtherSpecialTax != null;
            var hasGfxCardCountyTaxBreakdown = gfxCardBreakdownCountyTax != null;
            var hasGfxCardStateTaxBreakdown = gfxCardBreakdownStateTax != null;

            Assert.True(hasGfxCardOtherSpecialTaxBreakdown);
            Assert.True(hasGfxCardCountyTaxBreakdown);
            Assert.True(hasGfxCardStateTaxBreakdown);

            // Are Aspirin tax rates selected correctly?
            var hasCorrectGfxCardOtherSpecialTaxRate = Math.Abs(gfxCardBreakdownOtherSpecialTax.TaxRate - 0.005) == 0;
            var hasCorrectGfxCardCountyTaxRate = Math.Abs(gfxCardBreakdownCountyTax.TaxRate - 0.02) == 0;
            var hasCorrectGfxCardStateTaxRate = Math.Abs(gfxCardBreakdownStateTax.TaxRate - 0.0475) == 0;

            Assert.True(hasCorrectGfxCardOtherSpecialTaxRate);
            Assert.True(hasCorrectGfxCardCountyTaxRate);
            Assert.True(hasCorrectGfxCardStateTaxRate);

            // Are Aspirin taxed amounts calculated correctly?
            var hasCorrectGfxCardOtherSpecialTaxAmount = Math.Abs(gfxCardBreakdownOtherSpecialTax.TaxAmount - 14.99) < 0.01;
            var hasCorrectGfxCardCountyTaxAmount = Math.Abs(gfxCardBreakdownCountyTax.TaxAmount - 59.98) < 0.01;
            var hasCorrectGfxCardStateTaxAmount = Math.Abs(gfxCardBreakdownStateTax.TaxAmount - 142.45) < 0.01;

            Assert.True(hasCorrectGfxCardOtherSpecialTaxAmount);
            Assert.True(hasCorrectGfxCardCountyTaxAmount);
            Assert.True(hasCorrectGfxCardStateTaxAmount);
        }
    }
}
