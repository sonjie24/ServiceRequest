using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class updateRiderEntityModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "RiderActivities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 31, 5, 24, 6, 367, DateTimeKind.Unspecified).AddTicks(1910), "a776e135-dff8-4380-b98e-44824ee57890", new DateTime(2022, 3, 30, 21, 24, 6, 367, DateTimeKind.Utc).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 31, 5, 24, 6, 367, DateTimeKind.Unspecified).AddTicks(6150), "ceb3dada-c93c-49e3-90da-e709d5c3506e", new DateTime(2022, 3, 30, 21, 24, 6, 367, DateTimeKind.Utc).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 31, 5, 24, 6, 367, DateTimeKind.Unspecified).AddTicks(6240), "ac8310dc-a669-45ad-816d-11faa7159d7f", new DateTime(2022, 3, 30, 21, 24, 6, 367, DateTimeKind.Utc).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 386, DateTimeKind.Unspecified).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 387, DateTimeKind.Unspecified).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 387, DateTimeKind.Unspecified).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 387, DateTimeKind.Unspecified).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 387, DateTimeKind.Unspecified).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 387, DateTimeKind.Unspecified).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 387, DateTimeKind.Unspecified).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 387, DateTimeKind.Unspecified).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 387, DateTimeKind.Unspecified).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 387, DateTimeKind.Unspecified).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 387, DateTimeKind.Unspecified).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 387, DateTimeKind.Unspecified).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 387, DateTimeKind.Unspecified).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 387, DateTimeKind.Unspecified).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 378, DateTimeKind.Unspecified).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 378, DateTimeKind.Unspecified).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 378, DateTimeKind.Unspecified).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 382, DateTimeKind.Unspecified).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 383, DateTimeKind.Unspecified).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 383, DateTimeKind.Unspecified).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 383, DateTimeKind.Unspecified).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 383, DateTimeKind.Unspecified).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 383, DateTimeKind.Unspecified).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 383, DateTimeKind.Unspecified).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 383, DateTimeKind.Unspecified).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 383, DateTimeKind.Unspecified).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 383, DateTimeKind.Unspecified).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 383, DateTimeKind.Unspecified).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 383, DateTimeKind.Unspecified).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 383, DateTimeKind.Unspecified).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 5, 24, 6, 383, DateTimeKind.Unspecified).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "2069b0fe-e617-4b35-b7ac-d5f14e2f8873");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "b35de259-c9bc-448f-9a29-b2a2beb61f7e");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "35dbfef0-ece9-4986-b3a2-2f53ef6ff50a");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "f5ee8533-be0a-4d70-a280-5f439982dd3c", new DateTime(2022, 3, 31, 5, 24, 6, 373, DateTimeKind.Unspecified).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "b0663e17-31f2-43b9-a015-a7ff35463932", new DateTime(2022, 3, 31, 5, 24, 6, 378, DateTimeKind.Unspecified).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "35903c9c-b3f5-4343-9c88-b0a287bdcdb5", new DateTime(2022, 3, 31, 5, 24, 6, 378, DateTimeKind.Unspecified).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 31, 5, 24, 6, 382, DateTimeKind.Unspecified).AddTicks(4230), "9d3dcd39-e4c9-434e-b144-998cc2fd7aef" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 31, 5, 24, 6, 382, DateTimeKind.Unspecified).AddTicks(5400), "f11b880c-aa04-444c-942c-330ee5ab24b4" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 31, 5, 24, 6, 384, DateTimeKind.Unspecified).AddTicks(2750), "0f25ed99-16c6-4923-8f3b-7d84ce179869" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 31, 5, 24, 6, 384, DateTimeKind.Unspecified).AddTicks(4920), "a8ca9c73-5833-424a-a677-7ffa428d6035" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 31, 5, 24, 6, 384, DateTimeKind.Unspecified).AddTicks(4990), "810bc802-67fe-49b9-96d8-a363a8f20c8b" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 31, 5, 24, 6, 384, DateTimeKind.Unspecified).AddTicks(5000), "722cfe77-b45f-4481-8f62-860abe319cb6" });

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 31, 5, 24, 6, 384, DateTimeKind.Unspecified).AddTicks(7870), "2abfe416-3354-491e-bd8c-a2c4e93ce2b8" });

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 31, 5, 24, 6, 385, DateTimeKind.Unspecified).AddTicks(270), "9ab055de-8592-44e9-bc55-64c29e252420" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "86d32de6-3dfe-4c78-a70f-7fa74a1640b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "065dafe8-7e24-40d5-8346-a368e0bae5f6");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "6125bc74-9201-4014-a450-d45c281ec972");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "3937ec00-4f3c-4d49-ab96-8c43202b12a3");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "d32f6869-8c22-41b5-b381-a70227a6a3cc");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "97895038-5379-4ee1-961d-7b85ff0ff744");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "2e8caf99-8dbd-4fb0-b5b6-ef6e080804a0");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "4e64e9d1-c263-46f8-8cb4-5ebac04bd457");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "226963a3-6db8-4254-bd55-27797d559c0d");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "5093b590-78e5-423c-bf01-aa03f22950e1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "RiderActivities");

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 26, 12, 19, 5, 870, DateTimeKind.Unspecified).AddTicks(9890), "8bea1d10-aafb-4879-82ac-aa21b36f9392", new DateTime(2022, 3, 26, 4, 19, 5, 871, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 26, 12, 19, 5, 871, DateTimeKind.Unspecified).AddTicks(3750), "fd0bcc53-ce8f-48c6-9530-754cdb8e7186", new DateTime(2022, 3, 26, 4, 19, 5, 871, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 26, 12, 19, 5, 871, DateTimeKind.Unspecified).AddTicks(3830), "c25916a9-4dda-4a6b-b26c-5385fedf2ea2", new DateTime(2022, 3, 26, 4, 19, 5, 871, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 882, DateTimeKind.Unspecified).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 883, DateTimeKind.Unspecified).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 883, DateTimeKind.Unspecified).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 883, DateTimeKind.Unspecified).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 883, DateTimeKind.Unspecified).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 883, DateTimeKind.Unspecified).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 883, DateTimeKind.Unspecified).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 883, DateTimeKind.Unspecified).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 883, DateTimeKind.Unspecified).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 883, DateTimeKind.Unspecified).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 883, DateTimeKind.Unspecified).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 883, DateTimeKind.Unspecified).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 883, DateTimeKind.Unspecified).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 883, DateTimeKind.Unspecified).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 878, DateTimeKind.Unspecified).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 879, DateTimeKind.Unspecified).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 879, DateTimeKind.Unspecified).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "9de1511d-e918-4c70-9e0e-289afad6bdf8");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "ac18cb25-5808-47c7-92c2-ec9b52a740c7");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "926abcc1-ea3a-4464-8cd0-289c475adcff");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "457096df-ff8e-4fc1-a52f-1898dfc663ce", new DateTime(2022, 3, 26, 12, 19, 5, 876, DateTimeKind.Unspecified).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "46c52db4-cc38-41a6-8be0-0863c93e6f79", new DateTime(2022, 3, 26, 12, 19, 5, 878, DateTimeKind.Unspecified).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "72ec5687-36ae-4a56-bc6d-5eb2d151dba6", new DateTime(2022, 3, 26, 12, 19, 5, 878, DateTimeKind.Unspecified).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(1350), "bceb259c-9295-4ce1-944b-d19fa8f3b52b" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 26, 12, 19, 5, 881, DateTimeKind.Unspecified).AddTicks(2010), "61743964-aa18-4e09-9c85-bd167acb6b95" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "27843634-0ca1-4901-99b1-88fbd727f404");

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "7bc280ae-f267-4128-b156-d0a2c4602ae9");

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "26064ed0-5d70-4775-b10f-0fa1bc0935af");

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "a3f38cd7-fafc-454c-9829-3ecdce195c9a");

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 26, 12, 19, 5, 882, DateTimeKind.Unspecified).AddTicks(1330), "52171fd7-5b49-4278-9c06-41b613d36e6f" });

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 26, 12, 19, 5, 882, DateTimeKind.Unspecified).AddTicks(2330), "81cb89fd-18ab-41ed-bac0-e296be9970f7" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "5ad1d914-259a-44f5-8624-52c37ebdf668");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "78180d5c-bff5-43bf-8317-62f7b9d06a02");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "926224d4-e2fb-472d-a50f-e500374aac71");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "5bd369bc-9f62-45a7-93a5-dc0602a12d97");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "13c9cfe4-bcdc-4fa4-8618-986bbd4ffc63");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "4f93db9e-c270-4cb4-b88e-b64885c7d5c6");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "24cabd90-785f-40ee-ab46-332c4e64e253");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "e2ad8bf6-ce18-4ba1-b80b-9d1e2331fbac");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "5efe3641-a425-4bfd-b585-26612182d241");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "2da9f989-60ce-4b26-9dfe-e25585532cbd");
        }
    }
}
