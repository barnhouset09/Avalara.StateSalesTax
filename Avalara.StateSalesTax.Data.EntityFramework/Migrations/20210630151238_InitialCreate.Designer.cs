// <auto-generated />
using System;
using Avalara.StateSalesTax.Data.EntityFramework.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Avalara.StateSalesTax.Data.EntityFramework.Migrations
{
    [DbContext(typeof(StateSalesTaxDbContext))]
    [Migration("20210630151238_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("Avalara.StateSalesTax.Domain.DomainEntities.FipsJurisdictionCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FipsJurisdictionCodes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "000",
                            Description = "North Carolina"
                        },
                        new
                        {
                            Id = 2,
                            Code = "001",
                            Description = "Alamance County"
                        },
                        new
                        {
                            Id = 3,
                            Code = "003",
                            Description = "Alexander County"
                        },
                        new
                        {
                            Id = 4,
                            Code = "005",
                            Description = "Alleghany County"
                        },
                        new
                        {
                            Id = 5,
                            Code = "007",
                            Description = "Anson County"
                        },
                        new
                        {
                            Id = 6,
                            Code = "009",
                            Description = "Ashe County"
                        },
                        new
                        {
                            Id = 7,
                            Code = "011",
                            Description = "Avery County"
                        },
                        new
                        {
                            Id = 8,
                            Code = "013",
                            Description = "Beaufort County"
                        },
                        new
                        {
                            Id = 9,
                            Code = "015",
                            Description = "Bertie County"
                        },
                        new
                        {
                            Id = 10,
                            Code = "017",
                            Description = "Bladen County"
                        },
                        new
                        {
                            Id = 11,
                            Code = "019",
                            Description = "Brunswick County"
                        },
                        new
                        {
                            Id = 12,
                            Code = "021",
                            Description = "Buncombe County"
                        },
                        new
                        {
                            Id = 13,
                            Code = "023",
                            Description = "Burke County"
                        },
                        new
                        {
                            Id = 14,
                            Code = "025",
                            Description = "Cabarrus County"
                        },
                        new
                        {
                            Id = 15,
                            Code = "027",
                            Description = "Caldwell County"
                        },
                        new
                        {
                            Id = 16,
                            Code = "029",
                            Description = "Camden County"
                        },
                        new
                        {
                            Id = 17,
                            Code = "031",
                            Description = "Carteret County"
                        },
                        new
                        {
                            Id = 18,
                            Code = "033",
                            Description = "Caswell County"
                        },
                        new
                        {
                            Id = 19,
                            Code = "035",
                            Description = "Catawba County"
                        },
                        new
                        {
                            Id = 20,
                            Code = "037",
                            Description = "Chatham County"
                        },
                        new
                        {
                            Id = 21,
                            Code = "039",
                            Description = "Cherokee County"
                        },
                        new
                        {
                            Id = 22,
                            Code = "041",
                            Description = "Chowan County"
                        },
                        new
                        {
                            Id = 23,
                            Code = "043",
                            Description = "Clay County"
                        },
                        new
                        {
                            Id = 24,
                            Code = "045",
                            Description = "Cleveland County"
                        },
                        new
                        {
                            Id = 25,
                            Code = "047",
                            Description = "Columbus County"
                        },
                        new
                        {
                            Id = 26,
                            Code = "049",
                            Description = "Craven County"
                        },
                        new
                        {
                            Id = 27,
                            Code = "051",
                            Description = "Cumberland County"
                        },
                        new
                        {
                            Id = 28,
                            Code = "053",
                            Description = "Currituck County"
                        },
                        new
                        {
                            Id = 29,
                            Code = "055",
                            Description = "Dare County"
                        },
                        new
                        {
                            Id = 30,
                            Code = "057",
                            Description = "Davidson County"
                        },
                        new
                        {
                            Id = 31,
                            Code = "059",
                            Description = "Davie County"
                        },
                        new
                        {
                            Id = 32,
                            Code = "061",
                            Description = "Duplin County"
                        },
                        new
                        {
                            Id = 33,
                            Code = "063",
                            Description = "Durham County"
                        },
                        new
                        {
                            Id = 34,
                            Code = "065",
                            Description = "Edgecombe County"
                        },
                        new
                        {
                            Id = 35,
                            Code = "067",
                            Description = "Forsyth County"
                        },
                        new
                        {
                            Id = 36,
                            Code = "069",
                            Description = "Franklin County"
                        },
                        new
                        {
                            Id = 37,
                            Code = "071",
                            Description = "Gaston County"
                        },
                        new
                        {
                            Id = 38,
                            Code = "073",
                            Description = "Gates County"
                        },
                        new
                        {
                            Id = 39,
                            Code = "075",
                            Description = "Graham County"
                        },
                        new
                        {
                            Id = 40,
                            Code = "077",
                            Description = "Granville County"
                        },
                        new
                        {
                            Id = 41,
                            Code = "079",
                            Description = "Greene County"
                        },
                        new
                        {
                            Id = 42,
                            Code = "081",
                            Description = "Guilford County"
                        },
                        new
                        {
                            Id = 43,
                            Code = "083",
                            Description = "Halifax County"
                        },
                        new
                        {
                            Id = 44,
                            Code = "085",
                            Description = "Harnett County"
                        },
                        new
                        {
                            Id = 45,
                            Code = "087",
                            Description = "Haywood County"
                        },
                        new
                        {
                            Id = 46,
                            Code = "089",
                            Description = "Henderson County"
                        },
                        new
                        {
                            Id = 47,
                            Code = "091",
                            Description = "Hertford County"
                        },
                        new
                        {
                            Id = 48,
                            Code = "093",
                            Description = "Hoke County"
                        },
                        new
                        {
                            Id = 49,
                            Code = "095",
                            Description = "Hyde County"
                        },
                        new
                        {
                            Id = 50,
                            Code = "097",
                            Description = "Iredell County"
                        },
                        new
                        {
                            Id = 51,
                            Code = "099",
                            Description = "Jackson County"
                        },
                        new
                        {
                            Id = 52,
                            Code = "101",
                            Description = "Johnston County"
                        },
                        new
                        {
                            Id = 53,
                            Code = "103",
                            Description = "Jones County"
                        },
                        new
                        {
                            Id = 54,
                            Code = "105",
                            Description = "Lee County"
                        },
                        new
                        {
                            Id = 55,
                            Code = "107",
                            Description = "Lenoir County"
                        },
                        new
                        {
                            Id = 56,
                            Code = "109",
                            Description = "Lincoln County"
                        },
                        new
                        {
                            Id = 57,
                            Code = "111",
                            Description = "McDowell County"
                        },
                        new
                        {
                            Id = 58,
                            Code = "113",
                            Description = "Macon County"
                        },
                        new
                        {
                            Id = 59,
                            Code = "115",
                            Description = "Madison County"
                        },
                        new
                        {
                            Id = 60,
                            Code = "117",
                            Description = "Martin County"
                        },
                        new
                        {
                            Id = 61,
                            Code = "119",
                            Description = "Mecklenburg County"
                        },
                        new
                        {
                            Id = 62,
                            Code = "121",
                            Description = "Mitchell County"
                        },
                        new
                        {
                            Id = 63,
                            Code = "123",
                            Description = "Montgomery County"
                        },
                        new
                        {
                            Id = 64,
                            Code = "125",
                            Description = "Moore County"
                        },
                        new
                        {
                            Id = 65,
                            Code = "127",
                            Description = "Nash County"
                        },
                        new
                        {
                            Id = 66,
                            Code = "129",
                            Description = "New Hanover County"
                        },
                        new
                        {
                            Id = 67,
                            Code = "131",
                            Description = "Northampton County"
                        },
                        new
                        {
                            Id = 68,
                            Code = "133",
                            Description = "Onslow County"
                        },
                        new
                        {
                            Id = 69,
                            Code = "135",
                            Description = "Orange County"
                        },
                        new
                        {
                            Id = 70,
                            Code = "137",
                            Description = "Pamlico County"
                        },
                        new
                        {
                            Id = 71,
                            Code = "139",
                            Description = "Pasquotank County"
                        },
                        new
                        {
                            Id = 72,
                            Code = "141",
                            Description = "Pender County"
                        },
                        new
                        {
                            Id = 73,
                            Code = "143",
                            Description = "Perquimans County"
                        },
                        new
                        {
                            Id = 74,
                            Code = "145",
                            Description = "Person County"
                        },
                        new
                        {
                            Id = 75,
                            Code = "147",
                            Description = "Pitt County"
                        },
                        new
                        {
                            Id = 76,
                            Code = "149",
                            Description = "Polk County"
                        },
                        new
                        {
                            Id = 77,
                            Code = "151",
                            Description = "Randolph County"
                        },
                        new
                        {
                            Id = 78,
                            Code = "153",
                            Description = "Richmond County"
                        },
                        new
                        {
                            Id = 79,
                            Code = "155",
                            Description = "Robeson County"
                        },
                        new
                        {
                            Id = 80,
                            Code = "157",
                            Description = "Rockingham County"
                        },
                        new
                        {
                            Id = 81,
                            Code = "159",
                            Description = "Rowan County"
                        },
                        new
                        {
                            Id = 82,
                            Code = "161",
                            Description = "Rutherford County"
                        },
                        new
                        {
                            Id = 83,
                            Code = "163",
                            Description = "Sampson County"
                        },
                        new
                        {
                            Id = 84,
                            Code = "165",
                            Description = "Scotland County"
                        },
                        new
                        {
                            Id = 85,
                            Code = "167",
                            Description = "Stanly County"
                        },
                        new
                        {
                            Id = 86,
                            Code = "169",
                            Description = "Stokes County"
                        },
                        new
                        {
                            Id = 87,
                            Code = "171",
                            Description = "Surry County"
                        },
                        new
                        {
                            Id = 88,
                            Code = "173",
                            Description = "Swain County"
                        },
                        new
                        {
                            Id = 89,
                            Code = "175",
                            Description = "Transylvania County"
                        },
                        new
                        {
                            Id = 90,
                            Code = "177",
                            Description = "Tyrrell County"
                        },
                        new
                        {
                            Id = 91,
                            Code = "179",
                            Description = "Union County"
                        },
                        new
                        {
                            Id = 92,
                            Code = "181",
                            Description = "Vance County"
                        },
                        new
                        {
                            Id = 93,
                            Code = "183",
                            Description = "Wake County"
                        },
                        new
                        {
                            Id = 94,
                            Code = "185",
                            Description = "Warren County"
                        },
                        new
                        {
                            Id = 95,
                            Code = "187",
                            Description = "Washington County"
                        },
                        new
                        {
                            Id = 96,
                            Code = "189",
                            Description = "Watauga County"
                        },
                        new
                        {
                            Id = 97,
                            Code = "191",
                            Description = "Wayne County"
                        },
                        new
                        {
                            Id = 98,
                            Code = "193",
                            Description = "Wilkes County"
                        },
                        new
                        {
                            Id = 99,
                            Code = "195",
                            Description = "Wilson County"
                        },
                        new
                        {
                            Id = 100,
                            Code = "197",
                            Description = "Yadkin County"
                        },
                        new
                        {
                            Id = 101,
                            Code = "199",
                            Description = "Yancey County"
                        });
                });

            modelBuilder.Entity("Avalara.StateSalesTax.Domain.DomainEntities.FipsJurisdictionTypeCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FipsJurisdictionTypeCodes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "00",
                            Description = "County"
                        },
                        new
                        {
                            Id = 2,
                            Code = "01",
                            Description = "City"
                        },
                        new
                        {
                            Id = 3,
                            Code = "02",
                            Description = "Town"
                        },
                        new
                        {
                            Id = 4,
                            Code = "03",
                            Description = "Village"
                        },
                        new
                        {
                            Id = 5,
                            Code = "04",
                            Description = "Borough"
                        },
                        new
                        {
                            Id = 6,
                            Code = "05",
                            Description = "Township"
                        },
                        new
                        {
                            Id = 7,
                            Code = "09",
                            Description = "Other Municipality"
                        },
                        new
                        {
                            Id = 8,
                            Code = "10",
                            Description = "School District"
                        },
                        new
                        {
                            Id = 9,
                            Code = "11",
                            Description = "Junior Colleges"
                        },
                        new
                        {
                            Id = 10,
                            Code = "19",
                            Description = "Other Schools"
                        },
                        new
                        {
                            Id = 11,
                            Code = "20",
                            Description = "Water Control"
                        },
                        new
                        {
                            Id = 12,
                            Code = "21",
                            Description = "Utility District"
                        },
                        new
                        {
                            Id = 13,
                            Code = "22",
                            Description = "Sanitation"
                        },
                        new
                        {
                            Id = 14,
                            Code = "23",
                            Description = "Water or Sewer District"
                        },
                        new
                        {
                            Id = 15,
                            Code = "24",
                            Description = "Reclaimation District"
                        },
                        new
                        {
                            Id = 16,
                            Code = "25",
                            Description = "Fire or Police"
                        },
                        new
                        {
                            Id = 17,
                            Code = "26",
                            Description = "Roads or Bridges"
                        },
                        new
                        {
                            Id = 18,
                            Code = "27",
                            Description = "Hospitals"
                        },
                        new
                        {
                            Id = 19,
                            Code = "29",
                            Description = "Other Municipal Services"
                        },
                        new
                        {
                            Id = 20,
                            Code = "40",
                            Description = "Township and County"
                        },
                        new
                        {
                            Id = 21,
                            Code = "41",
                            Description = "City and School"
                        },
                        new
                        {
                            Id = 22,
                            Code = "42",
                            Description = "County collected by Other Taxing"
                        },
                        new
                        {
                            Id = 23,
                            Code = "43",
                            Description = "State and County"
                        },
                        new
                        {
                            Id = 24,
                            Code = "44",
                            Description = "Central Collection Taxing Authority"
                        },
                        new
                        {
                            Id = 25,
                            Code = "45",
                            Description = "State Taxing Authority"
                        },
                        new
                        {
                            Id = 26,
                            Code = "49",
                            Description = "Other Combination Collection"
                        },
                        new
                        {
                            Id = 27,
                            Code = "50",
                            Description = "Bond Authority"
                        },
                        new
                        {
                            Id = 28,
                            Code = "51",
                            Description = "Annual County Bond Authority"
                        },
                        new
                        {
                            Id = 29,
                            Code = "52",
                            Description = "Semi-annual County Bond Authority"
                        },
                        new
                        {
                            Id = 30,
                            Code = "53",
                            Description = "Annual City Bond Authority"
                        },
                        new
                        {
                            Id = 31,
                            Code = "54",
                            Description = "Semi-annual City Bond Authority"
                        },
                        new
                        {
                            Id = 32,
                            Code = "59",
                            Description = "Other Bond Authority"
                        },
                        new
                        {
                            Id = 33,
                            Code = "61",
                            Description = "Assessment District"
                        },
                        new
                        {
                            Id = 34,
                            Code = "62",
                            Description = "Homeowner's Association"
                        },
                        new
                        {
                            Id = 35,
                            Code = "63",
                            Description = "Special District"
                        },
                        new
                        {
                            Id = 36,
                            Code = "69",
                            Description = "Other Special Districts"
                        },
                        new
                        {
                            Id = 37,
                            Code = "70",
                            Description = "Central Appraisal Taxing Authority"
                        },
                        new
                        {
                            Id = 38,
                            Code = "71",
                            Description = "Unsecured County Taxes"
                        },
                        new
                        {
                            Id = 39,
                            Code = "72",
                            Description = "Mobile Home Authority"
                        },
                        new
                        {
                            Id = 40,
                            Code = "79",
                            Description = "Other Special Applications"
                        });
                });

            modelBuilder.Entity("Avalara.StateSalesTax.Domain.DomainEntities.FipsStateCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FipsStateCodes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "37",
                            Description = "North Carolina"
                        });
                });

            modelBuilder.Entity("Avalara.StateSalesTax.Domain.DomainEntities.TaxRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("FipsJurisdictionCodeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FipsJurisdictionTypeCodeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FipsStateCodeId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("FoodDrugInterstateRate")
                        .HasColumnType("REAL");

                    b.Property<double>("FoodDrugIntrastateRate")
                        .HasColumnType("REAL");

                    b.Property<double>("GeneralInterstateRate")
                        .HasColumnType("REAL");

                    b.Property<double>("GeneralIntrastateRate")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("FipsJurisdictionCodeId");

                    b.HasIndex("FipsJurisdictionTypeCodeId");

                    b.HasIndex("FipsStateCodeId");

                    b.ToTable("TaxRates");
                });

            modelBuilder.Entity("Avalara.StateSalesTax.Domain.DomainEntities.TaxRate", b =>
                {
                    b.HasOne("Avalara.StateSalesTax.Domain.DomainEntities.FipsJurisdictionCode", "FipsJurisdictionCode")
                        .WithMany()
                        .HasForeignKey("FipsJurisdictionCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avalara.StateSalesTax.Domain.DomainEntities.FipsJurisdictionTypeCode", "FipsJurisdictionTypeCode")
                        .WithMany()
                        .HasForeignKey("FipsJurisdictionTypeCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avalara.StateSalesTax.Domain.DomainEntities.FipsStateCode", "FipsStateCode")
                        .WithMany()
                        .HasForeignKey("FipsStateCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FipsJurisdictionCode");

                    b.Navigation("FipsJurisdictionTypeCode");

                    b.Navigation("FipsStateCode");
                });
#pragma warning restore 612, 618
        }
    }
}
