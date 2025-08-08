using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class addOSVersioning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 11, 50, 388, DateTimeKind.Unspecified).AddTicks(2990), "a9f4d58d-4b56-40dd-beea-e32d11203ff7", new DateTime(2022, 3, 7, 12, 11, 50, 388, DateTimeKind.Utc).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 11, 50, 388, DateTimeKind.Unspecified).AddTicks(6910), "14980eb3-9c92-4f57-ab08-434ef7aab94d", new DateTime(2022, 3, 7, 12, 11, 50, 388, DateTimeKind.Utc).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 11, 50, 388, DateTimeKind.Unspecified).AddTicks(6990), "5426ffe0-7668-4ed0-8bc8-9a654999af39", new DateTime(2022, 3, 7, 12, 11, 50, 388, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 11, 50, 403, DateTimeKind.Unspecified).AddTicks(2810), "7c1bb080-b3d1-4d94-917d-bd824d069e92" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 403, DateTimeKind.Unspecified).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 403, DateTimeKind.Unspecified).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 403, DateTimeKind.Unspecified).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 403, DateTimeKind.Unspecified).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 403, DateTimeKind.Unspecified).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 403, DateTimeKind.Unspecified).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 403, DateTimeKind.Unspecified).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 403, DateTimeKind.Unspecified).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 403, DateTimeKind.Unspecified).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 403, DateTimeKind.Unspecified).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 403, DateTimeKind.Unspecified).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 403, DateTimeKind.Unspecified).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 403, DateTimeKind.Unspecified).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 397, DateTimeKind.Unspecified).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 397, DateTimeKind.Unspecified).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 397, DateTimeKind.Unspecified).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 401, DateTimeKind.Unspecified).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 401, DateTimeKind.Unspecified).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 401, DateTimeKind.Unspecified).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 401, DateTimeKind.Unspecified).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 401, DateTimeKind.Unspecified).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 401, DateTimeKind.Unspecified).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 401, DateTimeKind.Unspecified).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 401, DateTimeKind.Unspecified).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 401, DateTimeKind.Unspecified).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 401, DateTimeKind.Unspecified).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 401, DateTimeKind.Unspecified).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 401, DateTimeKind.Unspecified).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 401, DateTimeKind.Unspecified).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 11, 50, 401, DateTimeKind.Unspecified).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "3d78b171-06d9-4196-96ff-8ae938f56d82");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "d27494fd-cc7f-4536-bad8-6d1e2c3f5678");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "c8805130-3b9b-4839-9b02-33315f2c78b2");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "925344ad-1506-4110-95b1-4c156438b839", new DateTime(2022, 3, 7, 20, 11, 50, 394, DateTimeKind.Unspecified).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "1c86eeeb-1c01-4b6f-93f3-e824b8e3f016", new DateTime(2022, 3, 7, 20, 11, 50, 397, DateTimeKind.Unspecified).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "fa1d0352-c315-4752-8650-fc7e825467f7", new DateTime(2022, 3, 7, 20, 11, 50, 397, DateTimeKind.Unspecified).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 11, 50, 400, DateTimeKind.Unspecified).AddTicks(6470), "4fcc1ef4-f6c6-4789-8112-22a7d3fa84cd" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 11, 50, 400, DateTimeKind.Unspecified).AddTicks(7150), "75cd56e2-4545-4748-9105-0d5bd9c5ac40" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 11, 50, 402, DateTimeKind.Unspecified).AddTicks(460), "145c67c6-4bd7-4d11-80f2-884f98245abd" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 11, 50, 402, DateTimeKind.Unspecified).AddTicks(1130), "7dbf8c13-1517-4b1c-8cba-085e416599f2" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 11, 50, 402, DateTimeKind.Unspecified).AddTicks(1160), "32fc47b4-9455-4015-88c9-21eeb0bb9044" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 11, 50, 402, DateTimeKind.Unspecified).AddTicks(1170), "ccb53cf4-3d68-4656-b7ec-2fd3bab05a31" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "59de7b34-98f5-4830-b8ea-199c5ed7a653");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "092c7304-e70d-48a0-a094-855ce3290277");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "9ada88a8-f1c0-48d0-81aa-c4a498cddc35");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "4b0e12d3-4766-4302-a89e-15593f5f145d");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "7c681a77-4fb9-4cdc-ae63-e42a200c821f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "e7e6ed2c-79d7-44f3-bbb9-17cb6862f419");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "51ba1a1f-4b2c-4e02-8817-9cd7d1ca90f2");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "1f86fbe4-ceec-4259-8859-adf513938853");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "08cb6e91-1670-4c14-953e-30938b662725");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "5610638b-8b71-4659-ace8-83c363acfd4f");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 760, DateTimeKind.Unspecified).AddTicks(8090), "43ee4fa2-43a8-4476-9006-8d91fb0b672d", new DateTime(2022, 3, 2, 12, 35, 37, 760, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 761, DateTimeKind.Unspecified).AddTicks(2510), "9356e344-46cc-47b5-9f47-82328ea071b4", new DateTime(2022, 3, 2, 12, 35, 37, 761, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 761, DateTimeKind.Unspecified).AddTicks(2610), "13417f60-8ba6-4a3f-8bbd-87e92aadd37d", new DateTime(2022, 3, 2, 12, 35, 37, 761, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 775, DateTimeKind.Unspecified).AddTicks(8770), "ea974d36-85d5-4bf8-89fa-5c45aea14166" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 776, DateTimeKind.Unspecified).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 770, DateTimeKind.Unspecified).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 770, DateTimeKind.Unspecified).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 770, DateTimeKind.Unspecified).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 773, DateTimeKind.Unspecified).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "35f7ebfd-dd20-4b6a-92bf-707745e291f1");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "e492c558-e361-445d-9d66-66cc9d01009e");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "8f3def3e-d577-4d45-9f4a-58fa22bce105");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "d01fd651-2128-4e09-bc19-2b5d8f68d477", new DateTime(2022, 3, 2, 20, 35, 37, 766, DateTimeKind.Unspecified).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "edff132b-381d-4116-9d53-5d2ec3eb9939", new DateTime(2022, 3, 2, 20, 35, 37, 770, DateTimeKind.Unspecified).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "c5fd7e81-06a2-4623-a111-26a4e2e73806", new DateTime(2022, 3, 2, 20, 35, 37, 770, DateTimeKind.Unspecified).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 773, DateTimeKind.Unspecified).AddTicks(4570), "3ee4802a-4068-48c9-b019-d71f869be77b" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 773, DateTimeKind.Unspecified).AddTicks(5330), "e019465e-64ba-4b54-854a-e2c964ea983a" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 774, DateTimeKind.Unspecified).AddTicks(9420), "e098604a-8c39-421c-a472-0645cecf00f7" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 775, DateTimeKind.Unspecified).AddTicks(280), "7566299d-72ac-45cc-9596-93e98238d4a2" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 775, DateTimeKind.Unspecified).AddTicks(320), "2abb3b09-f536-46ec-975a-27d326b981ee" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 2, 20, 35, 37, 775, DateTimeKind.Unspecified).AddTicks(320), "f0122092-6a3c-405a-a4a2-b27fe885e184" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "ccab168a-b855-4b1f-8797-318ef766684c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "32d8a60c-622e-44fd-abdc-89dbd11bb64d");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "47e1d97a-c5db-4dff-ac1d-fd8a268e5f35");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "1b512bfb-29f6-42fe-8926-c62efb5d83d6");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "a8bfda65-d4df-4d51-91d8-5797fb0ae270");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "7b4c80ba-c976-4e60-bbde-e4ac6374b7e9");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "93690756-020c-4baf-84bc-a3d162b3bdef");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "1cdc5fff-35a7-41e5-9588-95b1c135e2e0");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "b900b3e7-7804-43cb-b364-9c5e507052be");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "849db180-f2c5-488f-9bf8-fe1bce0af72a");
        }
    }
}
