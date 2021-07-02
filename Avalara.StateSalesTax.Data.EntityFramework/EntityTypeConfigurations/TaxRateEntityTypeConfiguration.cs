using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Domain.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avalara.StateSalesTax.Data.EntityFramework.EntityTypeConfigurations
{
    public class TaxRateEntityTypeConfiguration : IEntityTypeConfiguration<TaxRate>
    {
        public void Configure(EntityTypeBuilder<TaxRate> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.FipsJurisdictionCodeId).IsRequired(false);

            builder.HasOne(o => o.FipsStateCode).WithMany(j => j.TaxRates)
                .HasForeignKey(o => o.FipsStateCodeId);

            builder.HasOne(o => o.FipsJurisdictionCode).WithMany(j => j.TaxRates)
                .HasForeignKey(o => o.FipsJurisdictionCodeId);

            builder.HasOne(o => o.FipsJurisdictionTypeCode).WithMany(j => j.TaxRates)
                .HasForeignKey(o=> o.FipsJurisdictionTypeCodeId);

            #region SEED DATA - RATES FOR COUNTIES (FIPS JURISDICTION TYPE = "00" / COUNTY)
            builder.HasData(new List<TaxRate>()
            {
                new TaxRate()
                {
                    Id = 1, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 2,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 2, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 2,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 3, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 2,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 4, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 3,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 5, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 3,
                    GeneralIntrastateRate = 0.0275, GeneralInterstateRate = 0.0275, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20080401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 6, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 3,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 7, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 3,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 8, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 4,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 9, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 4,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 10, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 4,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 11, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 5,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 12, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 5,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 13, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 5,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20150331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 14, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 5,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20150401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 15, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 6,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 16, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 6,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 17, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 6,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20150331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 18, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 6,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20150401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 19, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 7,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 20, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 7,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 21, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 7,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 22, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 8,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 23, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 8,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 24, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 8,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 25, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 9,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 26, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 9,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 27, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 9,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20200630", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 28, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 9,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20200701", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 29, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 10,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 30, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 10,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 31, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 10,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 32, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 11,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 33, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 11,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 34, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 11,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 35, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 12,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 36, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 12,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 37, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 12,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20120331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 38, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 12,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20120401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 39, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 13,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 40, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 13,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 41, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 13,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 42, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 14,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 43, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 14,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 44, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 14,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20120203", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 45, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 14,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20120204", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 46, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 15,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 47, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 15,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 48, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 15,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 49, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 16,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 50, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 16,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 51, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 16,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 52, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 17,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 53, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 17,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 54, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 17,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 55, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 18,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 56, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 18,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 57, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 18,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 58, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 19,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 59, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 19,
                    GeneralIntrastateRate = 0.0275, GeneralInterstateRate = 0.0275, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20080401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 60, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 19,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 61, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 19,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 62, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 20,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 63, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 20,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 64, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 20,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20200930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 65, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 20,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20201001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 66, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 21,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 67, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 21,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 68, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 21,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20160930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 69, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 21,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20161001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 70, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 22,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 71, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 22,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 72, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 22,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 73, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 23,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 74, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 23,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 75, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 23,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20180930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 76, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 23,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20181001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 77, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 24,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 78, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 24,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 79, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 24,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 80, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 25,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 81, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 25,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 82, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 25,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 83, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 26,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 84, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 26,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 85, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 26,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 86, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 27,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 87, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 27,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 88, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 28,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 89, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 28,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 90, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 28,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 91, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 29,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 92, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 29,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 93, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 29,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 94, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 30,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 95, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 30,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 96, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 30,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20140930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 97, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 30,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20141001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 98, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 31,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 99, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 31,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 100, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 31,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 101, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 32,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 102, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 32,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 103, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 32,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20101231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 104, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 32,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20110101", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 105, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 33,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 106, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 33,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 107, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 33,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20120331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 108, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 33,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20120401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 109, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 34,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 110, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 34,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 111, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 34,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20130331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 112, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 34,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20130401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 113, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 35,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 114, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 35,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 115, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 35,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20200630", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 116, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 35,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20200701", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 117, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 36,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 118, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 36,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 119, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 36,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 120, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 37,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 121, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 37,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 122, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 37,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20180930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 123, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 37,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20181001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 124, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 38,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 125, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 38,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 126, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 38,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 127, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 39,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 128, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 39,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 129, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 39,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20190331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 130, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 39,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20190401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 131, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 40,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 132, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 40,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 133, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 40,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 134, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 41,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 135, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 41,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 136, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 41,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20130331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 137, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 41,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20130401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 138, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 42,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 139, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 42,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 140, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 42,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 141, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 43,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 142, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 43,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 143, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 43,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20111231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 144, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 43,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20120101", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 145, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 44,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 146, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 44,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 147, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 44,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20140331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 148, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 44,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20140401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 149, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 45,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 150, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 45,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 151, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 46,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 152, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 46,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 153, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 46,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 154, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 47,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 155, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 47,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 156, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 47,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20100630", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 157, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 47,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20100701", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 158, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 48,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 159, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 48,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 160, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 48,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 161, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 49,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 162, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 49,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 163, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 49,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 164, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 50,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 165, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 50,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 166, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 50,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 167, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 51,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 168, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 51,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 169, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 51,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20100701", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 170, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 51,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20100702", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20160930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 171, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 51,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20161001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 172, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 52,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 173, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 52,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 174, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 52,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 175, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 53,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 176, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 53,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 177, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 53,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20180930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 178, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 53,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20181001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 179, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 54,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 180, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 54,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 181, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 54,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20100630", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 182, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 54,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20100701", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 183, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 55,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 184, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 55,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 185, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 55,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 186, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 56,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 187, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 56,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 188, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 56,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20180930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 189, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 56,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20181001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 190, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 57,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 191, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 57,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 192, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 57,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 193, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 58,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 194, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 58,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 195, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 58,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 196, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 59,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 197, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 59,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 198, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 59,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20200930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 199, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 59,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20201001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 200, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 60,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 201, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 60,
                    GeneralIntrastateRate = 0.0275, GeneralInterstateRate = 0.0275, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20080401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 202, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 60,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 203, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 60,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 204, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 61,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 205, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 61,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 206, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 61,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 207, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 62,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 208, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 62,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 209, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 62,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 210, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 63,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 211, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 63,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 212, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 63,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20120331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 213, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 63,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20120401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 214, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 64,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 215, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 64,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 216, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 64,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20190331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 217, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 64,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20190401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 218, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 65,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 219, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 65,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 220, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 65,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 221, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 66,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 222, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 66,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 223, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 66,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20100930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 224, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 66,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20101001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 225, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 67,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 226, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 67,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 227, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 67,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 228, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 68,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 229, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 68,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 230, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 68,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20100930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 231, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 68,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20101001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 232, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 69,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 233, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 69,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 234, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 69,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20120331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 235, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 69,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20120401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 236, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 70,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 237, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 70,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 238, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 70,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 239, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 71,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 240, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 71,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 241, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 71,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20180930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 242, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 71,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20181001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 243, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 72,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 244, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 72,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 245, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 72,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 246, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 73,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 247, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 73,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 248, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 73,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 249, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 74,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 250, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 74,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 251, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 74,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 252, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 75,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 253, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 75,
                    GeneralIntrastateRate = 0.0275, GeneralInterstateRate = 0.0275, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20080401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 254, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 75,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 255, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 75,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 256, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 76,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 257, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 76,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 258, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 76,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 259, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 77,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 260, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 77,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 261, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 77,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20100630", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 262, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 77,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20100701", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 263, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 78,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 264, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 78,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 265, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 78,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 266, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 79,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 267, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 79,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 268, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 79,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20101231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 269, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 79,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20110101", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 270, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 80,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 271, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 80,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 272, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 80,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20180930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 273, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 80,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20181001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 274, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 81,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 275, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 81,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 276, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 81,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20100630", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 277, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 81,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20100701", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 278, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 82,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 279, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 82,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 280, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 82,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20180930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 281, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 82,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20181001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 282, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 83,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 283, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 83,
                    GeneralIntrastateRate = 0.0275, GeneralInterstateRate = 0.0275, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20080401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 284, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 83,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 285, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 83,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 286, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 84,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 287, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 84,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 288, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 84,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 289, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 85,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 290, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 85,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 291, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 85,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20190331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 292, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 85,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20190401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 293, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 86,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 294, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 86,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 295, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 86,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 296, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 87,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 297, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 87,
                    GeneralIntrastateRate = 0.0275, GeneralInterstateRate = 0.0275, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20080401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 298, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 87,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 299, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 87,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 300, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 88,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 301, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 88,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 302, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 88,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20190331", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 303, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 88,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20190401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 304, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 89,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 305, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 89,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 306, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 89,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 307, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 90,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 308, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 90,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 309, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 90,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 310, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 91,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 311, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 91,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 312, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 91,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 313, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 92,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 314, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 92,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 315, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 92,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 316, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 93,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 317, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 93,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 318, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 93,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 319, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 94,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 320, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 94,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 321, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 94,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 322, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 95,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 323, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 95,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 324, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 95,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 325, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 96,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 326, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 96,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 327, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 96,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 328, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 97,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 329, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 97,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 330, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 97,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 331, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 98,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 332, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 98,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 333, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 98,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20100930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 334, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 98,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20101001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 335, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 99,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 336, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 99,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 337, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 99,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 338, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 100,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 339, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 100,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 340, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 100,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 341, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 101,
                    GeneralIntrastateRate = 0.025, GeneralInterstateRate = 0.025, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 342, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 101,
                    GeneralIntrastateRate = 0.0225, GeneralInterstateRate = 0.0225, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 343, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 1, FipsJurisdictionCodeId = 101,
                    GeneralIntrastateRate = 0.02, GeneralInterstateRate = 0.02, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
            });

            #endregion

            #region SEED DATA - RATES FOR STATE-LEVEL TAX (FIPS JURISDICTION TYPE = "45" / STATE TAXING AUTHORITY

            builder.HasData(new List<TaxRate>()
            {
                new TaxRate()
                {
                    Id = 344, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 25, FipsJurisdictionCodeId = null,
                    GeneralIntrastateRate = 0.045, GeneralInterstateRate = 0.045, FoodDrugIntrastateRate = 0.02,
                    FoodDrugInterstateRate = 0.02,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20061130", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 345, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 25, FipsJurisdictionCodeId = null,
                    GeneralIntrastateRate = 0.0425, GeneralInterstateRate = 0.0425, FoodDrugIntrastateRate = 0.02,
                    FoodDrugInterstateRate = 0.02,
                    BeginDate = DateTime.ParseExact("20061201", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20080930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 346, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 25, FipsJurisdictionCodeId = null,
                    GeneralIntrastateRate = 0.045, GeneralInterstateRate = 0.045, FoodDrugIntrastateRate = 0.02,
                    FoodDrugInterstateRate = 0.02,
                    BeginDate = DateTime.ParseExact("20081001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090831", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 347, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 25, FipsJurisdictionCodeId = null,
                    GeneralIntrastateRate = 0.055, GeneralInterstateRate = 0.055, FoodDrugIntrastateRate = 0.02,
                    FoodDrugInterstateRate = 0.02,
                    BeginDate = DateTime.ParseExact("20090901", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20090930", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 348, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 25, FipsJurisdictionCodeId = null,
                    GeneralIntrastateRate = 0.0575, GeneralInterstateRate = 0.0575, FoodDrugIntrastateRate = 0.02,
                    FoodDrugInterstateRate = 0.02,
                    BeginDate = DateTime.ParseExact("20091001", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20110630", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 349, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 25, FipsJurisdictionCodeId = null,
                    GeneralIntrastateRate = 0.0475, GeneralInterstateRate = 0.0475, FoodDrugIntrastateRate = 0.02,
                    FoodDrugInterstateRate = 0.02,
                    BeginDate = DateTime.ParseExact("20110701", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
            });

            #endregion

            #region SEED DATA - OTHER TAXING AUTHORITY RATES (FIPS JURISDICTION TYPE = 79 / Other Taxing Authority

            builder.HasData(new List<TaxRate>()
            {
                new TaxRate()
                {
                    Id = 350, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 40, FipsJurisdictionCodeId = 102,
                    GeneralIntrastateRate = 0.01, GeneralInterstateRate = 0.01, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20060101", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("20060630", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 351, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 40, FipsJurisdictionCodeId = 103,
                    GeneralIntrastateRate = 0.005, GeneralInterstateRate = 0.005, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20130401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 352, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 40, FipsJurisdictionCodeId = 104,
                    GeneralIntrastateRate = 0.005, GeneralInterstateRate = 0.005, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20050801", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 353, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 40, FipsJurisdictionCodeId = 105,
                    GeneralIntrastateRate = 0.005, GeneralInterstateRate = 0.005, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20130401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
                new TaxRate()
                {
                    Id = 354, FipsStateCodeId = 1, FipsJurisdictionTypeCodeId = 40, FipsJurisdictionCodeId = 106,
                    GeneralIntrastateRate = 0.005, GeneralInterstateRate = 0.005, FoodDrugIntrastateRate = 0,
                    FoodDrugInterstateRate = 0,
                    BeginDate = DateTime.ParseExact("20170401", "yyyyMMdd", CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact("99991231", "yyyyMMdd", CultureInfo.InvariantCulture)
                },
            });

            #endregion
        }
    }
}
