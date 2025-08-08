using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class AddmerhantRequirements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MerchantRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    MerchantId = table.Column<string>(nullable: true),
                    DocumentName = table.Column<string>(maxLength: 100, nullable: true),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantRequirements", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MerchantRequirements");

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 27, 48, 647, DateTimeKind.Unspecified).AddTicks(209), "b3763675-fd61-47ce-bbae-d10277ec3658", new DateTime(2022, 2, 13, 14, 27, 48, 647, DateTimeKind.Utc).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 27, 48, 647, DateTimeKind.Unspecified).AddTicks(8690), "2ae7ed4b-1245-4c16-b833-a118c1cdfde5", new DateTime(2022, 2, 13, 14, 27, 48, 647, DateTimeKind.Utc).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 27, 48, 647, DateTimeKind.Unspecified).AddTicks(9132), "016dea05-bf29-4de2-bf26-2b4d0c5db1c9", new DateTime(2022, 2, 13, 14, 27, 48, 647, DateTimeKind.Utc).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 27, 48, 735, DateTimeKind.Unspecified).AddTicks(7605), "931a938e-9bac-499d-97e4-a72ebf96373f" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 736, DateTimeKind.Unspecified).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 736, DateTimeKind.Unspecified).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 736, DateTimeKind.Unspecified).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 736, DateTimeKind.Unspecified).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 736, DateTimeKind.Unspecified).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 736, DateTimeKind.Unspecified).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 736, DateTimeKind.Unspecified).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 736, DateTimeKind.Unspecified).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 736, DateTimeKind.Unspecified).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 736, DateTimeKind.Unspecified).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 736, DateTimeKind.Unspecified).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 736, DateTimeKind.Unspecified).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 736, DateTimeKind.Unspecified).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 683, DateTimeKind.Unspecified).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 684, DateTimeKind.Unspecified).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 684, DateTimeKind.Unspecified).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 718, DateTimeKind.Unspecified).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 720, DateTimeKind.Unspecified).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 720, DateTimeKind.Unspecified).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 720, DateTimeKind.Unspecified).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 720, DateTimeKind.Unspecified).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 720, DateTimeKind.Unspecified).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 720, DateTimeKind.Unspecified).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 720, DateTimeKind.Unspecified).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 720, DateTimeKind.Unspecified).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 720, DateTimeKind.Unspecified).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 720, DateTimeKind.Unspecified).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 720, DateTimeKind.Unspecified).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 720, DateTimeKind.Unspecified).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 27, 48, 720, DateTimeKind.Unspecified).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "44880023-a6b2-4354-9a3a-2cf87efcada3");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "f9508db7-3c2d-4849-9869-4883e07c071a");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "e785f474-76da-4c7b-994b-76ad162b8752");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "2877a1a9-98e9-4e41-9bad-b3e3d1069052", new DateTime(2022, 2, 13, 22, 27, 48, 665, DateTimeKind.Unspecified).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "02768510-9b29-4964-8488-8d28337e2612", new DateTime(2022, 2, 13, 22, 27, 48, 683, DateTimeKind.Unspecified).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "7af689a1-3970-4850-b991-6ccff2205476", new DateTime(2022, 2, 13, 22, 27, 48, 683, DateTimeKind.Unspecified).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 27, 48, 717, DateTimeKind.Unspecified).AddTicks(841), "0c12017a-bf04-4c7b-a8ec-4de8926e4846" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 27, 48, 717, DateTimeKind.Unspecified).AddTicks(5319), "2e21ba59-7b27-4caa-b3e5-82095ded0c58" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 27, 48, 721, DateTimeKind.Unspecified).AddTicks(3765), "e593ff88-9f5d-4ad4-87ab-19f21d488655" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 27, 48, 721, DateTimeKind.Unspecified).AddTicks(5352), "1031bdb6-6613-4438-995e-c6eb353f720e" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 27, 48, 721, DateTimeKind.Unspecified).AddTicks(5755), "f4333d25-6468-4f6e-b879-c47e44c3de83" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 27, 48, 721, DateTimeKind.Unspecified).AddTicks(5771), "46a8137f-d88a-467d-9eb7-a3ab2af7b3fa" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "06be0b48-516b-48dc-8795-65305fcc1d2b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "7fb6ee05-e1e6-4597-9b0a-cf7bfd083b2a");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "8f56e23a-78cd-49ec-81dc-769c172d7f70");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "5e2ce6f1-0b26-486a-8e68-270d349f80f6");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "78e59568-9fe5-41d5-b1ab-e5d004a1793e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "e6f978d8-0692-409a-b4c5-054a1c346b21");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "cd95cddd-f5da-43bd-9bd4-b34181cf30f1");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "aee56968-cd5a-4654-b8f2-2e51fa49f09e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "d6ae373b-1fec-418e-ad65-bcbba47ef0e0");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "df215957-71ed-4d19-9467-be90f534fce1");
        }
    }
}
