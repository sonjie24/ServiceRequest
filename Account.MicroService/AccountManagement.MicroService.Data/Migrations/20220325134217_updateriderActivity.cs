using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class updateriderActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "RiderActivities");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "RiderActivities");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "RiderActivities");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "RiderActivities");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "RiderActivities");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "RiderActivities");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "RiderActivities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "RiderActivities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "RiderActivities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "RiderActivities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "RiderActivities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "RiderActivities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 952, DateTimeKind.Unspecified).AddTicks(8730), "e5e3ade3-43a6-4ec1-a54b-5fcfe9c4b444", new DateTime(2022, 3, 25, 12, 28, 23, 953, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 953, DateTimeKind.Unspecified).AddTicks(3160), "68f36e5a-a286-446f-8226-d83c5cbda6ac", new DateTime(2022, 3, 25, 12, 28, 23, 953, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 953, DateTimeKind.Unspecified).AddTicks(3270), "1dca814d-5325-4808-8047-da64f16086d6", new DateTime(2022, 3, 25, 12, 28, 23, 953, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 968, DateTimeKind.Unspecified).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 968, DateTimeKind.Unspecified).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 968, DateTimeKind.Unspecified).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 962, DateTimeKind.Unspecified).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 962, DateTimeKind.Unspecified).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 962, DateTimeKind.Unspecified).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 965, DateTimeKind.Unspecified).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "39a3ad9d-70c1-42b1-8707-1c18a65f5a08");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "d23213fc-66c0-4d89-8d9b-ed2a5fb6b2b9");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "f737b4ea-2e10-400f-87ea-7627fc23c35c");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "03082cd9-5bd3-4766-a691-599831d60507", new DateTime(2022, 3, 25, 20, 28, 23, 958, DateTimeKind.Unspecified).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "35657b4f-b33f-4697-b19d-09aae2bd9eb3", new DateTime(2022, 3, 25, 20, 28, 23, 962, DateTimeKind.Unspecified).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "8777597f-c283-4f99-9df8-6be5fca1c9bf", new DateTime(2022, 3, 25, 20, 28, 23, 962, DateTimeKind.Unspecified).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 964, DateTimeKind.Unspecified).AddTicks(9910), "716753f8-2712-452b-bbf7-9ea2aad42caf" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 965, DateTimeKind.Unspecified).AddTicks(760), "faf61f2c-e315-42e5-a319-d6f0beead842" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(3840), "67a3be5f-91d2-43af-972d-5df316fdd4ea" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(4810), "dcadfcec-064b-4fc9-a918-11ab8f7ab420" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(4840), "0ac70cfb-8629-4442-b779-c85596147144" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(4850), "79c11c32-7e4f-4895-a59c-f51b07c5e970" });

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(5930), "c95eb491-ce00-495e-a767-3897f730399a" });

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(7400), "0b7fd136-86fa-4069-8860-7428c444c571" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "a22eb146-8799-443a-8f9f-2ae502890c09");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "5e9cb416-1744-42e1-9ff2-844a03ffd882");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "d1997307-bc23-486f-8a9e-ea2e95c02059");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "e2f2bce8-2bed-413b-bf1d-a353a95f10e7");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "3ef5587c-4b9d-467b-8d89-b8ccec2497b6");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "dbd1fdf2-e5ed-44af-83d9-5ddb00bf00f9");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "4b541e32-735b-4964-9789-2433b5ae1612");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "30499803-d620-4e55-a104-21f4a9b510fa");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "790288a0-d136-4d4e-8837-39267114169e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "ca2a387d-bccc-4f73-ac52-6677c626fa02");
        }
    }
}
