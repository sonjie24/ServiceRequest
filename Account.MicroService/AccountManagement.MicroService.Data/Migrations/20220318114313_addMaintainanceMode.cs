using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class addMaintainanceMode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClosedReason",
                table: "Merchants",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MaintanceModes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    AppName = table.Column<string>(nullable: true),
                    IsMaintenanceMode = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintanceModes", x => x.Id);
                });

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
                columns: new[] { "BranchGroup", "ClosedReason", "DateCreated" },
                values: new object[] { "cf96bd76-2e63-4bf8-8b00-1bed1c983f6a", "", new DateTime(2022, 3, 18, 19, 43, 12, 222, DateTimeKind.Unspecified).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "ClosedReason", "DateCreated" },
                values: new object[] { "5a2554d6-c7ae-40be-a30c-bba4c5dd39bc", "", new DateTime(2022, 3, 18, 19, 43, 12, 225, DateTimeKind.Unspecified).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "ClosedReason", "DateCreated" },
                values: new object[] { "5453da2f-855b-485d-8b04-d7f218f8bae8", "", new DateTime(2022, 3, 18, 19, 43, 12, 225, DateTimeKind.Unspecified).AddTicks(5790) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaintanceModes");

            migrationBuilder.DropColumn(
                name: "ClosedReason",
                table: "Merchants");

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
    }
}
