using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Avalara.StateSalesTax.Data.EntityFramework.Migrations
{
    public partial class AddedTaxRatesForNcCounties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 1, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 233, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 232, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 231, new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 230, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 229, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 228, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 227, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 226, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 225, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 224, new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 223, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 222, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 221, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 220, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 219, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 218, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 217, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 234, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 235, new DateTime(2012, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 236, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 237, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 255, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 254, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 253, new DateTime(2008, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, 1, 1, 0.0, 0.0, 0.0275, 0.0275 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 252, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 251, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 250, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 249, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 248, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 216, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 247, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 245, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 244, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 243, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 242, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 241, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 240, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 239, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 238, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 246, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 256, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 215, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 213, new DateTime(2012, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 190, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 189, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 188, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 187, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 186, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 185, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 184, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 183, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 182, new DateTime(2010, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 181, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 180, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 179, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 178, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 177, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 176, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 175, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 174, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 191, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 192, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 193, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 194, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 212, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 211, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 210, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 209, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 208, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 207, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 206, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 205, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 214, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 204, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 202, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 201, new DateTime(2008, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 1, 1, 0.0, 0.0, 0.0275, 0.0275 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 200, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 199, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 198, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 197, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 196, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 195, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 203, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 173, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 257, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 259, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 319, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 318, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 317, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 316, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 315, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 314, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 313, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 312, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 311, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 310, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 309, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 308, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 307, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 306, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 305, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 304, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 303, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 320, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 321, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 322, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 323, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 341, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 340, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 339, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 338, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 337, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 336, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 335, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 334, new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 302, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 333, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 331, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 330, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 329, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 328, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 327, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 326, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 325, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 324, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 332, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 258, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 301, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 299, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 276, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 275, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 274, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 273, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 272, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 271, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 270, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 269, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 268, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 267, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 266, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 265, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 264, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 263, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 262, new DateTime(2010, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 261, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 260, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 277, new DateTime(2010, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 278, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 279, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 280, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 298, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 297, new DateTime(2008, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 1, 1, 0.0, 0.0, 0.0275, 0.0275 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 296, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 295, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 294, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 293, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 292, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 291, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 300, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 290, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 288, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 287, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 286, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 285, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 284, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 283, new DateTime(2008, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 1, 1, 0.0, 0.0, 0.0275, 0.0275 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 282, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 281, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 289, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 342, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 172, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 170, new DateTime(2010, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 61, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 60, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 59, new DateTime(2008, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 1, 1, 0.0, 0.0, 0.0275, 0.0275 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 58, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 57, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 56, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 55, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 54, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 53, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 52, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 51, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 50, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 49, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 48, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 47, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 46, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 45, new DateTime(2012, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 62, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 63, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 64, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 65, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 83, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 82, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 81, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 80, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 79, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 78, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 77, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 76, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 44, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 75, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 73, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 72, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 71, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 70, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 69, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 68, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 67, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 66, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 74, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 84, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 43, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 41, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 18, new DateTime(2015, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 17, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 16, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 15, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 14, new DateTime(2015, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 13, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 12, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 11, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 10, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 9, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 8, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 7, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 6, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 5, new DateTime(2008, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1, 0.0, 0.0, 0.0275, 0.0275 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 4, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 3, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 2, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 19, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 20, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 21, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 22, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 40, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 39, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 38, new DateTime(2012, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 37, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 36, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 35, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 34, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 33, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 42, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 32, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 30, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 29, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 28, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 27, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 26, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 25, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 24, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 23, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 31, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 171, new DateTime(2016, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 85, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 87, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 147, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 146, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 145, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 144, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 143, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 142, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 141, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 140, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 139, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 138, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 137, new DateTime(2013, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 136, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 135, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 134, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 133, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 132, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 131, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 148, new DateTime(2014, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 149, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 150, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 151, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 169, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 168, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 167, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 166, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 165, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 164, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 163, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 162, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 130, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 161, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 159, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 158, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 157, new DateTime(2010, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 156, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 155, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 154, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 153, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 152, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 160, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 86, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 129, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 127, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 104, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 103, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 102, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 101, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 100, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 99, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 98, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 97, new DateTime(2014, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 96, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 95, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 94, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 93, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 92, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 91, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 90, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 89, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 88, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 105, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 106, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 107, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 108, new DateTime(2012, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 126, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 125, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 124, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 123, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 122, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 121, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 120, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 119, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 128, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 118, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 116, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 115, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 114, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 113, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 112, new DateTime(2013, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 111, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 1, 1, 0.0, 0.0, 0.02, 0.02 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 110, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 1, 1, 0.0, 0.0, 0.022499999999999999, 0.022499999999999999 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 109, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 117, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 1, 1, 0.0, 0.0, 0.025000000000000001, 0.025000000000000001 });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "BeginDate", "EndDate", "FipsJurisdictionCodeId", "FipsJurisdictionTypeCodeId", "FipsStateCodeId", "FoodDrugInterstateRate", "FoodDrugIntrastateRate", "GeneralInterstateRate", "GeneralIntrastateRate" },
                values: new object[] { 343, new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, 1, 1, 0.0, 0.0, 0.02, 0.02 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: 343);
        }
    }
}
