using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class storeFieldIsAllowed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isAllowedAdvanceOrder",
                table: "Merchants",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isAllowedPickUp",
                table: "Merchants",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 18, 21, 35, 16, 178, DateTimeKind.Unspecified).AddTicks(4420), "ddc768da-19c1-4e96-b41a-bc69c188136c", new DateTime(2022, 3, 18, 13, 35, 16, 178, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 18, 21, 35, 16, 178, DateTimeKind.Unspecified).AddTicks(8390), "e87adee6-506e-44d0-a020-e9b5a511fe99", new DateTime(2022, 3, 18, 13, 35, 16, 178, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 18, 21, 35, 16, 178, DateTimeKind.Unspecified).AddTicks(8480), "447b93e0-83d6-440c-a685-293343358acc", new DateTime(2022, 3, 18, 13, 35, 16, 178, DateTimeKind.Utc).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 18, 21, 35, 16, 194, DateTimeKind.Unspecified).AddTicks(6550), "8d72c598-55e7-4b66-b4d4-18bd07768b3d" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 194, DateTimeKind.Unspecified).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 194, DateTimeKind.Unspecified).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 194, DateTimeKind.Unspecified).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 194, DateTimeKind.Unspecified).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 194, DateTimeKind.Unspecified).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 194, DateTimeKind.Unspecified).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 194, DateTimeKind.Unspecified).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 194, DateTimeKind.Unspecified).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 194, DateTimeKind.Unspecified).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 194, DateTimeKind.Unspecified).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 194, DateTimeKind.Unspecified).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 194, DateTimeKind.Unspecified).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 194, DateTimeKind.Unspecified).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 188, DateTimeKind.Unspecified).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 188, DateTimeKind.Unspecified).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 188, DateTimeKind.Unspecified).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 192, DateTimeKind.Unspecified).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 192, DateTimeKind.Unspecified).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 192, DateTimeKind.Unspecified).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 192, DateTimeKind.Unspecified).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 192, DateTimeKind.Unspecified).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 192, DateTimeKind.Unspecified).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 192, DateTimeKind.Unspecified).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 192, DateTimeKind.Unspecified).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 192, DateTimeKind.Unspecified).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 192, DateTimeKind.Unspecified).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 192, DateTimeKind.Unspecified).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 192, DateTimeKind.Unspecified).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 192, DateTimeKind.Unspecified).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 21, 35, 16, 192, DateTimeKind.Unspecified).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "818bb2f8-8f4f-4320-bdd9-a1d40671206a");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "1f7bf27d-7c14-433e-97fe-c42657092857");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "f1f1a0b0-e0b3-46c5-b33c-32df127197d1");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "99b3b4ef-633b-474f-a9a8-f5f9b88e0571", new DateTime(2022, 3, 18, 21, 35, 16, 184, DateTimeKind.Unspecified).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "38181d0d-1ec8-4b86-88be-36cb05a2a659", new DateTime(2022, 3, 18, 21, 35, 16, 188, DateTimeKind.Unspecified).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "5041ed90-f5fe-4823-a8b4-aafd59c694cd", new DateTime(2022, 3, 18, 21, 35, 16, 188, DateTimeKind.Unspecified).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 18, 21, 35, 16, 191, DateTimeKind.Unspecified).AddTicks(5510), "ff3ad7cd-d968-468f-8bb8-ee8461583dbe" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 18, 21, 35, 16, 191, DateTimeKind.Unspecified).AddTicks(6340), "15d177da-95de-42a1-9085-f1db7a0330e5" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 18, 21, 35, 16, 193, DateTimeKind.Unspecified).AddTicks(3290), "9ae6685e-f8d9-4773-ba0c-0872b8ff20ff" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 18, 21, 35, 16, 193, DateTimeKind.Unspecified).AddTicks(4290), "adb8a884-7cc5-44ee-baa1-c38609b3ebec" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 18, 21, 35, 16, 193, DateTimeKind.Unspecified).AddTicks(4340), "50d83e9a-7272-4c19-b427-e1ea5e88607d" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 18, 21, 35, 16, 193, DateTimeKind.Unspecified).AddTicks(4350), "20adea56-9123-4218-9fd5-cadc0b4e3604" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "6fe2c385-7056-4822-9bd0-45d3d99cd3ed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "32f7b8a3-3738-4aae-8b73-65eb9300e42f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "f740e284-582e-425e-b33d-e15f4bdd5473");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "a4b2f62f-cfea-4cab-8e95-fe059687de03");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "841cf723-97e5-4b7b-aa67-765e287f155f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "8958836c-f242-4030-9b10-1510a7bb1c1f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "b6f445a3-aec7-4bb3-8792-644b5a61d06a");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "775e4f77-bb7e-4536-8273-8b599d5efbd4");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "8d001b4a-b53e-4a40-8c51-66c77ba05382");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "ae5c43d6-bdb3-47da-b577-7b7069cd9296");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAllowedAdvanceOrder",
                table: "Merchants");

            migrationBuilder.DropColumn(
                name: "isAllowedPickUp",
                table: "Merchants");

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 18, 19, 43, 12, 216, DateTimeKind.Unspecified).AddTicks(7160), "ff16bac1-3fcb-46d9-aba4-6302ca3ea8b9", new DateTime(2022, 3, 18, 11, 43, 12, 216, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 18, 19, 43, 12, 217, DateTimeKind.Unspecified).AddTicks(1950), "fc4399d7-5c6f-4a2f-be80-5720e7357778", new DateTime(2022, 3, 18, 11, 43, 12, 217, DateTimeKind.Utc).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 18, 19, 43, 12, 217, DateTimeKind.Unspecified).AddTicks(2050), "2727f05c-4327-4c97-b479-a589d66a21a7", new DateTime(2022, 3, 18, 11, 43, 12, 217, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 18, 19, 43, 12, 231, DateTimeKind.Unspecified).AddTicks(4210), "2928ee43-9921-4c53-8860-76661abb8257" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 231, DateTimeKind.Unspecified).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 231, DateTimeKind.Unspecified).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 231, DateTimeKind.Unspecified).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 231, DateTimeKind.Unspecified).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 231, DateTimeKind.Unspecified).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 231, DateTimeKind.Unspecified).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 231, DateTimeKind.Unspecified).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 231, DateTimeKind.Unspecified).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 231, DateTimeKind.Unspecified).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 231, DateTimeKind.Unspecified).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 231, DateTimeKind.Unspecified).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 231, DateTimeKind.Unspecified).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 231, DateTimeKind.Unspecified).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 225, DateTimeKind.Unspecified).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 225, DateTimeKind.Unspecified).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 225, DateTimeKind.Unspecified).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 229, DateTimeKind.Unspecified).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "a66708d8-ce69-40cb-81cf-a603ff28184d");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "7e76572e-cdbd-46b7-b507-85e512f3abb5");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "38b78839-bb9d-4e7c-9a98-ce52bcfb96a9");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "cf96bd76-2e63-4bf8-8b00-1bed1c983f6a", new DateTime(2022, 3, 18, 19, 43, 12, 222, DateTimeKind.Unspecified).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "5a2554d6-c7ae-40be-a30c-bba4c5dd39bc", new DateTime(2022, 3, 18, 19, 43, 12, 225, DateTimeKind.Unspecified).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "5453da2f-855b-485d-8b04-d7f218f8bae8", new DateTime(2022, 3, 18, 19, 43, 12, 225, DateTimeKind.Unspecified).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 18, 19, 43, 12, 229, DateTimeKind.Unspecified).AddTicks(2020), "364105f4-f786-4f39-bdf2-dc7c9780d8da" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 18, 19, 43, 12, 229, DateTimeKind.Unspecified).AddTicks(2850), "818fd918-3fcb-4755-85a0-c5820fff327a" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(4970), "4f9fa064-d3cd-4e74-b62f-f19ba1669f33" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(5590), "95c754ea-31d6-43a1-9592-d34c0ea8f996" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(5620), "94d15b6b-22e5-46a0-9424-2060fec25e6b" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 18, 19, 43, 12, 230, DateTimeKind.Unspecified).AddTicks(5620), "fc1913a4-b8ed-4dd8-ae7c-2ada270eda3f" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "c2f248fe-55fb-46ee-ad55-1651e8ba6f83");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "a22a8711-7c32-420b-b743-af0dcbb8f62d");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "0fb67b55-87db-45ed-8cd9-c8a59e4f3730");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "b45957c3-3dd6-4f89-88b4-981ebc5a94b8");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "57efe437-9080-47e6-afa1-f61b10beacd8");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "b8ba0adb-6e83-4e30-8e55-013978900a1b");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "bef2bc34-972b-4e9f-9ea1-976e503ad604");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "e1a1cbec-bbf5-46fd-a7ce-c3771c51706f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "deb2ee40-71b6-46b6-bd2e-c49cd4e6f5a0");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "dd092f26-de64-466d-9bca-28dc02368d48");
        }
    }
}
