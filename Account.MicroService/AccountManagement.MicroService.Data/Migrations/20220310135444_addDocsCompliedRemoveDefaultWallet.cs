using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class addDocsCompliedRemoveDefaultWallet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Riders_Wallets_DefaultWalletId",
                table: "Account_Riders");

            migrationBuilder.DropIndex(
                name: "IX_Account_Riders_DefaultWalletId",
                table: "Account_Riders");

            migrationBuilder.DropColumn(
                name: "DefaultWalletId",
                table: "Account_Riders");

            migrationBuilder.AddColumn<bool>(
                name: "IsDocsComplied",
                table: "Account_Riders",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDocsComplied",
                table: "Account_Riders");

            migrationBuilder.AddColumn<int>(
                name: "DefaultWalletId",
                table: "Account_Riders",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 9, 21, 34, 12, 741, DateTimeKind.Unspecified).AddTicks(1080), "7c235e71-10c0-4425-9d4e-b52608091a19", new DateTime(2022, 3, 9, 13, 34, 12, 741, DateTimeKind.Utc).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 9, 21, 34, 12, 741, DateTimeKind.Unspecified).AddTicks(5270), "c47ea340-2b60-464a-8ade-f2b4f0049000", new DateTime(2022, 3, 9, 13, 34, 12, 741, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 9, 21, 34, 12, 741, DateTimeKind.Unspecified).AddTicks(5390), "4ee98072-715c-4fc8-9f60-672672101869", new DateTime(2022, 3, 9, 13, 34, 12, 741, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 9, 21, 34, 12, 755, DateTimeKind.Unspecified).AddTicks(6310), "7560b347-9644-49be-8326-92a0e30dbdb9" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 755, DateTimeKind.Unspecified).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 755, DateTimeKind.Unspecified).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 755, DateTimeKind.Unspecified).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 755, DateTimeKind.Unspecified).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 755, DateTimeKind.Unspecified).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 755, DateTimeKind.Unspecified).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 755, DateTimeKind.Unspecified).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 755, DateTimeKind.Unspecified).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 755, DateTimeKind.Unspecified).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 755, DateTimeKind.Unspecified).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 755, DateTimeKind.Unspecified).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 755, DateTimeKind.Unspecified).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 755, DateTimeKind.Unspecified).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 749, DateTimeKind.Unspecified).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 749, DateTimeKind.Unspecified).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 749, DateTimeKind.Unspecified).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 753, DateTimeKind.Unspecified).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "d1357888-c038-4e9b-a906-ed1d3d2fe936");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "abb36b62-f84d-4600-aef7-a4cb26b4de67");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "fa08f56d-e120-4660-8bf8-fb1847721b21");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "eac3128d-e4fc-4bd2-b64f-b651d2616d19", new DateTime(2022, 3, 9, 21, 34, 12, 746, DateTimeKind.Unspecified).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "084aa67f-b9a7-4841-8224-0ca951f2e4f0", new DateTime(2022, 3, 9, 21, 34, 12, 749, DateTimeKind.Unspecified).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "e80b7ad4-8a3e-469d-960d-90c1553bb44c", new DateTime(2022, 3, 9, 21, 34, 12, 749, DateTimeKind.Unspecified).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 9, 21, 34, 12, 753, DateTimeKind.Unspecified).AddTicks(970), "3e66b4bd-0c96-4124-934d-1850739de564" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 9, 21, 34, 12, 753, DateTimeKind.Unspecified).AddTicks(1820), "1336dd01-22b4-4976-8f94-03b003cea94d" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(5820), "f2496e98-c6d7-493b-91d6-45803bbd00b0" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(6510), "42881e0d-5937-42c1-af0a-9c88b5ae9046" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(6540), "d7722661-b9c9-46f9-b4cb-aa3cdda127e6" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 9, 21, 34, 12, 754, DateTimeKind.Unspecified).AddTicks(6550), "b89f21b9-113a-41b8-bf59-d48ba7c524a1" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "781eb8d7-ad96-49b2-bd44-8697331e65d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "d501dcf6-1c8f-45ab-a823-0049d07f538b");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "f7db2f73-242a-4484-8c29-447e689626ac");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "acd72e89-89a7-4ee7-98d9-cbdcf7e1b2b1");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "3b5be802-a1f0-495c-86a0-01c383a96d4f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "0a17b01d-25e9-474c-94f7-22ba076a4ab1");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "5a26b184-5afa-4588-8b3e-f0a9d4d9b5c1");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "af8a41a8-39f3-480d-95c2-4a131c78339f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "39ebc4b3-bce2-4eb2-9b93-93a90a9be427");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "9d530e0d-9281-4c15-b2bb-15a78da1966f");

            migrationBuilder.CreateIndex(
                name: "IX_Account_Riders_DefaultWalletId",
                table: "Account_Riders",
                column: "DefaultWalletId");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Riders_Wallets_DefaultWalletId",
                table: "Account_Riders",
                column: "DefaultWalletId",
                principalTable: "Wallets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
