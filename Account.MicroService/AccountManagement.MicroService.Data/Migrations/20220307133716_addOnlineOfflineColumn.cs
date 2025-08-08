using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class addOnlineOfflineColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RiderOnlineOffline",
                table: "Account_Riders",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RiderOnlineOffline",
                table: "Account_Riders");

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 14, 22, 279, DateTimeKind.Unspecified).AddTicks(6270), "5a5a653d-a5b4-4fd9-b931-325ad45f20fe", new DateTime(2022, 3, 7, 12, 14, 22, 279, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 14, 22, 280, DateTimeKind.Unspecified).AddTicks(1580), "7973a582-3764-488f-b590-39147fe01164", new DateTime(2022, 3, 7, 12, 14, 22, 280, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 14, 22, 280, DateTimeKind.Unspecified).AddTicks(1700), "f36dd3dd-f255-419d-aaaf-425a6ecf5c11", new DateTime(2022, 3, 7, 12, 14, 22, 280, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 14, 22, 298, DateTimeKind.Unspecified).AddTicks(690), "1d59b883-32f5-45ba-8941-8c46f5541a31" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 298, DateTimeKind.Unspecified).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 298, DateTimeKind.Unspecified).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 298, DateTimeKind.Unspecified).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 298, DateTimeKind.Unspecified).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 298, DateTimeKind.Unspecified).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 298, DateTimeKind.Unspecified).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 298, DateTimeKind.Unspecified).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 298, DateTimeKind.Unspecified).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 298, DateTimeKind.Unspecified).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 298, DateTimeKind.Unspecified).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 298, DateTimeKind.Unspecified).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 298, DateTimeKind.Unspecified).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 298, DateTimeKind.Unspecified).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 291, DateTimeKind.Unspecified).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 291, DateTimeKind.Unspecified).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 291, DateTimeKind.Unspecified).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 295, DateTimeKind.Unspecified).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "d8407cf4-3b43-416c-91ae-b8bcaafb27ce");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "fba7e532-c644-4489-a268-8a3ff64d0ecd");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "a5784862-4ed9-42af-bb97-a7f608240164");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "5d67c7ff-454b-4f51-ac25-a5cb2840700e", new DateTime(2022, 3, 7, 20, 14, 22, 286, DateTimeKind.Unspecified).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "bda1cc15-5aee-4161-bfc6-c9787acf6dac", new DateTime(2022, 3, 7, 20, 14, 22, 291, DateTimeKind.Unspecified).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "e7aeafb1-50e2-42ed-b996-8314d7bb6ad3", new DateTime(2022, 3, 7, 20, 14, 22, 291, DateTimeKind.Unspecified).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 14, 22, 295, DateTimeKind.Unspecified).AddTicks(3150), "319e950c-d865-41dd-ad7d-5cdd9ae3e8fe" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 14, 22, 295, DateTimeKind.Unspecified).AddTicks(4260), "3bb40e2c-cb5e-40d0-a6a3-e89b9c6c85cb" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(7810), "fa64d553-33f1-4538-b9fd-2c1db0dbed48" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(8590), "8d4fa98b-60a2-4800-ad83-5fbf10c95d5f" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(8630), "059a2533-d00c-4b29-af72-ba567145d26e" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 7, 20, 14, 22, 296, DateTimeKind.Unspecified).AddTicks(8640), "35809961-20f0-4bf0-bb83-a96cc948ffe2" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "0155b2c6-a47a-4476-b72f-05b5a94356c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "b0dab1a0-8bba-4ef0-9ed4-c26796f2f65e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "421fbf11-9c3e-43a8-91f9-a4b04f369706");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "2780c647-9afb-4ffa-a21b-acaa193cb27d");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "d1552a22-5d74-4060-942f-eca9ea0f4f16");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "849122fe-c778-44e0-a96f-b9027bb19cfd");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "43c45f20-a381-4a6e-b9b9-15a5310e441f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "370a56ef-ce39-44cd-9aef-a3a64bbe894d");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "ee5b490e-cd87-4556-acac-f73a1f7ccdda");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "652992e9-38e3-4a7f-ba80-2a5e7d31310d");
        }
    }
}
