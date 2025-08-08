using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class addStoreMinPurchaseAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "MininumPurchaseAmount",
                table: "Merchants",
                nullable: false,
                defaultValue: 0m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MininumPurchaseAmount",
                table: "Merchants");

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 10, 21, 54, 43, 167, DateTimeKind.Unspecified).AddTicks(5870), "ee43a778-5261-45ec-9527-20bef540673b", new DateTime(2022, 3, 10, 13, 54, 43, 167, DateTimeKind.Utc).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 10, 21, 54, 43, 167, DateTimeKind.Unspecified).AddTicks(9910), "60ae3bc4-db39-490c-91cd-0239f7063be3", new DateTime(2022, 3, 10, 13, 54, 43, 167, DateTimeKind.Utc).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 10, 21, 54, 43, 168, DateTimeKind.Unspecified), "15cb446b-a2da-45fc-885e-1a93344adbc4", new DateTime(2022, 3, 10, 13, 54, 43, 168, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 10, 21, 54, 43, 182, DateTimeKind.Unspecified).AddTicks(3270), "fa6cd815-dfb9-4e5c-807d-73c166c7fd7f" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 182, DateTimeKind.Unspecified).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 182, DateTimeKind.Unspecified).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 182, DateTimeKind.Unspecified).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 182, DateTimeKind.Unspecified).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 182, DateTimeKind.Unspecified).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 182, DateTimeKind.Unspecified).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 182, DateTimeKind.Unspecified).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 182, DateTimeKind.Unspecified).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 182, DateTimeKind.Unspecified).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 182, DateTimeKind.Unspecified).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 182, DateTimeKind.Unspecified).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 182, DateTimeKind.Unspecified).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 182, DateTimeKind.Unspecified).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 176, DateTimeKind.Unspecified).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 176, DateTimeKind.Unspecified).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 176, DateTimeKind.Unspecified).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 180, DateTimeKind.Unspecified).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 180, DateTimeKind.Unspecified).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 180, DateTimeKind.Unspecified).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 180, DateTimeKind.Unspecified).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 180, DateTimeKind.Unspecified).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 180, DateTimeKind.Unspecified).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 180, DateTimeKind.Unspecified).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 180, DateTimeKind.Unspecified).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 180, DateTimeKind.Unspecified).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 180, DateTimeKind.Unspecified).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 180, DateTimeKind.Unspecified).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 180, DateTimeKind.Unspecified).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 180, DateTimeKind.Unspecified).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 10, 21, 54, 43, 180, DateTimeKind.Unspecified).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "fd4f1523-d17c-4e80-a7e3-0ad68acb4a98");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "d03ad853-c25b-4868-a290-dec6b3382c9f");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "26ae323d-3cc6-4ed5-a39b-82413c7bf3f9");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "ee2ef60c-5cf6-41a9-adf5-a09df6af6f28", new DateTime(2022, 3, 10, 21, 54, 43, 173, DateTimeKind.Unspecified).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "842220b0-8b81-4b99-9152-66e2652749af", new DateTime(2022, 3, 10, 21, 54, 43, 176, DateTimeKind.Unspecified).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "18ab02fc-58b8-4676-93cd-b2a8e0a5f5ba", new DateTime(2022, 3, 10, 21, 54, 43, 176, DateTimeKind.Unspecified).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 10, 21, 54, 43, 179, DateTimeKind.Unspecified).AddTicks(8720), "480455da-bd24-4ae4-9e8e-0385ff746062" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 10, 21, 54, 43, 179, DateTimeKind.Unspecified).AddTicks(9830), "96009f7f-463b-4feb-87a8-ec6070a4017e" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 10, 21, 54, 43, 181, DateTimeKind.Unspecified).AddTicks(2590), "0ff89196-676b-4994-8a07-421785a06868" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 10, 21, 54, 43, 181, DateTimeKind.Unspecified).AddTicks(3280), "95436455-85df-4b49-8bfe-a6add6201acc" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 10, 21, 54, 43, 181, DateTimeKind.Unspecified).AddTicks(3310), "c4aa8d42-1421-446b-b8f8-81f3aa64477c" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 10, 21, 54, 43, 181, DateTimeKind.Unspecified).AddTicks(3320), "59a35220-a52e-49eb-b2b7-2dfc66c56fd2" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "ebde2c6a-1c2c-420e-b1d9-627c229b120a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "12b3ead6-0cb4-4395-9ec8-d1d475b90370");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "d94bdd59-8628-4c0e-828f-2327b1842d24");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "defaa90d-f2c2-401a-bfd0-b79f4a760496");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "0884750a-273c-4ef1-b167-13c0b0632f28");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "d25d9e2b-5c2e-4c1c-9677-051beb6f0ab7");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "3b7a556a-9460-43af-8fa1-df3999f3d316");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "7dc04ff0-42b7-4de4-9cae-c45cfea6d0cd");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "4b2d2c6b-382f-403e-882b-5797a7aea23e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "5d738dbf-9ff5-4aa6-bb77-432106d47cdd");
        }
    }
}
