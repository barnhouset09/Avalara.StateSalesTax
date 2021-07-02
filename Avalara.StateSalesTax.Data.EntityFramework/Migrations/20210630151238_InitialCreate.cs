using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Avalara.StateSalesTax.Data.EntityFramework.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FipsJurisdictionCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FipsJurisdictionCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FipsJurisdictionTypeCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FipsJurisdictionTypeCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FipsStateCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FipsStateCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FipsStateCodeId = table.Column<int>(type: "INTEGER", nullable: false),
                    FipsJurisdictionTypeCodeId = table.Column<int>(type: "INTEGER", nullable: false),
                    FipsJurisdictionCodeId = table.Column<int>(type: "INTEGER", nullable: false),
                    GeneralIntrastateRate = table.Column<double>(type: "REAL", nullable: false),
                    GeneralInterstateRate = table.Column<double>(type: "REAL", nullable: false),
                    FoodDrugIntrastateRate = table.Column<double>(type: "REAL", nullable: false),
                    FoodDrugInterstateRate = table.Column<double>(type: "REAL", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxRates_FipsJurisdictionCodes_FipsJurisdictionCodeId",
                        column: x => x.FipsJurisdictionCodeId,
                        principalTable: "FipsJurisdictionCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaxRates_FipsJurisdictionTypeCodes_FipsJurisdictionTypeCodeId",
                        column: x => x.FipsJurisdictionTypeCodeId,
                        principalTable: "FipsJurisdictionTypeCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaxRates_FipsStateCodes_FipsStateCodeId",
                        column: x => x.FipsStateCodeId,
                        principalTable: "FipsStateCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 1, "000", "North Carolina" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 75, "147", "Pitt County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 74, "145", "Person County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 73, "143", "Perquimans County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 72, "141", "Pender County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 70, "137", "Pamlico County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 69, "135", "Orange County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 68, "133", "Onslow County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 67, "131", "Northampton County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 66, "129", "New Hanover County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 65, "127", "Nash County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 64, "125", "Moore County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 63, "123", "Montgomery County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 62, "121", "Mitchell County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 61, "119", "Mecklenburg County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 60, "117", "Martin County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 59, "115", "Madison County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 58, "113", "Macon County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 57, "111", "McDowell County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 56, "109", "Lincoln County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 55, "107", "Lenoir County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 54, "105", "Lee County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 76, "149", "Polk County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 77, "151", "Randolph County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 78, "153", "Richmond County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 79, "155", "Robeson County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 101, "199", "Yancey County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 100, "197", "Yadkin County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 99, "195", "Wilson County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 98, "193", "Wilkes County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 97, "191", "Wayne County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 96, "189", "Watauga County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 95, "187", "Washington County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 94, "185", "Warren County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 93, "183", "Wake County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 92, "181", "Vance County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 53, "103", "Jones County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 91, "179", "Union County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 89, "175", "Transylvania County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 88, "173", "Swain County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 87, "171", "Surry County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 86, "169", "Stokes County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 85, "167", "Stanly County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 84, "165", "Scotland County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 83, "163", "Sampson County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 82, "161", "Rutherford County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 81, "159", "Rowan County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 80, "157", "Rockingham County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 90, "177", "Tyrrell County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 52, "101", "Johnston County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 71, "139", "Pasquotank County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 50, "097", "Iredell County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 23, "043", "Clay County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 22, "041", "Chowan County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 21, "039", "Cherokee County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 20, "037", "Chatham County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 19, "035", "Catawba County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 18, "033", "Caswell County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 17, "031", "Carteret County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 16, "029", "Camden County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 15, "027", "Caldwell County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 14, "025", "Cabarrus County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 24, "045", "Cleveland County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 13, "023", "Burke County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 11, "019", "Brunswick County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 10, "017", "Bladen County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 9, "015", "Bertie County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 8, "013", "Beaufort County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 7, "011", "Avery County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 51, "099", "Jackson County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 5, "007", "Anson County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 4, "005", "Alleghany County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 3, "003", "Alexander County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 2, "001", "Alamance County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 12, "021", "Buncombe County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 25, "047", "Columbus County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 6, "009", "Ashe County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 27, "051", "Cumberland County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 26, "049", "Craven County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 49, "095", "Hyde County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 48, "093", "Hoke County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 46, "089", "Henderson County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 45, "087", "Haywood County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 44, "085", "Harnett County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 43, "083", "Halifax County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 42, "081", "Guilford County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 41, "079", "Greene County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 40, "077", "Granville County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 39, "075", "Graham County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 47, "091", "Hertford County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 37, "071", "Gaston County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 38, "073", "Gates County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 29, "055", "Dare County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 31, "059", "Davie County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 32, "061", "Duplin County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 30, "057", "Davidson County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 34, "065", "Edgecombe County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 35, "067", "Forsyth County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 36, "069", "Franklin County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 33, "063", "Durham County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 28, "053", "Currituck County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 23, "43", "State and County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 24, "44", "Central Collection Taxing Authority" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 30, "53", "Annual City Bond Authority" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 25, "45", "State Taxing Authority" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 26, "49", "Other Combination Collection" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 27, "50", "Bond Authority" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 28, "51", "Annual County Bond Authority" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 29, "52", "Semi-annual County Bond Authority" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 35, "63", "Special District" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 32, "59", "Other Bond Authority" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 33, "61", "Assessment District" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 34, "62", "Homeowner's Association" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 36, "69", "Other Special Districts" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 37, "70", "Central Appraisal Taxing Authority" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 38, "71", "Unsecured County Taxes" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 22, "42", "County collected by Other Taxing" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 39, "72", "Mobile Home Authority" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 31, "54", "Semi-annual City Bond Authority" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 21, "41", "City and School" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 9, "11", "Junior Colleges" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 19, "29", "Other Municipal Services" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 40, "79", "Other Special Applications" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 1, "00", "County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 2, "01", "City" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 3, "02", "Town" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 4, "03", "Village" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 5, "04", "Borough" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 6, "05", "Township" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 7, "09", "Other Municipality" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 20, "40", "Township and County" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 8, "10", "School District" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 11, "20", "Water Control" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 12, "21", "Utility District" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 13, "22", "Sanitation" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 14, "23", "Water or Sewer District" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 15, "24", "Reclaimation District" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 16, "25", "Fire or Police" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 17, "26", "Roads or Bridges" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 18, "27", "Hospitals" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionTypeCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 10, "19", "Other Schools" });

            migrationBuilder.InsertData(
                table: "FipsStateCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 1, "37", "North Carolina" });

            migrationBuilder.CreateIndex(
                name: "IX_TaxRates_FipsJurisdictionCodeId",
                table: "TaxRates",
                column: "FipsJurisdictionCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRates_FipsJurisdictionTypeCodeId",
                table: "TaxRates",
                column: "FipsJurisdictionTypeCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRates_FipsStateCodeId",
                table: "TaxRates",
                column: "FipsStateCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaxRates");

            migrationBuilder.DropTable(
                name: "FipsJurisdictionCodes");

            migrationBuilder.DropTable(
                name: "FipsJurisdictionTypeCodes");

            migrationBuilder.DropTable(
                name: "FipsStateCodes");
        }
    }
}
