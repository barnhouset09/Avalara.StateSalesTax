using System;
using System.Linq;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Data.EntityFramework.DbContexts;
using Avalara.StateSalesTax.Service.Contracts;
using Avalara.StateSalesTax.Service.ServicesLibrary.TestHelpers.BaseClasses;
using Xunit;

namespace Avalara.StateSalesTax.Service.ServicesLibrary.Tests.TestClasses
{
    /// <summary>
    /// All of the non-zipcode related services I created were just me exploring how the tax rate data from the nc census .gov website and how it's structured.
    ///
    /// The purposes of this code project I will only test the classes utilized by the individual endpoint required by the assignment (to save for time).
    /// </summary>
    public class TaxRateDataServiceTests : DbContextDependentBase
    {
        private readonly ITaxRateDataService _TaxRateDataService;

        public TaxRateDataServiceTests(ITaxRateDataService taxRateDataService, StateSalesTaxDbContext dbContext) : base(dbContext)
        {
            _TaxRateDataService = taxRateDataService;
        }

        /// <summary>
        /// Checks to see if the service correctly returns the most recently active tax rates for wake forest as of Q42019.
        /// </summary>
        [Fact]
        public async Task GetAllActiveByZipCodeAsync_FromWakeForest_IncludesAll2019Q4ActiveRates_WithCorrectRatesAndDates()
        {
            var result = await _TaxRateDataService.GetAllActiveByZipCodeAsync("27587");

            var otherSpecialtyTaxRate = result.FirstOrDefault(r => r.TaxRateType == "Other Special Applications");
            var stateLevelTaxRate = result.FirstOrDefault(r => r.TaxRateType == "State Taxing Authority");
            var countyLevelTaxRate = result.FirstOrDefault(r => r.TaxRateType == "County");

            // Make sure we get back the County, State, and Other tax rates for Wake Forest.
            Assert.True(otherSpecialtyTaxRate != null);
            Assert.True(stateLevelTaxRate != null);
            Assert.True(countyLevelTaxRate != null);

            // Make sure they match the seeded data item Ids (probably isn't important but it tests if the migration scripts are working correctly).
            Assert.True(otherSpecialtyTaxRate.Id == 354);
            Assert.True(stateLevelTaxRate.Id == 349);
            Assert.True(countyLevelTaxRate.Id == 318);

            // Make sure they have the correct rate percentages. (recommended to test equality using a tolerance factor)
            Assert.True(Math.Abs(otherSpecialtyTaxRate.FoodDrugInterstateRate - 0) == 0);
            Assert.True(Math.Abs(otherSpecialtyTaxRate.FoodDrugIntrastateRate - 0) == 0);
            Assert.True(Math.Abs(otherSpecialtyTaxRate.GeneralInterstateRate - 0.005) == 0);
            Assert.True(Math.Abs(otherSpecialtyTaxRate.GeneralIntrastateRate - 0.005) == 0);

            Assert.True(Math.Abs(stateLevelTaxRate.FoodDrugInterstateRate - 0.02) == 0);
            Assert.True(Math.Abs(stateLevelTaxRate.FoodDrugIntrastateRate - 0.02) == 0);
            Assert.True(Math.Abs(stateLevelTaxRate.GeneralInterstateRate - 0.0475) == 0);
            Assert.True(Math.Abs(stateLevelTaxRate.GeneralIntrastateRate - 0.0475) == 0);

            Assert.True(Math.Abs(countyLevelTaxRate.FoodDrugInterstateRate - 0) == 0);
            Assert.True(Math.Abs(countyLevelTaxRate.FoodDrugIntrastateRate - 0) == 0);
            Assert.True(Math.Abs(countyLevelTaxRate.GeneralInterstateRate - 0.02) == 0);
            Assert.True(Math.Abs(countyLevelTaxRate.GeneralIntrastateRate - 0.02) == 0);

            // Make sure expiration and end dates are correct.
            Assert.True(otherSpecialtyTaxRate.BeginDate == new DateTime(2017, 4, 1));
            Assert.True(otherSpecialtyTaxRate.EndDate == new DateTime(9999, 12, 31));

            Assert.True(stateLevelTaxRate.BeginDate == new DateTime(2011, 7, 1));
            Assert.True(stateLevelTaxRate.EndDate == new DateTime(9999, 12, 31));

            Assert.True(countyLevelTaxRate.BeginDate == new DateTime(2009, 10, 1));
            Assert.True(countyLevelTaxRate.EndDate == new DateTime(9999, 12, 31));
        }

        [Fact]
        public async Task GetAllActiveByZipCodeAsync_FromInvalidZip_ReturnsNull()
        {
            var result = await _TaxRateDataService.GetAllActiveByZipCodeAsync("sad2758722!@#");

            // No tax rates should be found with this crazy zip code.
            Assert.True(result == null);
        }
    }
}
