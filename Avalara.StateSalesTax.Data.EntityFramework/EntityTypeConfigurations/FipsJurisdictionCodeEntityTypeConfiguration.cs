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
    public class FipsJurisdictionCodeEntityTypeConfiguration : IEntityTypeConfiguration<FipsJurisdictionCode>
    {
        public void Configure(EntityTypeBuilder<FipsJurisdictionCode> builder)
        {
            builder.HasKey(o => o.Id);

            builder.HasMany(o => o.TaxRates);

            builder.HasMany(o => o.ZipCodes).WithOne(j => j.FipsJurisdictionCode);

            #region SEED DATA
            /*
             * Taken from the 2nd xlsx file listed here:
             *      https://www.census.gov/geographies/reference-files/2019/demo/popest/2019-fips.html
             *
             * These are the codes in the 3rd column of the csv file found from here:
             *      https://www.ncdor.gov/documents/rate-database-2020q4
             */
            builder.HasData(new List<FipsJurisdictionCode>()
            {
                new FipsJurisdictionCode()
                {
                    Id = 1,
                    Code = "000",
                    Description = "North Carolina"
                },
                new FipsJurisdictionCode()
                {
                    Id = 2,
                    Code = "001",
                    Description = "Alamance County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 3,
                    Code = "003",
                    Description = "Alexander County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 4,
                    Code = "005",
                    Description = "Alleghany County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 5,
                    Code = "007",
                    Description = "Anson County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 6,
                    Code = "009",
                    Description = "Ashe County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 7,
                    Code = "011",
                    Description = "Avery County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 8,
                    Code = "013",
                    Description = "Beaufort County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 9,
                    Code = "015",
                    Description = "Bertie County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 10,
                    Code = "017",
                    Description = "Bladen County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 11,
                    Code = "019",
                    Description = "Brunswick County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 12,
                    Code = "021",
                    Description = "Buncombe County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 13,
                    Code = "023",
                    Description = "Burke County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 14,
                    Code = "025",
                    Description = "Cabarrus County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 15,
                    Code = "027",
                    Description = "Caldwell County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 16,
                    Code = "029",
                    Description = "Camden County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 17,
                    Code = "031",
                    Description = "Carteret County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 18,
                    Code = "033",
                    Description = "Caswell County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 19,
                    Code = "035",
                    Description = "Catawba County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 20,
                    Code = "037",
                    Description = "Chatham County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 21,
                    Code = "039",
                    Description = "Cherokee County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 22,
                    Code = "041",
                    Description = "Chowan County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 23,
                    Code = "043",
                    Description = "Clay County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 24,
                    Code = "045",
                    Description = "Cleveland County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 25,
                    Code = "047",
                    Description = "Columbus County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 26,
                    Code = "049",
                    Description = "Craven County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 27,
                    Code = "051",
                    Description = "Cumberland County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 28,
                    Code = "053",
                    Description = "Currituck County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 29,
                    Code = "055",
                    Description = "Dare County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 30,
                    Code = "057",
                    Description = "Davidson County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 31,
                    Code = "059",
                    Description = "Davie County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 32,
                    Code = "061",
                    Description = "Duplin County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 33,
                    Code = "063",
                    Description = "Durham County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 34,
                    Code = "065",
                    Description = "Edgecombe County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 35,
                    Code = "067",
                    Description = "Forsyth County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 36,
                    Code = "069",
                    Description = "Franklin County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 37,
                    Code = "071",
                    Description = "Gaston County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 38,
                    Code = "073",
                    Description = "Gates County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 39,
                    Code = "075",
                    Description = "Graham County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 40,
                    Code = "077",
                    Description = "Granville County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 41,
                    Code = "079",
                    Description = "Greene County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 42,
                    Code = "081",
                    Description = "Guilford County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 43,
                    Code = "083",
                    Description = "Halifax County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 44,
                    Code = "085",
                    Description = "Harnett County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 45,
                    Code = "087",
                    Description = "Haywood County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 46,
                    Code = "089",
                    Description = "Henderson County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 47,
                    Code = "091",
                    Description = "Hertford County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 48,
                    Code = "093",
                    Description = "Hoke County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 49,
                    Code = "095",
                    Description = "Hyde County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 50,
                    Code = "097",
                    Description = "Iredell County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 51,
                    Code = "099",
                    Description = "Jackson County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 52,
                    Code = "101",
                    Description = "Johnston County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 53,
                    Code = "103",
                    Description = "Jones County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 54,
                    Code = "105",
                    Description = "Lee County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 55,
                    Code = "107",
                    Description = "Lenoir County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 56,
                    Code = "109",
                    Description = "Lincoln County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 57,
                    Code = "111",
                    Description = "McDowell County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 58,
                    Code = "113",
                    Description = "Macon County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 59,
                    Code = "115",
                    Description = "Madison County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 60,
                    Code = "117",
                    Description = "Martin County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 61,
                    Code = "119",
                    Description = "Mecklenburg County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 62,
                    Code = "121",
                    Description = "Mitchell County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 63,
                    Code = "123",
                    Description = "Montgomery County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 64,
                    Code = "125",
                    Description = "Moore County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 65,
                    Code = "127",
                    Description = "Nash County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 66,
                    Code = "129",
                    Description = "New Hanover County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 67,
                    Code = "131",
                    Description = "Northampton County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 68,
                    Code = "133",
                    Description = "Onslow County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 69,
                    Code = "135",
                    Description = "Orange County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 70,
                    Code = "137",
                    Description = "Pamlico County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 71,
                    Code = "139",
                    Description = "Pasquotank County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 72,
                    Code = "141",
                    Description = "Pender County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 73,
                    Code = "143",
                    Description = "Perquimans County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 74,
                    Code = "145",
                    Description = "Person County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 75,
                    Code = "147",
                    Description = "Pitt County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 76,
                    Code = "149",
                    Description = "Polk County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 77,
                    Code = "151",
                    Description = "Randolph County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 78,
                    Code = "153",
                    Description = "Richmond County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 79,
                    Code = "155",
                    Description = "Robeson County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 80,
                    Code = "157",
                    Description = "Rockingham County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 81,
                    Code = "159",
                    Description = "Rowan County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 82,
                    Code = "161",
                    Description = "Rutherford County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 83,
                    Code = "163",
                    Description = "Sampson County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 84,
                    Code = "165",
                    Description = "Scotland County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 85,
                    Code = "167",
                    Description = "Stanly County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 86,
                    Code = "169",
                    Description = "Stokes County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 87,
                    Code = "171",
                    Description = "Surry County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 88,
                    Code = "173",
                    Description = "Swain County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 89,
                    Code = "175",
                    Description = "Transylvania County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 90,
                    Code = "177",
                    Description = "Tyrrell County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 91,
                    Code = "179",
                    Description = "Union County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 92,
                    Code = "181",
                    Description = "Vance County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 93,
                    Code = "183",
                    Description = "Wake County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 94,
                    Code = "185",
                    Description = "Warren County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 95,
                    Code = "187",
                    Description = "Washington County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 96,
                    Code = "189",
                    Description = "Watauga County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 97,
                    Code = "191",
                    Description = "Wayne County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 98,
                    Code = "193",
                    Description = "Wilkes County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 99,
                    Code = "195",
                    Description = "Wilson County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 100,
                    Code = "197",
                    Description = "Yadkin County"
                },
                new FipsJurisdictionCode()
                {
                    Id = 101,
                    Code = "199",
                    Description = "Yancey County"
                },

            });
            #endregion

            #region SEED DATA - CITY LEVEL TAXING AUTHORITIES (FIPS CODE 79 / Other Taxing Authority)

            builder.HasData(new List<FipsJurisdictionCode>()
            {
                new FipsJurisdictionCode()
                {
                    Id = 102,
                    Code = "99055",
                    Description = "DARE"
                },
                new FipsJurisdictionCode()
                {
                    Id = 103,
                    Code = "99063",
                    Description = "DURHAM"
                },
                new FipsJurisdictionCode()
                {
                    Id = 104,
                    Code = "99119",
                    Description = "MECKLENBURG"
                },
                new FipsJurisdictionCode()
                {
                    Id = 105,
                    Code = "99135",
                    Description = "ORANGE COUNTY"
                },
                new FipsJurisdictionCode()
                {
                    Id = 106,
                    Code = "99183",
                    Description = "WAKE FOREST"
                },
            });

            #endregion
        }
    }
}
