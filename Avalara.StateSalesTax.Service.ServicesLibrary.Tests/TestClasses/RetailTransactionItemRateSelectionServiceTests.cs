using System.Threading.Tasks;
using Avalara.StateSalesTax.Data.Dtos;
using Avalara.StateSalesTax.Data.EntityFramework.DbContexts;
using Avalara.StateSalesTax.Service.Contracts;
using Avalara.StateSalesTax.Service.ServicesLibrary.TestHelpers.BaseClasses;
using Xunit;

namespace Avalara.StateSalesTax.Service.ServicesLibrary.Tests.TestClasses
{
    public class RetailTransactionItemRateSelectionServiceTests : DbContextDependentBase
    {
        private readonly IRetailTransactionItemRateSelectionService _ItemRateSelectionService;

        public RetailTransactionItemRateSelectionServiceTests(StateSalesTaxDbContext dbContext, IRetailTransactionItemRateSelectionService itemRateSelectionService) : base(dbContext)
        {
            _ItemRateSelectionService = itemRateSelectionService;
        }

        [Fact]
        public async Task GetTaxRateAsync_IsInterstate_IsFoodDrugRetailItem_SelectsCorrectTaxRate()
        {
            var retailTransactionItemDto = new RetailTransactionItemDto()
            {
                ItemName = "Generic Food/Drug",
                PurchasePrice = 100.00,
                IsInterstatePurchase = true,
                IsFoodOrDrugItem = true
            };
            
            var taxRateDto = new TaxRateDto()
            {
                FoodDrugInterstateRate = 0.5,
                FoodDrugIntrastateRate = 0.25,
                GeneralInterstateRate = 0.1,
                GeneralIntrastateRate = 0.2
            };

            var result = await _ItemRateSelectionService.GetTaxRateAsync(retailTransactionItemDto, taxRateDto);

            Assert.True(result == 0.5);
        }

        [Fact]
        public async Task GetTaxRateAsync_IsIntrastate_IsFoodDrugRetailItem_SelectsCorrectTaxRate()
        {
            var retailTransactionItemDto = new RetailTransactionItemDto()
            {
                ItemName = "Generic Food/Drug",
                PurchasePrice = 100.00,
                IsInterstatePurchase = false,
                IsFoodOrDrugItem = true
            };

            var taxRateDto = new TaxRateDto()
            {
                FoodDrugInterstateRate = 0.5,
                FoodDrugIntrastateRate = 0.25,
                GeneralInterstateRate = 0.1,
                GeneralIntrastateRate = 0.2
            };

            var result = await _ItemRateSelectionService.GetTaxRateAsync(retailTransactionItemDto, taxRateDto);

            Assert.True(result == 0.25);
        }

        [Fact]
        public async Task GetTaxRateAsync_IsInterstate_IsGeneralRetailItem_SelectsCorrectTaxRate()
        {
            var retailTransactionItemDto = new RetailTransactionItemDto()
            {
                ItemName = "Generic General Item",
                PurchasePrice = 100.00,
                IsInterstatePurchase = true,
                IsFoodOrDrugItem = false
            };

            var taxRateDto = new TaxRateDto()
            {
                FoodDrugInterstateRate = 0.5,
                FoodDrugIntrastateRate = 0.25,
                GeneralInterstateRate = 0.1,
                GeneralIntrastateRate = 0.2
            };

            var result = await _ItemRateSelectionService.GetTaxRateAsync(retailTransactionItemDto, taxRateDto);

            Assert.True(result == 0.1);
        }

        [Fact]
        public async Task GetTaxRateAsync_IsIntrastate_IsGeneralRetailItem_SelectsCorrectTaxRate()
        {
            var retailTransactionItemDto = new RetailTransactionItemDto()
            {
                ItemName = "Generic Food/Drug",
                PurchasePrice = 100.00,
                IsInterstatePurchase = false,
                IsFoodOrDrugItem = false
            };

            var taxRateDto = new TaxRateDto()
            {
                FoodDrugInterstateRate = 0.5,
                FoodDrugIntrastateRate = 0.25,
                GeneralInterstateRate = 0.1,
                GeneralIntrastateRate = 0.2
            };

            var result = await _ItemRateSelectionService.GetTaxRateAsync(retailTransactionItemDto, taxRateDto);

            Assert.True(result == 0.2);
        }
    }
}
