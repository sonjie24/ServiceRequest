using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class removetripsCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 12, 20, 7, 49, 525, DateTimeKind.Unspecified).AddTicks(6660), "d6028419-0361-425d-b403-627cded602db", new DateTime(2022, 3, 12, 12, 7, 49, 526, DateTimeKind.Utc).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 12, 20, 7, 49, 526, DateTimeKind.Unspecified).AddTicks(4680), "05ba8efc-547e-4b1f-aefd-cb65054dc22b", new DateTime(2022, 3, 12, 12, 7, 49, 526, DateTimeKind.Utc).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 12, 20, 7, 49, 526, DateTimeKind.Unspecified).AddTicks(4900), "78dcc67a-3c90-4396-a66f-78b2a3351be9", new DateTime(2022, 3, 12, 12, 7, 49, 526, DateTimeKind.Utc).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 12, 20, 7, 49, 546, DateTimeKind.Unspecified).AddTicks(3640), "93bdd270-4bd9-4de5-8123-9cff8d3d3e4a" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 546, DateTimeKind.Unspecified).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 546, DateTimeKind.Unspecified).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 546, DateTimeKind.Unspecified).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 546, DateTimeKind.Unspecified).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 546, DateTimeKind.Unspecified).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 546, DateTimeKind.Unspecified).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 546, DateTimeKind.Unspecified).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 546, DateTimeKind.Unspecified).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 546, DateTimeKind.Unspecified).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 546, DateTimeKind.Unspecified).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 546, DateTimeKind.Unspecified).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 546, DateTimeKind.Unspecified).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 546, DateTimeKind.Unspecified).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 537, DateTimeKind.Unspecified).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 537, DateTimeKind.Unspecified).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 537, DateTimeKind.Unspecified).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 543, DateTimeKind.Unspecified).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "c119721e-e49e-49b1-b850-3f357bc7d8a9");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "532580af-384b-40e4-a7cb-699b0c8785f5");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "393c88b7-8bd0-4eb5-a119-e34a00fe198b");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "aca571ce-af71-40b5-816c-d4f190c5586e", new DateTime(2022, 3, 12, 20, 7, 49, 533, DateTimeKind.Unspecified).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "94db87c1-b56d-47ea-9440-6746aa365f01", new DateTime(2022, 3, 12, 20, 7, 49, 537, DateTimeKind.Unspecified).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "4906fd08-bdb2-4028-a5f8-87f6a445147e", new DateTime(2022, 3, 12, 20, 7, 49, 537, DateTimeKind.Unspecified).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 12, 20, 7, 49, 543, DateTimeKind.Unspecified).AddTicks(3500), "93ec1b3e-61a3-445f-9ee8-d783cb2aedc8" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 12, 20, 7, 49, 543, DateTimeKind.Unspecified).AddTicks(4600), "d17f4845-3a21-4317-a140-5fb7da560dc2" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(8800), "c76a87b6-e7b8-48ca-8532-938362451369" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(9510), "0bd09461-7b87-4e66-8fb8-93033f284952" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(9540), "270c97cd-93e8-498a-bc03-bae8a1b25a27" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 12, 20, 7, 49, 544, DateTimeKind.Unspecified).AddTicks(9550), "3177d8bf-21d6-4bd0-a7f2-7b0e8b647557" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "e9e0a85c-cca5-40f2-ae82-81d00dd9d17e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "bff115c2-7e2e-40bf-b178-9071eb023d26");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "a7cc3f0d-519a-4dff-829c-4467577b6081");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "6cbaeed6-4e9d-43c2-80fb-e28c62ac1fb9");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "30d29c49-a377-4669-b443-db41bce02d8b");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "e02f98c3-7ba1-4b4a-86a3-8b17fa079cf8");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "ee6b1b07-82f4-4c7e-9146-a42685492da9");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "88691e41-6dc8-4cf9-9f2d-023d9beef53e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "a9ec9838-c7fc-4130-b6ef-98fc5fb5fc72");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "c7c5731a-4e9b-4e49-83d5-3f68fe993927");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 12, 11, 57, 21, 170, DateTimeKind.Unspecified).AddTicks(7220), "9709b0bf-382e-4f13-9078-67d9a288d53f", new DateTime(2022, 3, 12, 3, 57, 21, 170, DateTimeKind.Utc).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 12, 11, 57, 21, 171, DateTimeKind.Unspecified).AddTicks(1560), "42c743f5-8dac-4ddc-bd1e-61b4bc8e7d88", new DateTime(2022, 3, 12, 3, 57, 21, 171, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 12, 11, 57, 21, 171, DateTimeKind.Unspecified).AddTicks(1730), "c7494d9a-8d80-42fc-81c4-7ff91612d08a", new DateTime(2022, 3, 12, 3, 57, 21, 171, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 12, 11, 57, 21, 185, DateTimeKind.Unspecified).AddTicks(750), "0bc057f2-3534-4863-8387-e5ba376de47c" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 185, DateTimeKind.Unspecified).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 185, DateTimeKind.Unspecified).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 185, DateTimeKind.Unspecified).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 185, DateTimeKind.Unspecified).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 185, DateTimeKind.Unspecified).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 185, DateTimeKind.Unspecified).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 185, DateTimeKind.Unspecified).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 185, DateTimeKind.Unspecified).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 185, DateTimeKind.Unspecified).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 185, DateTimeKind.Unspecified).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 185, DateTimeKind.Unspecified).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 185, DateTimeKind.Unspecified).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 185, DateTimeKind.Unspecified).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 179, DateTimeKind.Unspecified).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 179, DateTimeKind.Unspecified).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 179, DateTimeKind.Unspecified).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "28bce1d6-5c80-4882-bd88-b36cc524c410");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "1ef33937-025e-4bb7-a895-1364da448c6e");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "3bdb0d03-384c-452a-aa78-ded556567f4b");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "a824ccc2-6230-48be-84ad-60e1a81aefdd", new DateTime(2022, 3, 12, 11, 57, 21, 176, DateTimeKind.Unspecified).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "e41b14de-117e-4dd1-a1d6-6d5b7c70ede6", new DateTime(2022, 3, 12, 11, 57, 21, 179, DateTimeKind.Unspecified).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "04d96da3-96ca-4fa5-b02e-ec56e9f9dee0", new DateTime(2022, 3, 12, 11, 57, 21, 179, DateTimeKind.Unspecified).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 12, 11, 57, 21, 182, DateTimeKind.Unspecified).AddTicks(6980), "48bac793-dc98-4f1c-b815-4cb4f86ac2e3" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 12, 11, 57, 21, 182, DateTimeKind.Unspecified).AddTicks(7800), "0867c39d-f386-41ae-a3ff-5115d8df2ac2" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 12, 11, 57, 21, 183, DateTimeKind.Unspecified).AddTicks(9710), "4a0923ba-bb36-4738-92cb-9a7811002d0d" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 12, 11, 57, 21, 184, DateTimeKind.Unspecified).AddTicks(370), "dd2cfb73-ea1a-41c2-9623-e5977c221547" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 12, 11, 57, 21, 184, DateTimeKind.Unspecified).AddTicks(460), "ba84eeb7-1ae3-4002-9b84-dad8a9ec4a7f" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 12, 11, 57, 21, 184, DateTimeKind.Unspecified).AddTicks(470), "f5bd9c8e-0127-4fc2-9f00-ad14aa26b20c" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "acb435dd-7501-443b-85ed-e3d9346624c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "89876ecc-8cc0-4964-959e-454fc3be4764");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "4f9c8efb-556e-430a-ab61-42dcd817f849");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "61129128-6942-47ff-8478-57e8281ee86b");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "195221d3-2d4d-48f6-a54f-42a143ed4a24");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "e0fa41ff-bcc1-4c34-bbf2-2c299651db4b");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "bdb62f91-3068-496f-a26a-bed0e1a7c407");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "3ce51dfd-6d19-4713-a069-548874e300e5");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "30ea35e4-3ba2-4548-9db3-0e82feb5c477");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "2c5c2d9c-9b02-4c60-87d7-6053a6fd6941");
        }
    }
}
