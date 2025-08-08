using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class consumerAddOrderCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderCount",
                table: "Account_Consumer",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderCount",
                table: "Account_Consumer");

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 22, DateTimeKind.Unspecified).AddTicks(4137), "1617a57e-c70f-414e-a0f5-ba08b952ef0f", new DateTime(2022, 2, 13, 14, 5, 40, 23, DateTimeKind.Utc).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 23, DateTimeKind.Unspecified).AddTicks(9468), "6f9f1182-8747-4b49-ac20-29b1d92d47bf", new DateTime(2022, 2, 13, 14, 5, 40, 23, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 23, DateTimeKind.Unspecified).AddTicks(9732), "0eff1752-d225-40d5-b614-c5728d8ac2f2", new DateTime(2022, 2, 13, 14, 5, 40, 23, DateTimeKind.Utc).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(1731), "0ebf087d-cdb6-4ec5-bcd3-5c3fb6daf1f6" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 173, DateTimeKind.Unspecified).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 164, DateTimeKind.Unspecified).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 165, DateTimeKind.Unspecified).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 165, DateTimeKind.Unspecified).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 2, 13, 22, 5, 40, 170, DateTimeKind.Unspecified).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "29b291d3-27bb-4724-8a97-d92768bafef1");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "dfdb9e6d-6455-437f-a2e2-c2ee649eb385");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "146f0492-5a79-4512-a4af-189bd3e20b86");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "8c26a4f1-9a40-4035-bebe-b577b8e1c74e", new DateTime(2022, 2, 13, 22, 5, 40, 32, DateTimeKind.Unspecified).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "f3b4e651-b486-4298-b1fa-3bbe07c260ce", new DateTime(2022, 2, 13, 22, 5, 40, 164, DateTimeKind.Unspecified).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "5e7e35b8-758e-4133-8017-a357d87ebd0e", new DateTime(2022, 2, 13, 22, 5, 40, 164, DateTimeKind.Unspecified).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 169, DateTimeKind.Unspecified).AddTicks(7453), "79f24d18-deb3-4505-a475-da071122cc16" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 169, DateTimeKind.Unspecified).AddTicks(9062), "82c21992-e9d0-4ee3-8245-68e071cbb18b" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 171, DateTimeKind.Unspecified).AddTicks(2985), "2119087e-305e-4eb2-bac9-753bb1876790" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 171, DateTimeKind.Unspecified).AddTicks(4141), "26b60129-0189-4b9c-9a18-ee3facaf45e7" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 171, DateTimeKind.Unspecified).AddTicks(4191), "b5a031bc-8c1a-40aa-9c88-0911144c148f" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 2, 13, 22, 5, 40, 171, DateTimeKind.Unspecified).AddTicks(4200), "c5f79202-a130-407f-827a-0ce711733213" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "42a5e8b5-b977-4f80-8c22-42b3739b60d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "8044ab00-6ac8-480b-915b-73aab2823b28");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "7911f2d7-c982-4edf-91b4-a9264b09234f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "20b0d9a8-94be-4144-81e3-e4efaa7d1307");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "e3c6dedd-74fc-4088-92cb-3b1439c7305e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "45d1e15d-26e7-4ea7-aa88-e53dac7ebf4c");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "59f6119c-0689-4388-9aac-074f964b43b5");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "2f7202a1-0277-4689-ab3b-22cdb3972ed3");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "a2338f2b-7f61-470e-b53b-87a62694b47d");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "3ceb2d16-881f-4f4f-a615-cda37e973ee3");
        }
    }
}
