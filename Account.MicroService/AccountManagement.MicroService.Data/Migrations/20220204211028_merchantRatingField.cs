using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class merchantRatingField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ConsumerRating",
                table: "Merchants",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "ConsumerRatingCount",
                table: "Merchants",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "RiderRating",
                table: "Merchants",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "RiderRatingCount",
                table: "Merchants",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConsumerRating",
                table: "Merchants");

            migrationBuilder.DropColumn(
                name: "ConsumerRatingCount",
                table: "Merchants");

            migrationBuilder.DropColumn(
                name: "RiderRating",
                table: "Merchants");

            migrationBuilder.DropColumn(
                name: "RiderRatingCount",
                table: "Merchants");

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 55, 25, 877, DateTimeKind.Utc).AddTicks(7662), "6c66f838-a9b4-4076-b0e3-1ad46fee44c8", new DateTime(2022, 1, 20, 5, 55, 25, 877, DateTimeKind.Utc).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 55, 25, 878, DateTimeKind.Utc).AddTicks(1551), "e76621af-8e06-4466-95d3-12ccde6cbe33", new DateTime(2022, 1, 20, 5, 55, 25, 878, DateTimeKind.Utc).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 55, 25, 878, DateTimeKind.Utc).AddTicks(1727), "3ad9855a-6e5a-4788-a683-036ec654a7c9", new DateTime(2022, 1, 20, 5, 55, 25, 878, DateTimeKind.Utc).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 55, 25, 897, DateTimeKind.Utc).AddTicks(1244), "fdb7a731-ff58-4c81-8cb8-cb1d16955cd9" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 897, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 897, DateTimeKind.Utc).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 897, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 897, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 897, DateTimeKind.Utc).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 897, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 897, DateTimeKind.Utc).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 897, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 897, DateTimeKind.Utc).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 897, DateTimeKind.Utc).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 897, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 897, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 897, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 890, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 890, DateTimeKind.Utc).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 890, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 894, DateTimeKind.Utc).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "cd3fdd32-6b62-4b43-afc1-671a952beb59");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "e943980d-ca89-4a10-9863-e6351ca889d4");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "09f1ccbf-f491-47b7-9e7b-520738781aba");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "1d272762-d07c-4906-a687-9f7dfa3789ee", new DateTime(2022, 1, 20, 5, 55, 25, 885, DateTimeKind.Utc).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "a7e9e21e-aa28-4e67-b250-5ad162d98511", new DateTime(2022, 1, 20, 5, 55, 25, 889, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "732f3bd4-6a8b-4168-89f1-96f9d64c295b", new DateTime(2022, 1, 20, 5, 55, 25, 889, DateTimeKind.Utc).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 55, 25, 894, DateTimeKind.Utc).AddTicks(4116), "19284abb-d6b9-4018-8822-2afd9eca72b0" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 55, 25, 894, DateTimeKind.Utc).AddTicks(5122), "d98422ca-b045-4763-bc35-8a2b7c8e4367" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(6562), "af0d542f-59c6-4faf-9183-6472905ebb5e" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(7331), "08dd681b-1c2c-4077-8648-b4b89306e599" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(7353), "6ecc9f7e-092b-4950-a68a-df4244c77383" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 55, 25, 895, DateTimeKind.Utc).AddTicks(7973), "e3aa8510-0ffd-4e8c-bebb-7b554f5808f9" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "c9d5cb25-a54b-4204-a32a-1c8167675079");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "2d519db8-3fb4-4a32-b9f5-b1761d7d636a");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "6998f082-4df0-42a7-87fd-64976a8a19f0");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "81871a22-0f83-4a0e-be38-84bb0b6ee15e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "32647f56-76f5-43c4-9d59-45f1af3377ef");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "68ec2570-7ca5-4f15-b38a-69823eb9a943");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "830f5763-c3bd-45e3-a7c2-e0519e71b9e6");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "7da1cece-54af-4cff-8044-2d55fc363bef");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "ab888dc6-4108-49c8-9815-52c431591f7e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "a04ae6fc-8a9d-45a8-b75a-bc1aeb9321cb");
        }
    }
}
