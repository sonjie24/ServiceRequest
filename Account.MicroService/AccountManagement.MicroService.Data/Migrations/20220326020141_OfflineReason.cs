using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class OfflineReason : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoreOfflineReasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreOfflineReasons", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 1, 40, 820, DateTimeKind.Unspecified).AddTicks(2990), "35797f4f-9fc1-483e-869e-df1a3508b8ef", new DateTime(2022, 3, 26, 2, 1, 40, 820, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 1, 40, 820, DateTimeKind.Unspecified).AddTicks(7060), "a9cb0b41-ddc3-4ac6-8827-7b8a573fbc6f", new DateTime(2022, 3, 26, 2, 1, 40, 820, DateTimeKind.Utc).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 1, 40, 820, DateTimeKind.Unspecified).AddTicks(7150), "600205da-bddc-4571-b1ca-805f0684d30f", new DateTime(2022, 3, 26, 2, 1, 40, 820, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 836, DateTimeKind.Unspecified).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 830, DateTimeKind.Unspecified).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 831, DateTimeKind.Unspecified).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 831, DateTimeKind.Unspecified).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 834, DateTimeKind.Unspecified).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "17c536e6-8b1b-4558-8fa1-f264e8746f37");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "e8005b76-112b-474c-a242-3a5623378153");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "d86f3c36-9013-487c-9267-f2d0c5b66be5");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "3660e1c7-adac-4c06-955d-ead19be72a20", new DateTime(2022, 3, 26, 10, 1, 40, 826, DateTimeKind.Unspecified).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "7df68898-fc52-4f9a-ad25-ab6738514c0d", new DateTime(2022, 3, 26, 10, 1, 40, 830, DateTimeKind.Unspecified).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "ec0aed88-a09c-475d-99c1-6e3e720a5308", new DateTime(2022, 3, 26, 10, 1, 40, 830, DateTimeKind.Unspecified).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 1, 40, 834, DateTimeKind.Unspecified).AddTicks(2190), "f2ca3004-d841-40c8-a8df-cd2f2805f36f" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 1, 40, 834, DateTimeKind.Unspecified).AddTicks(3200), "bce1efcb-68bc-45ec-bbab-65f1abda969a" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "340297dd-3af7-4829-850f-9865b41bc5b5");

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "73a4241b-82c6-48cf-b2d4-d0852889bff4");

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "7619e787-f37e-4f10-8f02-58ea44260cef");

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "59acc5b8-316e-4481-b92b-759fe21d0c48");

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(8440), "e7cc8017-6631-455d-ab67-a072fb017109" });

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(9690), "4c1fe144-c813-4d77-8737-56fa6311b73d" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "e38e1312-00da-4a50-89f2-83b54e1f6b8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "6d57ab73-8e6a-4860-990e-6ee63b116f30");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "b439e56d-585d-430d-b6e4-958a359df550");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "066ed7fe-d2bf-4365-a7fc-01fda21b1fea");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "4580d76d-deb9-4774-b8be-3eda9176b42e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "70452d04-6948-4e10-8119-ee2333f53b00");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "d6853907-ab05-439b-b6f8-b223160f9074");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "96a59b01-dd14-456a-bb42-64e16bbb7152");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "fc296852-7393-447d-86e8-b1bf14bc41de");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "626ddd7a-e001-443f-82ff-68ce5e7a6095");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreOfflineReasons");

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 25, 21, 42, 16, 906, DateTimeKind.Unspecified).AddTicks(2650), "15d5b2bc-927c-4111-9497-eea2fc375a70", new DateTime(2022, 3, 25, 13, 42, 16, 906, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 25, 21, 42, 16, 906, DateTimeKind.Unspecified).AddTicks(6780), "383d5332-b8b7-4bf5-914f-128c30cb1232", new DateTime(2022, 3, 25, 13, 42, 16, 906, DateTimeKind.Utc).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 25, 21, 42, 16, 906, DateTimeKind.Unspecified).AddTicks(6880), "029c9259-9f00-4a37-8afc-71171eac7664", new DateTime(2022, 3, 25, 13, 42, 16, 906, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 922, DateTimeKind.Unspecified).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 923, DateTimeKind.Unspecified).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 923, DateTimeKind.Unspecified).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 923, DateTimeKind.Unspecified).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 923, DateTimeKind.Unspecified).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 923, DateTimeKind.Unspecified).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 923, DateTimeKind.Unspecified).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 923, DateTimeKind.Unspecified).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 923, DateTimeKind.Unspecified).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 923, DateTimeKind.Unspecified).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 923, DateTimeKind.Unspecified).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 923, DateTimeKind.Unspecified).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 923, DateTimeKind.Unspecified).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 923, DateTimeKind.Unspecified).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 917, DateTimeKind.Unspecified).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 917, DateTimeKind.Unspecified).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 917, DateTimeKind.Unspecified).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 920, DateTimeKind.Unspecified).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "2d519f05-f544-41ef-a133-cb9317f4cad3");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "c2d9620e-dadd-496c-b920-e999dad0df37");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "a1881f94-f2b1-41d9-9029-2ddc1e2f64e7");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "60804907-4e7b-4a99-a9b3-34357864a8d1", new DateTime(2022, 3, 25, 21, 42, 16, 913, DateTimeKind.Unspecified).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "a167ea1a-4ff7-4b73-8fea-499ff6c9ad3f", new DateTime(2022, 3, 25, 21, 42, 16, 917, DateTimeKind.Unspecified).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "508e5223-7fdf-4876-b05e-2adf2b171bb0", new DateTime(2022, 3, 25, 21, 42, 16, 917, DateTimeKind.Unspecified).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 21, 42, 16, 920, DateTimeKind.Unspecified).AddTicks(3200), "3440e12a-f3c5-439d-976d-bf7dbae5e942" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 21, 42, 16, 920, DateTimeKind.Unspecified).AddTicks(4070), "7a8c6ede-eb6b-46c7-9e3c-51ebacdb7b44" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "4bcf514f-10b5-4b60-b908-df79d613d3fe");

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "4c1e9575-f66b-4d86-b8ae-b5f521c97f24");

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "3e0b4895-aa66-410b-accb-9ae73f028ff6");

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "4374c45d-f0af-419f-bffb-d29b425466e5");

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(6580), "9bf4b474-cce2-4d13-873b-5928c23d7722" });

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 21, 42, 16, 921, DateTimeKind.Unspecified).AddTicks(7780), "c4990533-5538-441d-be84-b683dcc2a7db" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "e78db629-504d-4091-9037-3bf5897c384e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "ab708078-fc69-46ee-bf69-97e803078d3b");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "b1c9a530-c4b3-40ec-8cf7-5add2f00948a");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "5ecf648e-2716-4761-a347-4c3b3f943f00");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "a9f0f6f5-cad4-449b-a501-faf4fe16085c");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "7e23784e-7bb1-43e2-b5da-a999fd0c15d3");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "1d711e7f-d9b0-42ce-8402-83e7587fa155");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "7f787bd5-19e6-4c65-a594-8f5182dbab2e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "7b935394-d956-48a4-9c53-45abd4b1aebb");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "f3987922-0d06-4931-bfbc-8422632d5d00");
        }
    }
}
