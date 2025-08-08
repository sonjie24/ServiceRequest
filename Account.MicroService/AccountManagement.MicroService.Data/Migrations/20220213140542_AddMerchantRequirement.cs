using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class AddMerchantRequirement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsClose",
                table: "Merchants");

            migrationBuilder.DropColumn(
                name: "IsOnline",
                table: "Merchants");

            migrationBuilder.DropColumn(
                name: "IsPause",
                table: "Merchants");

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 22, DateTimeKind.Unspecified).AddTicks(4137), "1617a57e-c70f-414e-a0f5-ba08b952ef0f", new DateTime(2022, 2, 13, 14, 5, 40, 23, DateTimeKind.Utc).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 23, DateTimeKind.Unspecified).AddTicks(9468), "6f9f1182-8747-4b49-ac20-29b1d92d47bf", new DateTime(2022, 2, 13, 14, 5, 40, 23, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 23, DateTimeKind.Unspecified).AddTicks(9732), "0eff1752-d225-40d5-b614-c5728d8ac2f2", new DateTime(2022, 2, 13, 14, 5, 40, 23, DateTimeKind.Utc).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(1731), "0ebf087d-cdb6-4ec5-bcd3-5c3fb6daf1f6" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 164, DateTimeKind.Unspecified).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 165, DateTimeKind.Unspecified).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 165, DateTimeKind.Unspecified).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "29b291d3-27bb-4724-8a97-d92768bafef1");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "dfdb9e6d-6455-437f-a2e2-c2ee649eb385");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "146f0492-5a79-4512-a4af-189bd3e20b86");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "8c26a4f1-9a40-4035-bebe-b577b8e1c74e", new DateTime(2022, 2, 13, 22, 5, 40, 32, DateTimeKind.Unspecified).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "f3b4e651-b486-4298-b1fa-3bbe07c260ce", new DateTime(2022, 2, 13, 22, 5, 40, 164, DateTimeKind.Unspecified).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "5e7e35b8-758e-4133-8017-a357d87ebd0e", new DateTime(2022, 2, 13, 22, 5, 40, 164, DateTimeKind.Unspecified).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 169, DateTimeKind.Unspecified).AddTicks(7453), "79f24d18-deb3-4505-a475-da071122cc16" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 169, DateTimeKind.Unspecified).AddTicks(9062), "82c21992-e9d0-4ee3-8245-68e071cbb18b" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 171, DateTimeKind.Unspecified).AddTicks(2985), "2119087e-305e-4eb2-bac9-753bb1876790" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 171, DateTimeKind.Unspecified).AddTicks(4141), "26b60129-0189-4b9c-9a18-ee3facaf45e7" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 171, DateTimeKind.Unspecified).AddTicks(4191), "b5a031bc-8c1a-40aa-9c88-0911144c148f" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 171, DateTimeKind.Unspecified).AddTicks(4200), "c5f79202-a130-407f-827a-0ce711733213" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "42a5e8b5-b977-4f80-8c22-42b3739b60d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "8044ab00-6ac8-480b-915b-73aab2823b28");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "7911f2d7-c982-4edf-91b4-a9264b09234f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "20b0d9a8-94be-4144-81e3-e4efaa7d1307");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "e3c6dedd-74fc-4088-92cb-3b1439c7305e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "45d1e15d-26e7-4ea7-aa88-e53dac7ebf4c");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "59f6119c-0689-4388-9aac-074f964b43b5");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "2f7202a1-0277-4689-ab3b-22cdb3972ed3");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "a2338f2b-7f61-470e-b53b-87a62694b47d");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "3ceb2d16-881f-4f4f-a615-cda37e973ee3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsClose",
                table: "Merchants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOnline",
                table: "Merchants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPause",
                table: "Merchants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 4, 21, 10, 27, 856, DateTimeKind.Utc).AddTicks(9090), "16b2929b-aa75-457f-822d-91c0738c341d", new DateTime(2022, 2, 4, 21, 10, 27, 856, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 4, 21, 10, 27, 857, DateTimeKind.Utc).AddTicks(2180), "d573bb55-aac5-48cc-98c3-12da59472e2d", new DateTime(2022, 2, 4, 21, 10, 27, 857, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 4, 21, 10, 27, 857, DateTimeKind.Utc).AddTicks(2230), "7df12675-c21c-4036-a3cf-099e654d417e", new DateTime(2022, 2, 4, 21, 10, 27, 857, DateTimeKind.Utc).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 4, 21, 10, 27, 871, DateTimeKind.Utc).AddTicks(4570), "e7446a85-d765-4a35-b14f-6d83d8641d87" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 871, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 871, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 871, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 871, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 871, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 871, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 871, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 871, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 871, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 871, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 871, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 871, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 871, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 865, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 866, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 866, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 869, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "619d116d-c2de-4b79-99b4-71d8d291eb81");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "b42f8ae6-2ca9-403c-a49e-521c6448c2b6");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "2137f84c-3f0f-430a-9589-37717da603a0");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "1c986d79-ec08-4c2f-bc5e-61faaafbcd7c", new DateTime(2022, 2, 4, 21, 10, 27, 862, DateTimeKind.Utc).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "7f795c61-75c9-4460-ae46-2819e4c925c5", new DateTime(2022, 2, 4, 21, 10, 27, 865, DateTimeKind.Utc).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "52a39cf1-7808-48d6-a874-6ee5e818f243", new DateTime(2022, 2, 4, 21, 10, 27, 865, DateTimeKind.Utc).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 4, 21, 10, 27, 869, DateTimeKind.Utc).AddTicks(2590), "d67aaa05-97af-4b46-9bc9-4c427e2ab192" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 4, 21, 10, 27, 869, DateTimeKind.Utc).AddTicks(3520), "e55980f6-884f-40e5-a43d-3029be7700d5" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(5070), "cfa1ca06-0ce5-4c13-b928-4043b8fa479b" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(5800), "116a60b0-4662-4f3d-b850-08cc01b958c6" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(5830), "3d812cfb-749f-40e9-bd1d-2a2dffd9d6df" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 4, 21, 10, 27, 870, DateTimeKind.Utc).AddTicks(5830), "ffe57ce9-e3f0-47e2-9748-8f8c92f1bedc" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "1e816228-fba4-47e1-a885-a8f5e1baaf49");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "4335504e-4221-4798-9d35-02133d08a92b");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "497cb630-d379-43df-9f3c-97413ff968e9");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "8c554bf1-abd6-493d-8b78-2468ef5cfe13");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "ccf55c47-00df-40f2-82a6-8465f9bd3a87");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "4e02335a-238f-4d95-9bec-806526f86b33");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "1ca68432-9d78-4efd-93f6-07bd02c4a702");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "b8a14185-1605-4f76-b841-539e55ff24f0");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "6b9f4bc9-caea-47b6-bf84-e36947d9fac2");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "0a66b911-1f38-4b4e-8525-257b257706c1");
        }
    }
}
