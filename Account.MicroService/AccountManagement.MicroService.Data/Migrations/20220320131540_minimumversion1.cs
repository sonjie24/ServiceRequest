using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class minimumversion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MinimumVersion",
                table: "AppVersions",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 419, DateTimeKind.Unspecified).AddTicks(770), "585dfd02-5745-473b-9e24-4d0d6de489ba", new DateTime(2022, 3, 20, 13, 15, 39, 419, DateTimeKind.Utc).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 419, DateTimeKind.Unspecified).AddTicks(4880), "1e4c0ceb-a76b-411c-a49c-b858cc268ebd", new DateTime(2022, 3, 20, 13, 15, 39, 419, DateTimeKind.Utc).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 419, DateTimeKind.Unspecified).AddTicks(4970), "527e1371-18a6-46bb-b7a9-9b2e6caab2a6", new DateTime(2022, 3, 20, 13, 15, 39, 419, DateTimeKind.Utc).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(3200), "12a43f20-6831-46fd-9cc8-f23dbdfc4953" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 427, DateTimeKind.Unspecified).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 427, DateTimeKind.Unspecified).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 427, DateTimeKind.Unspecified).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 430, DateTimeKind.Unspecified).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "ea148047-c2e1-490e-847c-9983f2cd3a3f");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "7ae7db62-e7e8-4b54-9da3-b8d18d782bcd");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "8b1accea-c8b2-464e-9b7c-106762e5fb41");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "e0d13747-1494-49ff-935b-3916ee1bae00", new DateTime(2022, 3, 20, 21, 15, 39, 424, DateTimeKind.Unspecified).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "ba0ec5ba-9515-4bd1-b7e4-51a5459e737d", new DateTime(2022, 3, 20, 21, 15, 39, 427, DateTimeKind.Unspecified).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "e635f762-dd0a-4ae1-be2f-537a446cb078", new DateTime(2022, 3, 20, 21, 15, 39, 427, DateTimeKind.Unspecified).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 430, DateTimeKind.Unspecified).AddTicks(4840), "d3fd7d3f-d0e4-48de-b041-29c6ae19f149" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 430, DateTimeKind.Unspecified).AddTicks(5510), "540aff7c-7401-493b-8c07-495ed0c8fb75" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(5470), "77d7e460-6c95-42cf-a5d7-bea15dab1602" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(6040), "55d9f7ca-2cbb-456c-a406-b1a29708799d" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(6070), "e2841798-f387-4228-9538-a34a7855dc58" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(6080), "04c81622-7e68-4d39-97b9-40573fbc211f" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "dd536349-2421-4841-8a1e-ace60e9a5d92");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "56585d2c-7c3e-4dd6-82f6-b820abaf80af");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "73fac67f-ba65-4cba-a7e2-7d082d155323");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "a800fae1-151a-4c43-b47e-c4adf1fa3371");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "bee27098-776a-4c84-8b09-4845ed61436a");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "4425d10c-3e1b-46d6-9871-3ab8e3df0ce8");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "7115c6e3-05d5-45c7-b183-d2f48479da96");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "0da92947-c49a-488f-a6e3-1178fdb08d0c");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "3a35717c-cb0e-454f-89fa-35fc1a1e6a75");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "9a947b1a-9bf4-43a6-8597-4c6534098973");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinimumVersion",
                table: "AppVersions");

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
    }
}
