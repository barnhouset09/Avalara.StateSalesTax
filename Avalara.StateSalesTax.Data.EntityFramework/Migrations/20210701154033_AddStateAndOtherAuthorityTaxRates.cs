using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Avalara.StateSalesTax.Data.EntityFramework.Migrations
{
    public partial class AddStateAndOtherAuthorityTaxRates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 344, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, 1, 0.02, 0.02, 0.044999999999999998, 0.044999999999999998 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 345, new DateTime(2006, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, 1, 0.02, 0.02, 0.042500000000000003, 0.042500000000000003 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 346, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, 1, 0.02, 0.02, 0.044999999999999998, 0.044999999999999998 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 347, new DateTime(2009, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, 1, 0.02, 0.02, 0.055, 0.055 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 348, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, 1, 0.02, 0.02, 0.057500000000000002, 0.057500000000000002 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 349, new DateTime(2011, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, 1, 0.02, 0.02, 0.047500000000000001, 0.047500000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 350, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 102, 40, 1, 0.0, 0.0, 0.01, 0.01 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 351, new DateTime(2013, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 103, 40, 1, 0.0, 0.0, 0.0050000000000000001, 0.0050000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 352, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, 40, 1, 0.0, 0.0, 0.0050000000000000001, 0.0050000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 353, new DateTime(2013, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 105, 40, 1, 0.0, 0.0, 0.0050000000000000001, 0.0050000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 354, new DateTime(2017, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 106, 40, 1, 0.0, 0.0, 0.0050000000000000001, 0.0050000000000000001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 354);
        }
    }
}
