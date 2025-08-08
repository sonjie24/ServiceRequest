using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class addPackageName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PackageName",
                table: "AppVersions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeviceModel",
                table: "AppOsMonitorings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "AppOsMonitorings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OsVersion",
                table: "AppOsMonitorings",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PackageName",
                table: "AppVersions");

            migrationBuilder.DropColumn(
                name: "DeviceModel",
                table: "AppOsMonitorings");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "AppOsMonitorings");

            migrationBuilder.DropColumn(
                name: "OsVersion",
                table: "AppOsMonitorings");

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 1, 40, 820, DateTimeKind.Unspecified).AddTicks(2990), "35797f4f-9fc1-483e-869e-df1a3508b8ef", new DateTime(2022, 3, 26, 2, 1, 40, 820, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 1, 40, 820, DateTimeKind.Unspecified).AddTicks(7060), "a9cb0b41-ddc3-4ac6-8827-7b8a573fbc6f", new DateTime(2022, 3, 26, 2, 1, 40, 820, DateTimeKind.Utc).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 1, 40, 820, DateTimeKind.Unspecified).AddTicks(7150), "600205da-bddc-4571-b1ca-805f0684d30f", new DateTime(2022, 3, 26, 2, 1, 40, 820, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 836, DateTimeKind.Unspecified).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 837, DateTimeKind.Unspecified).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 830, DateTimeKind.Unspecified).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 831, DateTimeKind.Unspecified).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 831, DateTimeKind.Unspecified).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 834, DateTimeKind.Unspecified).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "17c536e6-8b1b-4558-8fa1-f264e8746f37");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "e8005b76-112b-474c-a242-3a5623378153");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "d86f3c36-9013-487c-9267-f2d0c5b66be5");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "3660e1c7-adac-4c06-955d-ead19be72a20", new DateTime(2022, 3, 26, 10, 1, 40, 826, DateTimeKind.Unspecified).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "7df68898-fc52-4f9a-ad25-ab6738514c0d", new DateTime(2022, 3, 26, 10, 1, 40, 830, DateTimeKind.Unspecified).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "ec0aed88-a09c-475d-99c1-6e3e720a5308", new DateTime(2022, 3, 26, 10, 1, 40, 830, DateTimeKind.Unspecified).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 1, 40, 834, DateTimeKind.Unspecified).AddTicks(2190), "f2ca3004-d841-40c8-a8df-cd2f2805f36f" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 1, 40, 834, DateTimeKind.Unspecified).AddTicks(3200), "bce1efcb-68bc-45ec-bbab-65f1abda969a" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "340297dd-3af7-4829-850f-9865b41bc5b5");

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "73a4241b-82c6-48cf-b2d4-d0852889bff4");

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "7619e787-f37e-4f10-8f02-58ea44260cef");

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "59acc5b8-316e-4481-b92b-759fe21d0c48");

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(8440), "e7cc8017-6631-455d-ab67-a072fb017109" });

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 1, 40, 835, DateTimeKind.Unspecified).AddTicks(9690), "4c1fe144-c813-4d77-8737-56fa6311b73d" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "e38e1312-00da-4a50-89f2-83b54e1f6b8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "6d57ab73-8e6a-4860-990e-6ee63b116f30");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "b439e56d-585d-430d-b6e4-958a359df550");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "066ed7fe-d2bf-4365-a7fc-01fda21b1fea");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "4580d76d-deb9-4774-b8be-3eda9176b42e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "70452d04-6948-4e10-8119-ee2333f53b00");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "d6853907-ab05-439b-b6f8-b223160f9074");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "96a59b01-dd14-456a-bb42-64e16bbb7152");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "fc296852-7393-447d-86e8-b1bf14bc41de");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "626ddd7a-e001-443f-82ff-68ce5e7a6095");
        }
    }
}
