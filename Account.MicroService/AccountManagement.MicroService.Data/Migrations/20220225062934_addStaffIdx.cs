using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class addStaffIdx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDocsComplied",
                table: "Merchants",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "StaffId",
                table: "Account_Admin",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDocsComplied",
                table: "Merchants");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Account_Admin");

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 22, 22, 5, 22, 866, DateTimeKind.Unspecified).AddTicks(7480), "facec211-ae3c-4db2-bacd-21231dcdd7ee", new DateTime(2022, 2, 22, 14, 5, 22, 866, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 22, 22, 5, 22, 867, DateTimeKind.Unspecified).AddTicks(1850), "d3b779f5-b2c2-4035-b6a3-65da33aa00a5", new DateTime(2022, 2, 22, 14, 5, 22, 867, DateTimeKind.Utc).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 22, 22, 5, 22, 867, DateTimeKind.Unspecified).AddTicks(1940), "f3be724a-ff74-4444-b63d-20c47fecc4e6", new DateTime(2022, 2, 22, 14, 5, 22, 867, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 22, 22, 5, 22, 883, DateTimeKind.Unspecified).AddTicks(950), "21b3f040-56a7-4b60-a1d0-9f3910effd61" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 883, DateTimeKind.Unspecified).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 883, DateTimeKind.Unspecified).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 883, DateTimeKind.Unspecified).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 883, DateTimeKind.Unspecified).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 883, DateTimeKind.Unspecified).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 883, DateTimeKind.Unspecified).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 883, DateTimeKind.Unspecified).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 883, DateTimeKind.Unspecified).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 883, DateTimeKind.Unspecified).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 883, DateTimeKind.Unspecified).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 883, DateTimeKind.Unspecified).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 883, DateTimeKind.Unspecified).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 883, DateTimeKind.Unspecified).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 876, DateTimeKind.Unspecified).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 877, DateTimeKind.Unspecified).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 877, DateTimeKind.Unspecified).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 881, DateTimeKind.Unspecified).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 881, DateTimeKind.Unspecified).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 881, DateTimeKind.Unspecified).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 881, DateTimeKind.Unspecified).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 881, DateTimeKind.Unspecified).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 881, DateTimeKind.Unspecified).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 881, DateTimeKind.Unspecified).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 881, DateTimeKind.Unspecified).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 881, DateTimeKind.Unspecified).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 881, DateTimeKind.Unspecified).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 881, DateTimeKind.Unspecified).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 881, DateTimeKind.Unspecified).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 881, DateTimeKind.Unspecified).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 22, 5, 22, 881, DateTimeKind.Unspecified).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "4f2239ef-928f-49d0-9dc6-bc9a6a2e5325");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "ea86dfdf-8132-400f-a5d6-7a027109a8b8");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "898ef80f-12ca-47cb-8854-413a6ea4b4c2");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "1f6726d6-0821-420f-aa12-eddfccab6579", new DateTime(2022, 2, 22, 22, 5, 22, 872, DateTimeKind.Unspecified).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "943bb8a0-5fc9-4df6-8018-f8efee28be53", new DateTime(2022, 2, 22, 22, 5, 22, 876, DateTimeKind.Unspecified).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "bd06aad5-c7ab-41f4-9616-ea8ecd7eb94e", new DateTime(2022, 2, 22, 22, 5, 22, 876, DateTimeKind.Unspecified).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 22, 22, 5, 22, 880, DateTimeKind.Unspecified).AddTicks(4920), "b5faa2d7-5bae-464d-a258-5991defe8f92" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 22, 22, 5, 22, 880, DateTimeKind.Unspecified).AddTicks(5930), "b5a32da3-16ee-4508-b952-35b4155ebe00" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 22, 22, 5, 22, 882, DateTimeKind.Unspecified).AddTicks(290), "15c9158d-693c-4674-84b1-f8d3f8f8bb05" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 22, 22, 5, 22, 882, DateTimeKind.Unspecified).AddTicks(1090), "5ce4005e-eb16-4c9c-af30-00eafb40bf70" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 22, 22, 5, 22, 882, DateTimeKind.Unspecified).AddTicks(1130), "ccb2c6ed-fe08-4b7c-b5f1-bb6c123c4a02" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 22, 22, 5, 22, 882, DateTimeKind.Unspecified).AddTicks(1130), "dcce1f64-fc92-4b76-af7d-ef0fa1faee8c" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "7b0326f8-efb6-4356-ad19-dfb5530f675b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "28e6dc2e-6cbc-49b7-ab16-e67677331933");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "3fe6e2a1-82b6-4d84-b2c3-b3c09487bd65");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "d253a9d8-1c14-465e-9418-1c3fdb276c40");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "db45ea3e-ad16-451b-8e88-c3b7880d0fdd");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "5e11a8d3-5d9b-4788-9476-24b8a2c00ccd");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "8162e9a4-46c4-438e-b158-e9f23e416420");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "71a6514c-4a62-4d41-937f-97bba43c573b");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "e74424ae-b24f-48f2-ad4c-31b3b0c09b3d");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "17068c72-7623-4dec-a7fb-bb1a66ae8127");
        }
    }
}
