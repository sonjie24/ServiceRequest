using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class addOSVersioning1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppOsMonitorings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    DeviceType = table.Column<string>(nullable: true),
                    AppVersion = table.Column<string>(nullable: true),
                    AppType = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOsMonitorings", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppOsMonitorings");

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
    }
}
