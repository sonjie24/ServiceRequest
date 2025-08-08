using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class adddeviceId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeviceId",
                table: "Account_Consumer",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "Account_Consumer");

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 7, 21, 37, 15, 454, DateTimeKind.Unspecified).AddTicks(3270), "a6d3e286-b48f-4134-95ae-f830bc98066b", new DateTime(2022, 3, 7, 13, 37, 15, 454, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 7, 21, 37, 15, 454, DateTimeKind.Unspecified).AddTicks(8490), "b2bc8ba0-21f2-4465-a02d-b2cd6b7f3cbf", new DateTime(2022, 3, 7, 13, 37, 15, 454, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 7, 21, 37, 15, 454, DateTimeKind.Unspecified).AddTicks(8600), "f29c57f5-b9d3-4418-b559-8de9e11a3205", new DateTime(2022, 3, 7, 13, 37, 15, 454, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 21, 37, 15, 469, DateTimeKind.Unspecified).AddTicks(9310), "68a54e8f-03f8-4089-9591-a136665c35cb" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 470, DateTimeKind.Unspecified).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 470, DateTimeKind.Unspecified).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 470, DateTimeKind.Unspecified).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 470, DateTimeKind.Unspecified).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 470, DateTimeKind.Unspecified).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 470, DateTimeKind.Unspecified).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 470, DateTimeKind.Unspecified).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 470, DateTimeKind.Unspecified).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 470, DateTimeKind.Unspecified).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 470, DateTimeKind.Unspecified).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 470, DateTimeKind.Unspecified).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 470, DateTimeKind.Unspecified).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 470, DateTimeKind.Unspecified).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 464, DateTimeKind.Unspecified).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 464, DateTimeKind.Unspecified).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 464, DateTimeKind.Unspecified).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 468, DateTimeKind.Unspecified).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 468, DateTimeKind.Unspecified).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 468, DateTimeKind.Unspecified).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 468, DateTimeKind.Unspecified).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 468, DateTimeKind.Unspecified).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 468, DateTimeKind.Unspecified).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 468, DateTimeKind.Unspecified).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 468, DateTimeKind.Unspecified).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 468, DateTimeKind.Unspecified).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 468, DateTimeKind.Unspecified).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 468, DateTimeKind.Unspecified).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 468, DateTimeKind.Unspecified).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 468, DateTimeKind.Unspecified).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 21, 37, 15, 468, DateTimeKind.Unspecified).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "5e24fac2-d13b-4c55-a76b-5dc498b73b30");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "808bdfee-5d6b-48fc-9a7a-6a30ec32345e");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "2eba5f1d-2921-41e1-a2e8-988f51f093b2");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "76f43e98-977c-48fc-b971-7dc6420e9ef8", new DateTime(2022, 3, 7, 21, 37, 15, 461, DateTimeKind.Unspecified).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "1176441c-81a6-4dc0-a831-2eafdba22b57", new DateTime(2022, 3, 7, 21, 37, 15, 464, DateTimeKind.Unspecified).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "d75de417-28f7-4a69-a22c-429042c7c1e6", new DateTime(2022, 3, 7, 21, 37, 15, 464, DateTimeKind.Unspecified).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 21, 37, 15, 467, DateTimeKind.Unspecified).AddTicks(6470), "cfe99f93-6de1-4d56-9c24-a80589cc324f" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 21, 37, 15, 467, DateTimeKind.Unspecified).AddTicks(7290), "bbfec3c5-ebcd-4ca3-94e3-5442274bd8c3" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 21, 37, 15, 469, DateTimeKind.Unspecified).AddTicks(960), "233b3580-0772-4379-893c-2666a6729b60" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 21, 37, 15, 469, DateTimeKind.Unspecified).AddTicks(1560), "60db3d29-a0d9-4b7b-9fa5-54409fe5e97e" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 21, 37, 15, 469, DateTimeKind.Unspecified).AddTicks(1590), "9e3da489-c007-45ad-8bf2-b6898f5517a9" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 21, 37, 15, 469, DateTimeKind.Unspecified).AddTicks(1590), "5c0e902e-eda3-4aaf-8448-9ea26ef9f2c5" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "0e231460-a073-4c3e-b303-2883cd2ab6dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "fa4bac1b-1bb9-4b45-b0f8-96b7d82551b4");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "fc2b840d-55ec-4ddc-b710-1014365554cd");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "e9cd6d9c-cc2a-4b1e-be3a-04f2034bf7ef");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "7f1eb6da-dcfc-447c-99fa-84c66f89c639");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "284ff6a9-24aa-4818-ba81-e6812df4dd99");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "6f26e65c-2550-47a2-ba31-d8a15a271b67");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "82894350-e554-415a-9069-57f2f559d43f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "6353c488-e576-49e5-aa21-65d121ff6f2b");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "65faa695-7260-4fb6-856c-7043eeb0c3d8");
        }
    }
}
