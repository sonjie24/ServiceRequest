using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class addAppversioning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppVersions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    AppName = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppVersions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 760, DateTimeKind.Unspecified).AddTicks(8090), "43ee4fa2-43a8-4476-9006-8d91fb0b672d", new DateTime(2022, 3, 2, 12, 35, 37, 760, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 761, DateTimeKind.Unspecified).AddTicks(2510), "9356e344-46cc-47b5-9f47-82328ea071b4", new DateTime(2022, 3, 2, 12, 35, 37, 761, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 761, DateTimeKind.Unspecified).AddTicks(2610), "13417f60-8ba6-4a3f-8bbd-87e92aadd37d", new DateTime(2022, 3, 2, 12, 35, 37, 761, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 775, DateTimeKind.Unspecified).AddTicks(8770), "ea974d36-85d5-4bf8-89fa-5c45aea14166" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 770, DateTimeKind.Unspecified).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 770, DateTimeKind.Unspecified).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 770, DateTimeKind.Unspecified).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 773, DateTimeKind.Unspecified).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "35f7ebfd-dd20-4b6a-92bf-707745e291f1");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "e492c558-e361-445d-9d66-66cc9d01009e");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "8f3def3e-d577-4d45-9f4a-58fa22bce105");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "d01fd651-2128-4e09-bc19-2b5d8f68d477", new DateTime(2022, 3, 2, 20, 35, 37, 766, DateTimeKind.Unspecified).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "edff132b-381d-4116-9d53-5d2ec3eb9939", new DateTime(2022, 3, 2, 20, 35, 37, 770, DateTimeKind.Unspecified).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "c5fd7e81-06a2-4623-a111-26a4e2e73806", new DateTime(2022, 3, 2, 20, 35, 37, 770, DateTimeKind.Unspecified).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 773, DateTimeKind.Unspecified).AddTicks(4570), "3ee4802a-4068-48c9-b019-d71f869be77b" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 773, DateTimeKind.Unspecified).AddTicks(5330), "e019465e-64ba-4b54-854a-e2c964ea983a" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(9420), "e098604a-8c39-421c-a472-0645cecf00f7" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 775, DateTimeKind.Unspecified).AddTicks(280), "7566299d-72ac-45cc-9596-93e98238d4a2" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 775, DateTimeKind.Unspecified).AddTicks(320), "2abb3b09-f536-46ec-975a-27d326b981ee" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 775, DateTimeKind.Unspecified).AddTicks(320), "f0122092-6a3c-405a-a4a2-b27fe885e184" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "ccab168a-b855-4b1f-8797-318ef766684c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "32d8a60c-622e-44fd-abdc-89dbd11bb64d");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "47e1d97a-c5db-4dff-ac1d-fd8a268e5f35");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "1b512bfb-29f6-42fe-8926-c62efb5d83d6");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "a8bfda65-d4df-4d51-91d8-5797fb0ae270");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "7b4c80ba-c976-4e60-bbde-e4ac6374b7e9");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "93690756-020c-4baf-84bc-a3d162b3bdef");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "1cdc5fff-35a7-41e5-9588-95b1c135e2e0");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "b900b3e7-7804-43cb-b364-9c5e507052be");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "849db180-f2c5-488f-9bf8-fe1bce0af72a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppVersions");

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 25, 14, 29, 33, 136, DateTimeKind.Unspecified).AddTicks(2550), "99cb289a-f09f-4191-860f-98678b337ded", new DateTime(2022, 2, 25, 6, 29, 33, 136, DateTimeKind.Utc).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 25, 14, 29, 33, 136, DateTimeKind.Unspecified).AddTicks(8070), "96ed656c-5beb-46ea-a12b-2c91e90378d3", new DateTime(2022, 2, 25, 6, 29, 33, 136, DateTimeKind.Utc).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 25, 14, 29, 33, 136, DateTimeKind.Unspecified).AddTicks(8190), "f14e3ac6-f937-465b-8452-92bab09e3642", new DateTime(2022, 2, 25, 6, 29, 33, 136, DateTimeKind.Utc).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 25, 14, 29, 33, 156, DateTimeKind.Unspecified).AddTicks(6030), "53b2c033-b840-41f1-a1fc-c8cce808f9dd" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 156, DateTimeKind.Unspecified).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 156, DateTimeKind.Unspecified).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 156, DateTimeKind.Unspecified).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 156, DateTimeKind.Unspecified).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 156, DateTimeKind.Unspecified).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 156, DateTimeKind.Unspecified).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 156, DateTimeKind.Unspecified).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 156, DateTimeKind.Unspecified).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 156, DateTimeKind.Unspecified).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 156, DateTimeKind.Unspecified).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 156, DateTimeKind.Unspecified).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 156, DateTimeKind.Unspecified).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 156, DateTimeKind.Unspecified).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 148, DateTimeKind.Unspecified).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 149, DateTimeKind.Unspecified).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 149, DateTimeKind.Unspecified).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 154, DateTimeKind.Unspecified).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 154, DateTimeKind.Unspecified).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 154, DateTimeKind.Unspecified).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 154, DateTimeKind.Unspecified).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 154, DateTimeKind.Unspecified).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 154, DateTimeKind.Unspecified).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 154, DateTimeKind.Unspecified).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 154, DateTimeKind.Unspecified).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 154, DateTimeKind.Unspecified).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 154, DateTimeKind.Unspecified).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 154, DateTimeKind.Unspecified).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 154, DateTimeKind.Unspecified).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 154, DateTimeKind.Unspecified).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 14, 29, 33, 154, DateTimeKind.Unspecified).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "959dbfd1-bc09-476e-88c7-e9f5e2039513");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "a74d679c-1e72-4662-bd48-380d777c42dd");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "4e2360a4-f817-4563-8c46-e4a4d2d0a9e8");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "8661627e-6ba8-4c71-8218-cffd36fb82c8", new DateTime(2022, 2, 25, 14, 29, 33, 142, DateTimeKind.Unspecified).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "1ec2dc12-7485-47a5-a7b7-4e201741f655", new DateTime(2022, 2, 25, 14, 29, 33, 148, DateTimeKind.Unspecified).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "26301109-9a57-4c6b-b80f-ca21ec7fdd2c", new DateTime(2022, 2, 25, 14, 29, 33, 148, DateTimeKind.Unspecified).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 25, 14, 29, 33, 153, DateTimeKind.Unspecified).AddTicks(6670), "fc9ff504-86ba-4cb4-b7a0-2ae35ed114f6" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 25, 14, 29, 33, 153, DateTimeKind.Unspecified).AddTicks(7830), "4275d4f1-b880-4d36-bdd9-4481623f2cdb" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 25, 14, 29, 33, 155, DateTimeKind.Unspecified).AddTicks(3720), "2efcfe03-1d4e-46e9-9054-7046ed92139b" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 25, 14, 29, 33, 155, DateTimeKind.Unspecified).AddTicks(4690), "0c47cd12-f11f-4cd0-a661-93f6383a985a" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 25, 14, 29, 33, 155, DateTimeKind.Unspecified).AddTicks(4730), "7b0a09dd-bf4b-4b86-b8bd-00d35ec06b8b" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 25, 14, 29, 33, 155, DateTimeKind.Unspecified).AddTicks(4750), "9e914cf4-c2be-466d-bbf9-aabd639996ee" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "f01d2514-3142-475a-948f-7d1c56c80679");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "dfb01a6f-e592-421e-8187-cf9a51abb2fc");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "cc5c11de-5fe9-4ff8-83d5-d41321ad7205");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "0c9b0800-03a4-4356-a581-3ba7453de6b5");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "387c0104-dcdb-49f0-879b-b32e411e011f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "f327d306-fd4f-4e6c-b2c3-327ebe3b2de9");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "171d4d0b-c343-46f3-91a5-62c072bb9b09");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "f02c3af8-90aa-466a-803d-c4ad2a8b29ee");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "499b9468-ef0a-404a-97e5-75af3b64e6f4");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "603f8dc4-e724-4c66-b262-bcd7dd14dfe7");
        }
    }
}
