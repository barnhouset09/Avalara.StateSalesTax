using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Domain.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avalara.StateSalesTax.Data.EntityFramework.EntityTypeConfigurations
{
    public class FipsJurisdictionTypeCodeEntityTypeConfiguration : IEntityTypeConfiguration<FipsJurisdictionTypeCode>
    {
        public void Configure(EntityTypeBuilder<FipsJurisdictionTypeCode> builder)
        {
            builder.HasKey(o => o.Id);

            builder.HasMany(o => o.TaxRates);

            #region SEED DATA
            /*
             * From page 24 of this PDF, Section F - Taxing Authority Type Code:
             *      https://www.streamlinedsalestax.org/docs/default-source/technology/technology-guide-january-2021.pdf?sfvrsn=bd7d8cfe_4
             *
             *  This is column 2 of the CSV from:
             *      https://www.ncdor.gov/documents/rate-database-2020q4
             */
            builder.HasData(new List<FipsJurisdictionTypeCode>()
            {
                new FipsJurisdictionTypeCode()
                {
                    Id = 1,
                    Code = "00",
                    Description = "County"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 2,
                    Code = "01",
                    Description = "City"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 3,
                    Code = "02",
                    Description = "Town"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 4,
                    Code = "03",
                    Description = "Village"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 5,
                    Code = "04",
                    Description = "Borough"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 6,
                    Code = "05",
                    Description = "Township"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 7,
                    Code = "09",
                    Description = "Other Municipality"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 8,
                    Code = "10",
                    Description = "School District"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 9,
                    Code = "11",
                    Description = "Junior Colleges"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 10,
                    Code = "19",
                    Description = "Other Schools"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 11,
                    Code = "20",
                    Description = "Water Control"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 12,
                    Code = "21",
                    Description = "Utility District"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 13,
                    Code = "22",
                    Description = "Sanitation"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 14,
                    Code = "23",
                    Description = "Water or Sewer District"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 15,
                    Code = "24",
                    Description = "Reclaimation District"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 16,
                    Code = "25",
                    Description = "Fire or Police"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 17,
                    Code = "26",
                    Description = "Roads or Bridges"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 18,
                    Code = "27",
                    Description = "Hospitals"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 19,
                    Code = "29",
                    Description = "Other Municipal Services"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 20,
                    Code = "40",
                    Description = "Township and County"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 21,
                    Code = "41",
                    Description = "City and School"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 22,
                    Code = "42",
                    Description = "County collected by Other Taxing"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 23,
                    Code = "43",
                    Description = "State and County"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 24,
                    Code = "44",
                    Description = "Central Collection Taxing Authority"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 25,
                    Code = "45",
                    Description = "State Taxing Authority"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 26,
                    Code = "49",
                    Description = "Other Combination Collection"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 27,
                    Code = "50",
                    Description = "Bond Authority"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 28,
                    Code = "51",
                    Description = "Annual County Bond Authority"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 29,
                    Code = "52",
                    Description = "Semi-annual County Bond Authority"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 30,
                    Code = "53",
                    Description = "Annual City Bond Authority"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 31,
                    Code = "54",
                    Description = "Semi-annual City Bond Authority"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 32,
                    Code = "59",
                    Description = "Other Bond Authority"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 33,
                    Code = "61",
                    Description = "Assessment District"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 34,
                    Code = "62",
                    Description = "Homeowner's Association"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 35,
                    Code = "63",
                    Description = "Special District"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 36,
                    Code = "69",
                    Description = "Other Special Districts"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 37,
                    Code = "70",
                    Description = "Central Appraisal Taxing Authority"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 38,
                    Code = "71",
                    Description = "Unsecured County Taxes"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 39,
                    Code = "72",
                    Description = "Mobile Home Authority"
                },
                new FipsJurisdictionTypeCode()
                {
                    Id = 40,
                    Code = "79",
                    Description = "Other Special Applications"
                },
            });
            #endregion
        }
    }
}
