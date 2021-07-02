using Microsoft.EntityFrameworkCore.Migrations;

namespace Avalara.StateSalesTax.Data.EntityFramework.Migrations
{
    public partial class MadeTaxRateFipsJurisdictionIdNullable_AddedZipCodesEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaxRates_FipsJurisdictionCodes_FipsJurisdictionCodeId",
                table: "TaxRates");

            migrationBuilder.AlterColumn<int>(
                name: "FipsJurisdictionCodeId",
                table: "TaxRates",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateTable(
                name: "ZipCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    CityName = table.Column<string>(type: "TEXT", nullable: true),
                    FipsJurisdictionCodeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZipCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZipCodes_FipsJurisdictionCodes_FipsJurisdictionCodeId",
                        column: x => x.FipsJurisdictionCodeId,
                        principalTable: "FipsJurisdictionCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 102, "99055", "DARE" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 103, "99063", "DURHAM" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 104, "99119", "MECKLENBURG" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 105, "99135", "ORANGE COUNTY" });

            migrationBuilder.InsertData(
                table: "FipsJurisdictionCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[] { 106, "99183", "WAKE FOREST" });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 700, "PINEBLUFF", "28373", 64 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 699, "PEMBROKE", "28372", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 698, "PARKTON", "28371", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 697, "PINEHURST", "28370", 64 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 696, "ORRUM", "28369", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 695, "OLIVIA", "28368", 44 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 693, "NEWTON GROVE", "28366", 83 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 701, "PINEHURST", "28374", 64 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 692, "MOUNT OLIVE", "28365", 97 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 691, "MAXTON", "28364", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 690, "MARSTON", "28363", 78 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 689, "MARIETTA", "28362", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 694, "NORMAN", "28367", 78 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 702, "PROCTORVILLE", "28375", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 704, "RED SPRINGS", "28377", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 688, "LUMBERTON", "28360", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 705, "REX", "28378", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 706, "ROCKINGHAM", "28379", 78 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 707, "ROCKINGHAM", "28380", 78 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 708, "ROSEBORO", "28382", 83 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 709, "ROWLAND", "28383", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 710, "SAINT PAULS", "28384", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 711, "SALEMBURG", "28385", 83 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 712, "SHANNON", "28386", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 713, "SOUTHERN PINES", "28387", 64 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 714, "SOUTHERN PINES", "28388", 64 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 715, "SPRING LAKE", "28390", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 716, "STEDMAN", "28391", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 703, "RAEFORD", "28376", 48 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 687, "LUMBERTON", "28359", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 684, "LINDEN", "28356", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 685, "LUMBER BRIDGE", "28357", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 656, "CALYPSO", "28325", 32 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 657, "CAMERON", "28326", 44 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 658, "CARTHAGE", "28327", 64 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 659, "CLINTON", "28328", 83 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 660, "CLINTON", "28329", 83 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 661, "CORDOVA", "28330", 78 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 662, "CUMBERLAND", "28331", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 663, "DUBLIN", "28332", 10 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 664, "DUDLEY", "28333", 97 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 665, "DUNN", "28334", 44 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 666, "DUNN", "28335", 44 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 667, "ELIZABETHTOWN", "28337", 10 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 668, "ELLERBE", "28338", 78 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 669, "ERWIN", "28339", 44 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 670, "FAIRMONT", "28340", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 671, "FAISON", "28341", 32 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 672, "FALCON", "28342", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 673, "GIBSON", "28343", 84 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 674, "GODWIN", "28344", 83 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 675, "HAMLET", "28345", 78 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 676, "HOFFMAN", "28347", 78 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 677, "HOPE MILLS", "28348", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 678, "KENANSVILLE", "28349", 32 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 679, "LAKEVIEW", "28350", 64 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 680, "LAUREL HILL", "28351", 84 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 681, "LAURINBURG", "28352", 84 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 682, "LAURINBURG", "28353", 84 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 683, "LEMON SPRINGS", "28355", 54 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 717, "TAR HEEL", "28392", 10 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 686, "LUMBERTON", "28358", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 718, "TURKEY", "28393", 83 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 721, "WAGRAM", "28396", 84 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 720, "WADE", "28395", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 754, "HAMPSTEAD", "28443", 72 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 755, "HARRELLS", "28444", 83 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 756, "HOLLY RIDGE", "28445", 68 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 757, "IVANHOE", "28447", 83 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 758, "KELLY", "28448", 10 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 759, "KURE BEACH", "28449", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 760, "LAKE WACCAMAW", "28450", 25 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 761, "LELAND", "28451", 11 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 762, "LONGWOOD", "28452", 11 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 763, "MAGNOLIA", "28453", 32 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 764, "MAPLE HILL", "28454", 72 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 765, "NAKINA", "28455", 25 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 766, "RIEGELWOOD", "28456", 25 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 767, "ROCKY POINT", "28457", 72 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 768, "ROSE HILL", "28458", 32 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 769, "SHALLOTTE", "28459", 11 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 770, "SNEADS FERRY", "28460", 68 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 771, "SOUTHPORT", "28461", 11 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 772, "SUPPLY", "28462", 11 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 773, "TABOR CITY", "28463", 25 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 774, "TEACHEY", "28464", 32 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 775, "OAK ISLAND", "28465", 11 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 776, "WALLACE", "28466", 32 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 777, "CALABASH", "28467", 11 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 778, "SUNSET BEACH", "28468", 11 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 779, "OCEAN ISLE BEACH", "28469", 11 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 780, "SHALLOTTE", "28470", 11 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 781, "WHITEVILLE", "28472", 25 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 782, "WILLARD", "28478", 72 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 753, "HALLSBORO", "28442", 25 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 719, "VASS", "28394", 64 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 752, "GARLAND", "28441", 83 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 750, "EVERGREEN", "28438", 25 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 655, "BUNNLEVEL", "28323", 44 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 722, "WARSAW", "28398", 32 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 723, "WHITE OAK", "28399", 10 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 724, "WILMINGTON", "28401", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 725, "WILMINGTON", "28402", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 726, "WILMINGTON", "28403", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 727, "WILMINGTON", "28404", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 728, "WILMINGTON", "28405", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 729, "WILMINGTON", "28406", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 730, "WILMINGTON", "28407", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 731, "WILMINGTON", "28408", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 732, "WILMINGTON", "28409", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 733, "WILMINGTON", "28411", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 734, "WILMINGTON", "28412", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 735, "ASH", "28420", 11 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 736, "ATKINSON", "28421", 72 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 737, "BOLIVIA", "28422", 11 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 738, "BOLTON", "28423", 25 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 739, "BRUNSWICK", "28424", 25 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 740, "BURGAW", "28425", 72 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 741, "CAROLINA BEACH", "28428", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 742, "CASTLE HAYNE", "28429", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 743, "CERRO GORDO", "28430", 25 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 744, "CHADBOURN", "28431", 25 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 745, "CLARENDON", "28432", 25 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 746, "CLARKTON", "28433", 10 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 747, "COUNCIL", "28434", 10 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 748, "CURRIE", "28435", 72 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 749, "DELCO", "28436", 25 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 751, "FAIR BLUFF", "28439", 25 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 654, "BLADENBORO", "28320", 10 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 652, "AUTRYVILLE", "28318", 83 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 783, "WINNABOW", "28479", 11 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 558, "SHELBY", "28150", 24 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 559, "SHELBY", "28151", 24 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 560, "SHELBY", "28152", 24 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 561, "SPENCER", "28159", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 562, "SPINDALE", "28160", 82 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 563, "STANFIELD", "28163", 85 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 564, "STANLEY", "28164", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 565, "TROUTMAN", "28166", 50 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 566, "UNION MILLS", "28167", 82 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 567, "VALE", "28168", 56 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 568, "WACO", "28169", 24 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 569, "WADESBORO", "28170", 5 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 570, "WAXHAW", "28173", 91 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 557, "SALISBURY", "28147", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 571, "WINGATE", "28174", 91 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 573, "CHARLOTTE", "28202", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 574, "CHARLOTTE", "28203", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 575, "CHARLOTTE", "28204", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 576, "CHARLOTTE", "28205", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 577, "CHARLOTTE", "28206", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 578, "CHARLOTTE", "28207", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 579, "CHARLOTTE", "28208", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 580, "CHARLOTTE", "28209", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 581, "CHARLOTTE", "28210", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 582, "CHARLOTTE", "28211", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 583, "CHARLOTTE", "28212", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 584, "CHARLOTTE", "28213", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 585, "CHARLOTTE", "28214", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 572, "CHARLOTTE", "28201", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 556, "SALISBURY", "28146", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 555, "SALISBURY", "28145", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 554, "SALISBURY", "28144", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 525, "MATTHEWS", "28104", 91 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 526, "MATTHEWS", "28105", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 527, "MATTHEWS", "28106", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 528, "MIDLAND", "28107", 14 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 529, "MINERAL SPRINGS", "28108", 91 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 530, "MISENHEIMER", "28109", 85 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 531, "MONROE", "28110", 91 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 532, "MONROE", "28111", 91 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 533, "MONROE", "28112", 91 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 534, "MOORESBORO", "28114", 24 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 535, "MOORESVILLE", "28115", 50 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 536, "MOORESVILLE", "28117", 50 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 537, "MORVEN", "28119", 5 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 538, "MOUNT HOLLY", "28120", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 539, "MOUNT MOURNE", "28123", 50 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 540, "MOUNT PLEASANT", "28124", 14 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 541, "MOUNT ULLA", "28125", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 542, "NEWELL", "28126", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 543, "NEW LONDON", "28127", 85 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 544, "NORWOOD", "28128", 85 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 545, "OAKBORO", "28129", 85 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 546, "PAW CREEK", "28130", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 547, "PEACHLAND", "28133", 5 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 548, "PINEVILLE", "28134", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 549, "POLKTON", "28135", 5 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 550, "POLKVILLE", "28136", 24 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 551, "RICHFIELD", "28137", 85 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 552, "ROCKWELL", "28138", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 553, "RUTHERFORDTON", "28139", 82 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 586, "CHARLOTTE", "28215", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 587, "CHARLOTTE", "28216", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 588, "CHARLOTTE", "28217", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 589, "CHARLOTTE", "28218", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 623, "CHARLOTTE", "28271", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 624, "CHARLOTTE", "28272", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 625, "CHARLOTTE", "28273", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 626, "CHARLOTTE", "28274", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 627, "CHARLOTTE", "28277", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 628, "CHARLOTTE", "28278", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 629, "CHARLOTTE", "28280", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 630, "CHARLOTTE", "28281", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 631, "CHARLOTTE", "28282", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 632, "CHARLOTTE", "28284", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 633, "CHARLOTTE", "28285", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 634, "CHARLOTTE", "28287", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 635, "CHARLOTTE", "28288", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 636, "CHARLOTTE", "28297", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 637, "CHARLOTTE", "28299", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 638, "FAYETTEVILLE", "28301", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 639, "FAYETTEVILLE", "28302", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 640, "FAYETTEVILLE", "28303", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 641, "FAYETTEVILLE", "28304", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 642, "FAYETTEVILLE", "28305", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 643, "FAYETTEVILLE", "28306", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 644, "FORT BRAGG", "28307", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 645, "POPE ARMY AIRFIELD", "28308", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 646, "FAYETTEVILLE", "28309", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 647, "FORT BRAGG", "28310", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 648, "FAYETTEVILLE", "28311", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 649, "FAYETTEVILLE", "28312", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 650, "FAYETTEVILLE", "28314", 27 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 651, "ABERDEEN", "28315", 64 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 622, "CHARLOTTE", "28270", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 653, "BARNESVILLE", "28319", 79 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 621, "CHARLOTTE", "28269", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 619, "CHARLOTTE", "28265", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 590, "CHARLOTTE", "28219", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 591, "CHARLOTTE", "28220", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 592, "CHARLOTTE", "28221", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 593, "CHARLOTTE", "28222", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 594, "CHARLOTTE", "28223", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 595, "CHARLOTTE", "28224", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 596, "CHARLOTTE", "28226", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 597, "CHARLOTTE", "28227", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 598, "CHARLOTTE", "28228", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 599, "CHARLOTTE", "28229", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 600, "CHARLOTTE", "28230", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 601, "CHARLOTTE", "28231", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 602, "CHARLOTTE", "28232", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 603, "CHARLOTTE", "28233", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 604, "CHARLOTTE", "28234", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 605, "CHARLOTTE", "28235", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 606, "CHARLOTTE", "28236", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 607, "CHARLOTTE", "28237", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 608, "CHARLOTTE", "28241", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 609, "CHARLOTTE", "28244", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 610, "CHARLOTTE", "28246", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 611, "CHARLOTTE", "28247", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 612, "CHARLOTTE", "28253", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 613, "CHARLOTTE", "28254", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 614, "CHARLOTTE", "28255", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 615, "CHARLOTTE", "28256", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 616, "CHARLOTTE", "28260", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 617, "CHARLOTTE", "28262", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 618, "CHARLOTTE", "28263", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 620, "CHARLOTTE", "28266", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 784, "WRIGHTSVILLE BEACH", "28480", 66 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 786, "KINSTON", "28502", 55 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 524, "MARSHVILLE", "28103", 91 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 951, "BAT CAVE", "28710", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 952, "BLACK MOUNTAIN", "28711", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 953, "BREVARD", "28712", 89 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 954, "BRYSON CITY", "28713", 88 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 955, "BURNSVILLE", "28714", 101 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 956, "CANDLER", "28715", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 957, "CANTON", "28716", 45 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 958, "CASHIERS", "28717", 51 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 959, "CEDAR MOUNTAIN", "28718", 89 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 960, "CHEROKEE", "28719", 88 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 961, "CHIMNEY ROCK", "28720", 82 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 962, "CLYDE", "28721", 45 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 963, "COLUMBUS", "28722", 76 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 950, "BARNARDSVILLE", "28709", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 964, "CULLOWHEE", "28723", 51 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 966, "DILLSBORO", "28725", 51 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 967, "EAST FLAT ROCK", "28726", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 968, "EDNEYVILLE", "28727", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 969, "ENKA", "28728", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 970, "ETOWAH", "28729", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 971, "FAIRVIEW", "28730", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 972, "FLAT ROCK", "28731", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 973, "FLETCHER", "28732", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 974, "FONTANA DAM", "28733", 39 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 975, "FRANKLIN", "28734", 58 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 976, "GERTON", "28735", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 977, "GLENVILLE", "28736", 51 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 978, "HAZELWOOD", "28738", 45 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 965, "DANA", "28724", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 949, "BALSAM GROVE", "28708", 89 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 948, "BALSAM", "28707", 51 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 947, "BAKERSVILLE", "28705", 62 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 918, "ROARING RIVER", "28669", 98 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 919, "RONDA", "28670", 98 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 920, "RUTHERFORD COLLEGE", "28671", 13 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 921, "SCOTTVILLE", "28672", 6 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 922, "SHERRILLS FORD", "28673", 19 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 923, "SPARTA", "28675", 4 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 924, "STATE ROAD", "28676", 87 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 925, "STATESVILLE", "28677", 50 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 926, "STONY POINT", "28678", 3 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 927, "SUGAR GROVE", "28679", 96 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 928, "MORGANTON", "28680", 13 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 929, "TAYLORSVILLE", "28681", 3 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 930, "TERRELL", "28682", 19 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 931, "THURMOND", "28683", 98 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 932, "TODD", "28684", 6 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 933, "TRAPHILL", "28685", 98 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 934, "STATESVILLE", "28687", 50 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 935, "UNION GROVE", "28689", 50 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 936, "VALDESE", "28690", 13 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 937, "VALLE CRUCIS", "28691", 96 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 938, "VILAS", "28692", 96 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 939, "WARRENSVILLE", "28693", 6 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 940, "WEST JEFFERSON", "28694", 6 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 941, "WILKESBORO", "28697", 98 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 942, "ZIONVILLE", "28698", 96 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 943, "SCOTTS", "28699", 50 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 944, "ALEXANDER", "28701", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 945, "ALMOND", "28702", 88 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 946, "ARDEN", "28704", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 979, "HENDERSONVILLE", "28739", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 980, "GREEN MOUNTAIN", "28740", 101 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 981, "HIGHLANDS", "28741", 58 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 982, "HORSE SHOE", "28742", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1016, "SYLVA", "28779", 51 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1017, "TOPTON", "28781", 21 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1018, "TRYON", "28782", 76 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1019, "TUCKASEGEE", "28783", 51 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1020, "TUXEDO", "28784", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1021, "WAYNESVILLE", "28785", 45 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1022, "WAYNESVILLE", "28786", 45 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1023, "WEAVERVILLE", "28787", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1024, "WEBSTER", "28788", 51 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1025, "WHITTIER", "28789", 51 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1026, "ZIRCONIA", "28790", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1027, "HENDERSONVILLE", "28791", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1028, "HENDERSONVILLE", "28792", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1029, "HENDERSONVILLE", "28793", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1030, "ASHEVILLE", "28801", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1031, "ASHEVILLE", "28802", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1032, "ASHEVILLE", "28803", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1033, "ASHEVILLE", "28804", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1034, "ASHEVILLE", "28805", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1035, "ASHEVILLE", "28806", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1036, "ASHEVILLE", "28810", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1037, "ASHEVILLE", "28813", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1038, "ASHEVILLE", "28814", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1039, "ASHEVILLE", "28815", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1040, "ASHEVILLE", "28816", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1041, "ANDREWS", "28901", 21 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1042, "BRASSTOWN", "28902", 23 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1043, "HAYESVILLE", "28904", 23 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1044, "MARBLE", "28905", 21 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1015, "SWANNANOA", "28778", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 917, "ROARING GAP", "28668", 4 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1014, "SPRUCE PINE", "28777", 62 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1012, "SCALY MOUNTAIN", "28775", 58 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 983, "HOT SPRINGS", "28743", 59 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 984, "FRANKLIN", "28744", 58 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 985, "LAKE JUNALUSKA", "28745", 45 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 986, "LAKE LURE", "28746", 82 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 987, "LAKE TOXAWAY", "28747", 89 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 988, "LEICESTER", "28748", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 989, "LITTLE SWITZERLAND", "28749", 57 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 990, "LYNN", "28750", 76 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 991, "MAGGIE VALLEY", "28751", 45 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 992, "MARION", "28752", 57 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 993, "MARSHALL", "28753", 59 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 994, "MARS HILL", "28754", 59 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 995, "MICAVILLE", "28755", 101 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 996, "MILL SPRING", "28756", 76 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 997, "MONTREAT", "28757", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 998, "MOUNTAIN HOME", "28758", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 999, "MILLS RIVER", "28759", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1000, "NAPLES", "28760", 46 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1001, "NEBO", "28761", 57 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1002, "OLD FORT", "28762", 57 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1003, "OTTO", "28763", 58 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1004, "PENLAND", "28765", 62 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1005, "PENROSE", "28766", 89 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1006, "PISGAH FOREST", "28768", 89 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1007, "RIDGECREST", "28770", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1008, "ROBBINSVILLE", "28771", 39 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1009, "ROSMAN", "28772", 89 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1010, "SALUDA", "28773", 76 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1011, "SAPPHIRE", "28774", 89 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1013, "SKYLAND", "28776", 12 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 785, "KINSTON", "28501", 55 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 916, "RHODHISS", "28667", 15 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 914, "PURLEAR", "28665", 98 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 820, "MCCUTCHEON FIELD", "28545", 68 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 821, "JACKSONVILLE", "28546", 68 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 822, "CAMP LEJEUNE", "28547", 68 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 823, "LA GRANGE", "28551", 55 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 824, "LOWLAND", "28552", 70 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 825, "MARSHALLBERG", "28553", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 826, "MAURY", "28554", 41 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 827, "MAYSVILLE", "28555", 53 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 828, "MERRITT", "28556", 70 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 829, "MOREHEAD CITY", "28557", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 830, "NEW BERN", "28560", 26 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 831, "NEW BERN", "28561", 26 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 832, "NEW BERN", "28562", 26 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 819, "MIDWAY PARK", "28544", 68 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 833, "NEW BERN", "28563", 26 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 835, "NEWPORT", "28570", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 836, "ORIENTAL", "28571", 70 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 837, "PINK HILL", "28572", 55 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 838, "POLLOCKSVILLE", "28573", 53 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 839, "RICHLANDS", "28574", 68 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 840, "SALTER PATH", "28575", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 841, "SEALEVEL", "28577", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 842, "SEVEN SPRINGS", "28578", 97 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 843, "SMYRNA", "28579", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 844, "SNOW HILL", "28580", 41 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 845, "STACY", "28581", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 846, "STELLA", "28582", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 847, "STONEWALL", "28583", 70 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 834, "NEW BERN", "28564", 26 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 818, "TARAWA TERRACE", "28543", 68 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 817, "CAMP LEJEUNE", "28542", 68 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 816, "JACKSONVILLE", "28541", 68 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 787, "KINSTON", "28503", 55 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 788, "KINSTON", "28504", 55 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 789, "ALBERTSON", "28508", 32 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 790, "ALLIANCE", "28509", 70 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 791, "ARAPAHOE", "28510", 70 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 792, "ATLANTIC", "28511", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 793, "ATLANTIC BEACH", "28512", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 794, "AYDEN", "28513", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 795, "BAYBORO", "28515", 70 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 796, "BEAUFORT", "28516", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 797, "BEULAVILLE", "28518", 32 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 798, "BRIDGETON", "28519", 26 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 799, "CEDAR ISLAND", "28520", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 800, "CHINQUAPIN", "28521", 32 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 801, "COVE CITY", "28523", 26 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 802, "DAVIS", "28524", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 803, "DEEP RUN", "28525", 55 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 804, "DOVER", "28526", 26 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 805, "ERNUL", "28527", 26 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 806, "GLOUCESTER", "28528", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 807, "GRANTSBORO", "28529", 70 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 808, "GRIFTON", "28530", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 809, "HARKERS ISLAND", "28531", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 810, "HAVELOCK", "28532", 26 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 811, "CHERRY POINT", "28533", 26 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 812, "HOBUCKEN", "28537", 70 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 813, "HOOKERTON", "28538", 41 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 814, "HUBERT", "28539", 68 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 815, "JACKSONVILLE", "28540", 68 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 848, "SWANSBORO", "28584", 68 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 849, "TRENTON", "28585", 53 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 850, "VANCEBORO", "28586", 26 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 851, "VANDEMERE", "28587", 70 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 885, "HARMONY", "28634", 50 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 886, "HAYS", "28635", 98 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 887, "HIDDENITE", "28636", 3 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 888, "HILDEBRAN", "28637", 13 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 889, "HUDSON", "28638", 15 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 890, "JEFFERSON", "28640", 6 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 891, "JONAS RIDGE", "28641", 13 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 892, "JONESVILLE", "28642", 100 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 893, "LANSING", "28643", 6 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 894, "LAUREL SPRINGS", "28644", 4 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 895, "LENOIR", "28645", 15 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 896, "LINVILLE", "28646", 7 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 897, "LINVILLE FALLS", "28647", 13 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 898, "MC GRADY", "28649", 98 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 899, "MAIDEN", "28650", 19 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 900, "MILLERS CREEK", "28651", 98 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 901, "MINNEAPOLIS", "28652", 7 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 902, "MONTEZUMA", "28653", 7 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 903, "MORAVIAN FALLS", "28654", 98 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 904, "MORGANTON", "28655", 13 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 905, "NORTH WILKESBORO", "28656", 98 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 906, "NEWLAND", "28657", 7 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 907, "NEWTON", "28658", 19 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 908, "NORTH WILKESBORO", "28659", 98 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 909, "OLIN", "28660", 50 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 910, "PATTERSON", "28661", 15 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 911, "PINEOLA", "28662", 7 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 912, "PINEY CREEK", "28663", 4 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 913, "PLUMTREE", "28664", 7 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 884, "LENOIR", "28633", 15 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 915, "ICARD", "28666", 13 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 883, "GRASSY CREEK", "28631", 6 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 881, "GLENDALE SPRINGS", "28629", 6 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 852, "WILLISTON", "28589", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 853, "WINTERVILLE", "28590", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 854, "EMERALD ISLE", "28594", 17 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 855, "HICKORY", "28601", 19 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 856, "HICKORY", "28602", 19 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 857, "HICKORY", "28603", 19 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 858, "BANNER ELK", "28604", 7 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 859, "BLOWING ROCK", "28605", 96 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 860, "BOOMER", "28606", 98 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 861, "BOONE", "28607", 96 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 862, "BOONE", "28608", 96 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 863, "CATAWBA", "28609", 19 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 864, "CLAREMONT", "28610", 19 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 865, "COLLETTSVILLE", "28611", 15 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 866, "CONNELLY SPRINGS", "28612", 13 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 867, "CONOVER", "28613", 19 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 868, "CRESTON", "28615", 6 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 869, "CROSSNORE", "28616", 7 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 870, "CRUMPLER", "28617", 6 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 871, "DEEP GAP", "28618", 96 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 872, "DREXEL", "28619", 13 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 873, "ELKIN", "28621", 87 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 874, "ELK PARK", "28622", 7 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 875, "ENNICE", "28623", 4 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 876, "FERGUSON", "28624", 98 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 877, "STATESVILLE", "28625", 50 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 878, "FLEETWOOD", "28626", 6 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 879, "GLADE VALLEY", "28627", 4 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 880, "GLEN ALPINE", "28628", 13 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 882, "GRANITE FALLS", "28630", 15 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 523, "MC FARLAN", "28102", 5 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 521, "LOWELL", "28098", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1045, "MURPHY", "28906", 21 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 165, "GREENSBORO", "27415", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 166, "GREENSBORO", "27416", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 167, "GREENSBORO", "27417", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 168, "GREENSBORO", "27419", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 169, "GREENSBORO", "27420", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 170, "GREENSBORO", "27425", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 171, "GREENSBORO", "27427", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 172, "GREENSBORO", "27429", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 173, "GREENSBORO", "27435", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 174, "GREENSBORO", "27438", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 175, "GREENSBORO", "27455", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 176, "GREENSBORO", "27495", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 177, "GREENSBORO", "27497", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 164, "GREENSBORO", "27412", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 178, "ANGIER", "27501", 44 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 180, "BAHAMA", "27503", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 181, "BENSON", "27504", 52 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 182, "BROADWAY", "27505", 54 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 183, "BUIES CREEK", "27506", 44 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 184, "BULLOCK", "27507", 40 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 185, "BUNN", "27508", 36 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 186, "BUTNER", "27509", 40 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 187, "CARRBORO", "27510", 69 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 188, "CARY", "27511", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 189, "CARY", "27512", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 190, "CARY", "27513", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 191, "CHAPEL HILL", "27514", 69 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 192, "CHAPEL HILL", "27515", 69 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 179, "APEX", "27502", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 163, "GREENSBORO", "27411", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 162, "GREENSBORO", "27410", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 161, "GREENSBORO", "27409", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 132, "SEDALIA", "27342", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 133, "SEMORA", "27343", 74 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 134, "SILER CITY", "27344", 20 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 135, "SNOW CAMP", "27349", 2 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 136, "SOPHIA", "27350", 77 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 137, "SOUTHMONT", "27351", 30 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 138, "STALEY", "27355", 77 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 139, "STAR", "27356", 63 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 140, "STOKESDALE", "27357", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 141, "SUMMERFIELD", "27358", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 142, "SWEPSONVILLE", "27359", 2 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 143, "THOMASVILLE", "27360", 30 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 144, "THOMASVILLE", "27361", 30 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 145, "TRINITY", "27370", 77 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 146, "TROY", "27371", 63 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 147, "WALLBURG", "27373", 30 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 148, "WELCOME", "27374", 30 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 149, "WENTWORTH", "27375", 80 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 150, "WEST END", "27376", 64 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 151, "WHITSETT", "27377", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 152, "YANCEYVILLE", "27379", 18 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 153, "GREENSBORO", "27401", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 154, "GREENSBORO", "27402", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 155, "GREENSBORO", "27403", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 156, "GREENSBORO", "27404", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 157, "GREENSBORO", "27405", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 158, "GREENSBORO", "27406", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 159, "GREENSBORO", "27407", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 160, "GREENSBORO", "27408", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 193, "CHAPEL HILL", "27516", 69 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 194, "CHAPEL HILL", "27517", 69 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 195, "CARY", "27518", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 196, "CARY", "27519", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 230, "MORRISVILLE", "27560", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 231, "NEW HILL", "27562", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 232, "NORLINA", "27563", 94 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 233, "OXFORD", "27565", 40 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 234, "PINE LEVEL", "27568", 52 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 235, "PRINCETON", "27569", 52 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 236, "RIDGEWAY", "27570", 94 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 237, "ROLESVILLE", "27571", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 238, "ROUGEMONT", "27572", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 239, "ROXBORO", "27573", 74 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 240, "ROXBORO", "27574", 74 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 241, "SELMA", "27576", 52 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 242, "SMITHFIELD", "27577", 52 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 243, "STEM", "27581", 40 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 244, "STOVALL", "27582", 40 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 245, "TIMBERLAKE", "27583", 74 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 246, "TOWNSVILLE", "27584", 92 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 247, "VAUGHAN", "27586", 94 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 248, "WAKE FOREST", "27587", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 249, "WAKE FOREST", "27588", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 250, "WARRENTON", "27589", 94 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 251, "WENDELL", "27591", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 252, "WILLOW SPRING", "27592", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 253, "WILSONS MILLS", "27593", 52 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 254, "WISE", "27594", 94 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 255, "YOUNGSVILLE", "27596", 36 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 256, "ZEBULON", "27597", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 257, "CHAPEL HILL", "27599", 69 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 258, "RALEIGH", "27601", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 229, "MONCURE", "27559", 20 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 131, "SEAGROVE", "27341", 77 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 228, "MIDDLESEX", "27557", 65 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 226, "MICRO", "27555", 52 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 197, "CLAYTON", "27520", 52 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 198, "COATS", "27521", 44 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 199, "CREEDMOOR", "27522", 40 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 200, "APEX", "27523", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 201, "FOUR OAKS", "27524", 52 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 202, "FRANKLINTON", "27525", 36 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 203, "FUQUAY VARINA", "27526", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 204, "CLAYTON", "27527", 52 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 205, "CLAYTON", "27528", 52 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 206, "GARNER", "27529", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 207, "GOLDSBORO", "27530", 97 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 208, "GOLDSBORO", "27531", 97 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 209, "GOLDSBORO", "27532", 97 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 210, "GOLDSBORO", "27533", 97 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 211, "GOLDSBORO", "27534", 97 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 212, "HENDERSON", "27536", 92 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 213, "HENDERSON", "27537", 92 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 214, "APEX", "27539", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 215, "HOLLY SPRINGS", "27540", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 216, "HURDLE MILLS", "27541", 74 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 217, "KENLY", "27542", 52 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 218, "KIPLING", "27543", 44 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 219, "KITTRELL", "27544", 92 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 220, "KNIGHTDALE", "27545", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 221, "LILLINGTON", "27546", 44 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 222, "LOUISBURG", "27549", 36 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 223, "MACON", "27551", 94 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 224, "MAMERS", "27552", 44 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 225, "MANSON", "27553", 92 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 227, "MIDDLEBURG", "27556", 92 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 259, "RALEIGH", "27602", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 130, "SAXAPAHAW", "27340", 2 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 128, "SANFORD", "27331", 54 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 34, "WOODLEAF", "27054", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 35, "YADKINVILLE", "27055", 100 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 36, "RURAL HALL", "27094", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 37, "WINSTON SALEM", "27101", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 38, "WINSTON SALEM", "27102", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 39, "WINSTON SALEM", "27103", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 40, "WINSTON SALEM", "27104", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 41, "WINSTON SALEM", "27105", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 42, "WINSTON SALEM", "27106", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 43, "WINSTON SALEM", "27107", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 44, "WINSTON SALEM", "27108", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 45, "WINSTON SALEM", "27109", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 46, "WINSTON SALEM", "27110", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 33, "WESTFIELD", "27053", 87 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 47, "WINSTON SALEM", "27113", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 49, "WINSTON SALEM", "27115", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 50, "WINSTON SALEM", "27116", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 51, "WINSTON SALEM", "27117", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 52, "WINSTON SALEM", "27120", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 53, "WINSTON SALEM", "27127", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 54, "WINSTON SALEM", "27150", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 55, "WINSTON SALEM", "27152", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 56, "WINSTON SALEM", "27155", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 57, "WINSTON SALEM", "27157", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 58, "WINSTON SALEM", "27199", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 59, "ALAMANCE", "27201", 2 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 60, "ALTAMAHAW", "27202", 2 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 61, "ASHEBORO", "27203", 77 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 48, "WINSTON SALEM", "27114", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 32, "WALNUT COVE", "27052", 86 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 31, "WALKERTOWN", "27051", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 30, "TOBACCOVILLE", "27050", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1, "ADVANCE", "27006", 31 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 2, "ARARAT", "27007", 87 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 3, "BELEWS CREEK", "27009", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 4, "BETHANIA", "27010", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 5, "BOONVILLE", "27011", 100 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 6, "CLEMMONS", "27012", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 7, "CLEVELAND", "27013", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 8, "COOLEEMEE", "27014", 31 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 9, "DANBURY", "27016", 86 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 10, "DOBSON", "27017", 87 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 11, "EAST BEND", "27018", 100 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 12, "GERMANTON", "27019", 86 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 13, "HAMPTONVILLE", "27020", 100 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 14, "KING", "27021", 86 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 15, "LAWSONVILLE", "27022", 86 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 16, "LEWISVILLE", "27023", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 17, "LOWGAP", "27024", 87 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 18, "MADISON", "27025", 80 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 19, "MAYODAN", "27027", 80 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 20, "MOCKSVILLE", "27028", 31 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 21, "MOUNT AIRY", "27030", 87 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 22, "PFAFFTOWN", "27040", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 23, "PILOT MOUNTAIN", "27041", 87 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 24, "PINE HALL", "27042", 86 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 25, "PINNACLE", "27043", 86 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 26, "RURAL HALL", "27045", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 27, "SANDY RIDGE", "27046", 86 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 28, "SILOAM", "27047", 87 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 29, "STONEVILLE", "27048", 80 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 62, "ASHEBORO", "27204", 77 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 63, "ASHEBORO", "27205", 77 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 64, "BEAR CREEK", "27207", 20 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 65, "BENNETT", "27208", 20 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 99, "JAMESTOWN", "27282", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 100, "JULIAN", "27283", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 101, "KERNERSVILLE", "27284", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 102, "KERNERSVILLE", "27285", 35 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 103, "EDEN", "27288", 80 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 104, "EDEN", "27289", 80 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 105, "LEASBURG", "27291", 18 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 106, "LEXINGTON", "27292", 30 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 107, "LEXINGTON", "27293", 30 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 108, "LEXINGTON", "27295", 30 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 109, "LIBERTY", "27298", 77 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 110, "LINWOOD", "27299", 30 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 111, "MC LEANSVILLE", "27301", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 112, "MEBANE", "27302", 2 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 113, "MILTON", "27305", 18 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 114, "MOUNT GILEAD", "27306", 63 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 115, "OAK RIDGE", "27310", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 116, "PELHAM", "27311", 18 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 117, "PITTSBORO", "27312", 20 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 118, "PLEASANT GARDEN", "27313", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 119, "PROSPECT HILL", "27314", 18 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 120, "PROVIDENCE", "27315", 18 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 121, "RAMSEUR", "27316", 77 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 122, "RANDLEMAN", "27317", 77 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 123, "REIDSVILLE", "27320", 80 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 124, "REIDSVILLE", "27323", 80 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 125, "ROBBINS", "27325", 64 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 126, "RUFFIN", "27326", 80 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 127, "SANFORD", "27330", 54 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 98, "JACKSON SPRINGS", "27281", 64 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 129, "SANFORD", "27332", 54 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 97, "HILLSBOROUGH", "27278", 69 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 95, "HIGH POINT", "27264", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 66, "BISCOE", "27209", 63 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 67, "BLANCH", "27212", 18 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 68, "BONLEE", "27213", 20 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 69, "BROWNS SUMMIT", "27214", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 70, "BURLINGTON", "27215", 2 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 71, "BURLINGTON", "27216", 2 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 72, "BURLINGTON", "27217", 2 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 73, "CANDOR", "27229", 63 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 74, "CEDAR FALLS", "27230", 77 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 75, "CEDAR GROVE", "27231", 69 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 76, "CLIMAX", "27233", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 77, "COLFAX", "27235", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 78, "CUMNOCK", "27237", 54 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 79, "DENTON", "27239", 30 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 80, "EAGLE SPRINGS", "27242", 64 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 81, "EFLAND", "27243", 69 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 82, "ELON", "27244", 2 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 83, "ETHER", "27247", 63 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 84, "FRANKLINVILLE", "27248", 77 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 85, "GIBSONVILLE", "27249", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 86, "GOLDSTON", "27252", 20 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 87, "GRAHAM", "27253", 2 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 88, "GULF", "27256", 20 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 89, "HAW RIVER", "27258", 2 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 90, "HIGHFALLS", "27259", 64 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 91, "HIGH POINT", "27260", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 92, "HIGH POINT", "27261", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 93, "HIGH POINT", "27262", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 94, "HIGH POINT", "27263", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 96, "HIGH POINT", "27265", 42 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 522, "MC ADENVILLE", "28101", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 260, "RALEIGH", "27603", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 262, "RALEIGH", "27605", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 427, "GRANDY", "27939", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 428, "HARBINGER", "27941", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 429, "HARRELLSVILLE", "27942", 47 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 430, "HATTERAS", "27943", 29 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 431, "HERTFORD", "27944", 73 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 432, "HOBBSVILLE", "27946", 38 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 433, "JARVISBURG", "27947", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 434, "KILL DEVIL HILLS", "27948", 29 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 435, "KITTY HAWK", "27949", 29 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 436, "KNOTTS ISLAND", "27950", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 437, "MANNS HARBOR", "27953", 29 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 438, "MANTEO", "27954", 29 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 439, "MAPLE", "27956", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 426, "GATESVILLE", "27938", 38 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 440, "MERRY HILL", "27957", 9 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 442, "NAGS HEAD", "27959", 29 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 443, "OCRACOKE", "27960", 49 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 444, "PLYMOUTH", "27962", 95 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 445, "POINT HARBOR", "27964", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 446, "POPLAR BRANCH", "27965", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 447, "POWELLS POINT", "27966", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 448, "POWELLSVILLE", "27967", 9 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 449, "RODANTHE", "27968", 29 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 450, "ROPER", "27970", 95 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 451, "SALVO", "27972", 29 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 452, "SHAWBORO", "27973", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 453, "SHILOH", "27974", 16 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 454, "SOUTH MILLS", "27976", 16 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 441, "MOYOCK", "27958", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 425, "GATES", "27937", 38 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 424, "FRISCO", "27936", 29 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 423, "EURE", "27935", 38 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 394, "WASHINGTON", "27889", 8 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 395, "WELDON", "27890", 43 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 396, "WHITAKERS", "27891", 65 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 397, "WILLIAMSTON", "27892", 60 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 398, "WILSON", "27893", 99 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 399, "WILSON", "27894", 99 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 400, "WILSON", "27895", 99 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 401, "WILSON", "27896", 99 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 402, "WOODLAND", "27897", 67 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 403, "ELIZABETH CITY", "27906", 71 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 404, "ELIZABETH CITY", "27907", 71 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 405, "ELIZABETH CITY", "27909", 71 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 406, "AHOSKIE", "27910", 47 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 407, "AVON", "27915", 29 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 408, "AYDLETT", "27916", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 409, "BARCO", "27917", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 410, "BELVIDERE", "27919", 73 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 411, "BUXTON", "27920", 29 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 412, "CAMDEN", "27921", 16 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 413, "COFIELD", "27922", 47 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 414, "COINJOCK", "27923", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 415, "COLERAIN", "27924", 9 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 416, "COLUMBIA", "27925", 90 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 417, "CORAPEAKE", "27926", 38 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 418, "COROLLA", "27927", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 419, "CRESWELL", "27928", 95 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 420, "CURRITUCK", "27929", 28 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 421, "HERTFORD", "27930", 73 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 422, "EDENTON", "27932", 22 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 455, "STUMPY POINT", "27978", 29 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 456, "SUNBURY", "27979", 38 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 457, "TYNER", "27980", 22 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 458, "WANCHESE", "27981", 29 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 492, "FALLSTON", "28042", 24 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 493, "FOREST CITY", "28043", 82 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 494, "GASTONIA", "28052", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 495, "GASTONIA", "28053", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 496, "GASTONIA", "28054", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 497, "GASTONIA", "28055", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 498, "GASTONIA", "28056", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 499, "HUNTERSVILLE", "28070", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 500, "GOLD HILL", "28071", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 501, "GRANITE QUARRY", "28072", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 502, "GROVER", "28073", 24 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 503, "HARRIS", "28074", 82 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 504, "HARRISBURG", "28075", 14 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 505, "HENRIETTA", "28076", 82 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 506, "HIGH SHOALS", "28077", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 507, "HUNTERSVILLE", "28078", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 508, "INDIAN TRAIL", "28079", 91 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 509, "IRON STATION", "28080", 56 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 510, "KANNAPOLIS", "28081", 14 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 511, "KANNAPOLIS", "28082", 14 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 512, "KANNAPOLIS", "28083", 14 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 513, "KINGS MOUNTAIN", "28086", 24 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 514, "LANDIS", "28088", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 515, "LATTIMORE", "28089", 24 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 516, "LAWNDALE", "28090", 24 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 517, "LILESVILLE", "28091", 5 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 518, "LINCOLNTON", "28092", 56 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 519, "LINCOLNTON", "28093", 56 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 520, "LOCUST", "28097", 85 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 491, "FAITH", "28041", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 393, "WALSTONBURG", "27888", 41 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 490, "ELLENBORO", "28040", 82 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 488, "EARL", "28038", 24 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 459, "WAVES", "27982", 29 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 460, "WINDSOR", "27983", 9 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 461, "WINFALL", "27985", 73 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 462, "WINTON", "27986", 47 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 463, "ALBEMARLE", "28001", 85 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 464, "ALBEMARLE", "28002", 85 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 465, "ALEXIS", "28006", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 466, "ANSONVILLE", "28007", 5 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 467, "BADIN", "28009", 85 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 468, "BARIUM SPRINGS", "28010", 50 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 469, "BELMONT", "28012", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 470, "BESSEMER CITY", "28016", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 471, "BOILING SPRINGS", "28017", 24 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 472, "BOSTIC", "28018", 82 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 473, "CAROLEEN", "28019", 82 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 474, "CASAR", "28020", 24 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 475, "CHERRYVILLE", "28021", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 476, "CHINA GROVE", "28023", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 477, "CLIFFSIDE", "28024", 82 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 478, "CONCORD", "28025", 14 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 479, "CONCORD", "28026", 14 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 480, "CONCORD", "28027", 14 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 481, "CORNELIUS", "28031", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 482, "CRAMERTON", "28032", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 483, "CROUSE", "28033", 56 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 484, "DALLAS", "28034", 37 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 485, "DAVIDSON", "28035", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 486, "DAVIDSON", "28036", 61 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 487, "DENVER", "28037", 56 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 489, "EAST SPENCER", "28039", 81 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 261, "RALEIGH", "27604", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 392, "TILLERY", "27887", 43 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 390, "SWANQUARTER", "27885", 49 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 296, "DURHAM", "27701", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 297, "DURHAM", "27702", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 298, "DURHAM", "27703", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 299, "DURHAM", "27704", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 300, "DURHAM", "27705", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 301, "DURHAM", "27706", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 302, "DURHAM", "27707", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 303, "DURHAM", "27708", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 304, "DURHAM", "27709", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 305, "DURHAM", "27710", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 306, "DURHAM", "27711", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 307, "DURHAM", "27712", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 308, "DURHAM", "27713", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 295, "RALEIGH", "27699", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 309, "DURHAM", "27715", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 311, "DURHAM", "27722", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 312, "ROCKY MOUNT", "27801", 34 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 313, "ROCKY MOUNT", "27802", 34 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 314, "ROCKY MOUNT", "27803", 65 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 315, "ROCKY MOUNT", "27804", 65 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 316, "AULANDER", "27805", 9 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 317, "AURORA", "27806", 8 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 318, "BAILEY", "27807", 65 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 319, "BATH", "27808", 8 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 320, "BATTLEBORO", "27809", 34 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 321, "BELHAVEN", "27810", 8 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 322, "BELLARTHUR", "27811", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 323, "BETHEL", "27812", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 310, "DURHAM", "27717", 33 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 294, "RALEIGH", "27697", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 293, "RALEIGH", "27695", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 292, "RALEIGH", "27676", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 263, "RALEIGH", "27606", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 264, "RALEIGH", "27607", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 265, "RALEIGH", "27608", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 266, "RALEIGH", "27609", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 267, "RALEIGH", "27610", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 268, "RALEIGH", "27611", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 269, "RALEIGH", "27612", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 270, "RALEIGH", "27613", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 271, "RALEIGH", "27614", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 272, "RALEIGH", "27615", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 273, "RALEIGH", "27616", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 274, "RALEIGH", "27617", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 275, "RALEIGH", "27619", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 276, "RALEIGH", "27620", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 277, "RALEIGH", "27622", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 278, "RALEIGH", "27623", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 279, "RALEIGH", "27624", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 280, "RALEIGH", "27625", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 281, "RALEIGH", "27627", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 282, "RALEIGH", "27628", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 283, "RALEIGH", "27629", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 284, "RALEIGH", "27635", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 285, "RALEIGH", "27636", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 286, "RALEIGH", "27650", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 287, "RALEIGH", "27656", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 288, "RALEIGH", "27658", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 289, "RALEIGH", "27661", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 290, "RALEIGH", "27668", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 291, "RALEIGH", "27675", 93 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 324, "BLACK CREEK", "27813", 99 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 325, "BLOUNTS CREEK", "27814", 8 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 326, "CASTALIA", "27816", 65 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 327, "CHOCOWINITY", "27817", 8 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 361, "MARGARETTSVILLE", "27853", 67 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 362, "MURFREESBORO", "27855", 47 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 363, "NASHVILLE", "27856", 65 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 364, "OAK CITY", "27857", 60 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 365, "GREENVILLE", "27858", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 366, "PANTEGO", "27860", 8 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 367, "PENDLETON", "27862", 67 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 368, "PIKEVILLE", "27863", 97 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 369, "PINETOPS", "27864", 34 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 370, "PINETOWN", "27865", 8 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 371, "PLEASANT HILL", "27866", 67 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 372, "POTECASI", "27867", 67 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 373, "RED OAK", "27868", 65 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 374, "RICH SQUARE", "27869", 67 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 375, "ROANOKE RAPIDS", "27870", 43 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 376, "ROBERSONVILLE", "27871", 60 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 377, "ROXOBEL", "27872", 9 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 378, "SARATOGA", "27873", 99 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 379, "SCOTLAND NECK", "27874", 43 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 380, "SCRANTON", "27875", 49 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 381, "SEABOARD", "27876", 67 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 382, "SEVERN", "27877", 67 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 383, "SHARPSBURG", "27878", 65 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 384, "SIMPSON", "27879", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 385, "SIMS", "27880", 99 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 386, "SPEED", "27881", 34 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 387, "SPRING HOPE", "27882", 65 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 388, "STANTONSBURG", "27883", 99 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 389, "STOKES", "27884", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 360, "MACCLESFIELD", "27852", 34 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 391, "TARBORO", "27886", 34 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 359, "LUCAMA", "27851", 99 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 357, "LEWISTON WOODVILLE", "27849", 9 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 328, "COMO", "27818", 47 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 329, "CONETOE", "27819", 34 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 330, "CONWAY", "27820", 67 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 331, "EDWARD", "27821", 8 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 332, "ELM CITY", "27822", 99 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 333, "ENFIELD", "27823", 43 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 334, "ENGELHARD", "27824", 49 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 335, "EVERETTS", "27825", 60 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 336, "FAIRFIELD", "27826", 49 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 337, "FALKLAND", "27827", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 338, "FARMVILLE", "27828", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 339, "FOUNTAIN", "27829", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 340, "FREMONT", "27830", 97 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 341, "GARYSBURG", "27831", 67 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 342, "GASTON", "27832", 67 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 343, "GREENVILLE", "27833", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 344, "GREENVILLE", "27834", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 345, "GREENVILLE", "27835", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 346, "GREENVILLE", "27836", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 347, "GRIMESLAND", "27837", 75 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 348, "HALIFAX", "27839", 43 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 349, "HAMILTON", "27840", 60 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 350, "HASSELL", "27841", 60 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 351, "HENRICO", "27842", 67 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 352, "HOBGOOD", "27843", 43 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 353, "HOLLISTER", "27844", 43 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 354, "JACKSON", "27845", 67 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 355, "JAMESVILLE", "27846", 60 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 356, "KELFORD", "27847", 9 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 358, "LITTLETON", "27850", 43 });

            migrationBuilder.InsertData(
                table: "ZipCodes",
                columns: new[] { "Id", "CityName", "Code", "FipsJurisdictionCodeId" },
                values: new object[] { 1046, "WARNE", "28909", 23 });

            migrationBuilder.CreateIndex(
                name: "IX_ZipCodes_FipsJurisdictionCodeId",
                table: "ZipCodes",
                column: "FipsJurisdictionCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxRates_FipsJurisdictionCodes_FipsJurisdictionCodeId",
                table: "TaxRates",
                column: "FipsJurisdictionCodeId",
                principalTable: "FipsJurisdictionCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaxRates_FipsJurisdictionCodes_FipsJurisdictionCodeId",
                table: "TaxRates");

            migrationBuilder.DropTable(
                name: "ZipCodes");

            migrationBuilder.DeleteData(
                table: "FipsJurisdictionCodes",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "FipsJurisdictionCodes",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "FipsJurisdictionCodes",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "FipsJurisdictionCodes",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "FipsJurisdictionCodes",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.AlterColumn<int>(
                name: "FipsJurisdictionCodeId",
                table: "TaxRates",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxRates_FipsJurisdictionCodes_FipsJurisdictionCodeId",
                table: "TaxRates",
                column: "FipsJurisdictionCodeId",
                principalTable: "FipsJurisdictionCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
