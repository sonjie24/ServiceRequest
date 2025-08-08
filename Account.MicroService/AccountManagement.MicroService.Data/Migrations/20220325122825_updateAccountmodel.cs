using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class updateAccountmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 952, DateTimeKind.Unspecified).AddTicks(8730), "e5e3ade3-43a6-4ec1-a54b-5fcfe9c4b444", new DateTime(2022, 3, 25, 12, 28, 23, 953, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 953, DateTimeKind.Unspecified).AddTicks(3160), "68f36e5a-a286-446f-8226-d83c5cbda6ac", new DateTime(2022, 3, 25, 12, 28, 23, 953, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 953, DateTimeKind.Unspecified).AddTicks(3270), "1dca814d-5325-4808-8047-da64f16086d6", new DateTime(2022, 3, 25, 12, 28, 23, 953, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 967, DateTimeKind.Unspecified).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 968, DateTimeKind.Unspecified).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 968, DateTimeKind.Unspecified).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 968, DateTimeKind.Unspecified).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 962, DateTimeKind.Unspecified).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 962, DateTimeKind.Unspecified).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 962, DateTimeKind.Unspecified).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 965, DateTimeKind.Unspecified).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "39a3ad9d-70c1-42b1-8707-1c18a65f5a08");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "d23213fc-66c0-4d89-8d9b-ed2a5fb6b2b9");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "f737b4ea-2e10-400f-87ea-7627fc23c35c");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "03082cd9-5bd3-4766-a691-599831d60507", new DateTime(2022, 3, 25, 20, 28, 23, 958, DateTimeKind.Unspecified).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "35657b4f-b33f-4697-b19d-09aae2bd9eb3", new DateTime(2022, 3, 25, 20, 28, 23, 962, DateTimeKind.Unspecified).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "8777597f-c283-4f99-9df8-6be5fca1c9bf", new DateTime(2022, 3, 25, 20, 28, 23, 962, DateTimeKind.Unspecified).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 964, DateTimeKind.Unspecified).AddTicks(9910), "716753f8-2712-452b-bbf7-9ea2aad42caf" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 965, DateTimeKind.Unspecified).AddTicks(760), "faf61f2c-e315-42e5-a319-d6f0beead842" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(3840), "67a3be5f-91d2-43af-972d-5df316fdd4ea" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(4810), "dcadfcec-064b-4fc9-a918-11ab8f7ab420" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(4840), "0ac70cfb-8629-4442-b779-c85596147144" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(4850), "79c11c32-7e4f-4895-a59c-f51b07c5e970" });

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(5930), "c95eb491-ce00-495e-a767-3897f730399a" });

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 28, 23, 966, DateTimeKind.Unspecified).AddTicks(7400), "0b7fd136-86fa-4069-8860-7428c444c571" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "a22eb146-8799-443a-8f9f-2ae502890c09");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "5e9cb416-1744-42e1-9ff2-844a03ffd882");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "d1997307-bc23-486f-8a9e-ea2e95c02059");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "e2f2bce8-2bed-413b-bf1d-a353a95f10e7");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "3ef5587c-4b9d-467b-8d89-b8ccec2497b6");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "dbd1fdf2-e5ed-44af-83d9-5ddb00bf00f9");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "4b541e32-735b-4964-9789-2433b5ae1612");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "30499803-d620-4e55-a104-21f4a9b510fa");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "790288a0-d136-4d4e-8837-39267114169e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "ca2a387d-bccc-4f73-ac52-6677c626fa02");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 25, 7, 11, 23, 995, DateTimeKind.Unspecified).AddTicks(6370), "ee27ab6b-8e2b-49fc-9fa0-1e3fcb0ca64d", new DateTime(2022, 3, 24, 23, 11, 23, 995, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 25, 7, 11, 23, 996, DateTimeKind.Unspecified).AddTicks(1530), "fbaf0f86-04e8-4354-81d8-cac940d7b4e5", new DateTime(2022, 3, 24, 23, 11, 23, 996, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 25, 7, 11, 23, 996, DateTimeKind.Unspecified).AddTicks(1620), "af720759-16ce-4b3b-90a9-a724726bd690", new DateTime(2022, 3, 24, 23, 11, 23, 996, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 4, DateTimeKind.Unspecified).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 4, DateTimeKind.Unspecified).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 4, DateTimeKind.Unspecified).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 7, DateTimeKind.Unspecified).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "c04bd794-dcd4-4ac1-bf99-6e9c73e05957");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "c3a9e64f-81b0-466e-95e3-2b89419ef4ac");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "7f4fab22-8a5c-4742-af62-42ffb5f08833");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "10f34448-9bb1-4b9d-a4e7-a0a9914c0ca6", new DateTime(2022, 3, 25, 7, 11, 24, 1, DateTimeKind.Unspecified).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "1d356f59-9cf0-433b-b2f8-676952b1a3c3", new DateTime(2022, 3, 25, 7, 11, 24, 4, DateTimeKind.Unspecified).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "15988a16-2d90-4d55-b287-6ba248edb08d", new DateTime(2022, 3, 25, 7, 11, 24, 4, DateTimeKind.Unspecified).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 7, 11, 24, 7, DateTimeKind.Unspecified).AddTicks(2490), "26121a01-c6a9-4292-9d53-619a2b00dd15" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 7, 11, 24, 7, DateTimeKind.Unspecified).AddTicks(3320), "1f355b49-200b-48b5-8224-511606aadf4c" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(3020), "d0ecbbb5-fa74-4441-87ec-190a37cbb527" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(3710), "3ad282f3-b22d-4e6f-8806-a8513b4c06f2" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(3740), "54cb02c0-2c04-4827-b4fc-eca909d3a4c1" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(3750), "1db48c32-7e97-4c85-9bca-7aca3701a444" });

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(4750), "0a5e3269-159d-4c8b-ba5b-c7498fe337a4" });

            migrationBuilder.UpdateData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(5920), "47e1f4f6-bd84-4550-bc13-60b02042a186" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "ac71da58-60f2-42c5-9396-77797ee17cd7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "1e55d498-73c2-41e0-92b5-c8b67d377563");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "f9e75471-d405-4ae3-b803-fd4c5f7ebdb5");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "634deee3-cd74-4fc3-bee2-832cbbb21509");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "c499e75e-2f19-4f72-9431-576b1231d056");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "7f9a0bd8-5bbb-4e9d-875b-6383f48aba7a");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "a4f34ed0-253e-43d6-8470-ae59063a0500");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "31f7d1b7-f524-465a-bdf1-b0942f04f5fe");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "75be0327-e63f-466b-8a40-6200f5ce948f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "a9b89e03-b28b-425e-9640-4ea0b29aa51c");
        }
    }
}
