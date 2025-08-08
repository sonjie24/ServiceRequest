using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class adminrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 51, 5, 445, DateTimeKind.Utc).AddTicks(7463), "e9614ba3-2d1b-4beb-899a-5f388e992bfe", new DateTime(2022, 1, 20, 5, 51, 5, 445, DateTimeKind.Utc).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 51, 5, 446, DateTimeKind.Utc).AddTicks(888), "71fd712c-d5e1-4bea-ae31-26f67bbe5af7", new DateTime(2022, 1, 20, 5, 51, 5, 446, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 51, 5, 446, DateTimeKind.Utc).AddTicks(1061), "58eb267b-5aac-4edc-b653-bf07afa47526", new DateTime(2022, 1, 20, 5, 51, 5, 446, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 51, 5, 471, DateTimeKind.Utc).AddTicks(4149), "ed35136d-dd09-457f-a63f-e18911f8c994" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 471, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 471, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 471, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 471, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 471, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 471, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 471, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 471, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 471, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 471, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 471, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 471, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 471, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 464, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 464, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 464, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "28606023-e22e-4a74-9900-eb9d9d2f6cfe");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "11e2722b-9cc4-45ef-b0a5-d5d8ff335365");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "5cab197c-b6af-4c5b-a262-df49d9a56546");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "84854c55-32b8-465f-ab57-b4bc81e1d7d7", new DateTime(2022, 1, 20, 5, 51, 5, 458, DateTimeKind.Utc).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "c534afa5-31ea-4486-a8e0-ecffb6021dcf", new DateTime(2022, 1, 20, 5, 51, 5, 464, DateTimeKind.Utc).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "b1b46fcb-ede3-4100-a32b-21b02e3e946b", new DateTime(2022, 1, 20, 5, 51, 5, 464, DateTimeKind.Utc).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(221), "9a664adf-57cb-4dac-af7c-4d0f273e559e" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 51, 5, 469, DateTimeKind.Utc).AddTicks(1261), "828318c2-6aec-4e2c-ae75-0d8206afc79f" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 51, 5, 470, DateTimeKind.Utc).AddTicks(2647), "d5589294-c9bb-4baf-8cf8-c7d6f2ff6ff6" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 51, 5, 470, DateTimeKind.Utc).AddTicks(3286), "71a7b795-fcd9-4faa-96dc-3195bfbf0235" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 51, 5, 470, DateTimeKind.Utc).AddTicks(3416), "48bd2e48-5464-4502-b1fb-05855bcb2ee1" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 20, 5, 51, 5, 470, DateTimeKind.Utc).AddTicks(3425), "94182294-1e7a-47a4-ac16-9905c00fb79c" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "aa6924bb-649c-48d8-b836-7b94908e3824");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "e90bf35c-6651-46d3-a01e-69886179b0a9");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "2dec9ec3-53aa-4207-8834-a82e54a689a0");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "b372873c-dc3c-4245-a2b8-dccb74d83074");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "81f219eb-d199-48a9-9308-0fab6cca564d");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "9891cc9a-e247-4672-b5ed-10812ffbd2ad");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "2802e6ec-bdc7-43ed-bda4-a81b64a185a7");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "0a0bbab0-d4eb-438c-965e-df1431d4440d");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "91fc551c-9f5f-47e5-9cad-3c90f5c9e29f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "340fd076-d090-4454-814c-70c40746e04e");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 1, 17, 21, 6, 34, 392, DateTimeKind.Utc).AddTicks(7760), "a1fb99fa-f92a-4730-8855-d1348e9de125", new DateTime(2022, 1, 17, 21, 6, 34, 392, DateTimeKind.Utc).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 1, 17, 21, 6, 34, 393, DateTimeKind.Utc).AddTicks(570), "e22906d4-8f06-4ea3-9b10-81a56314fe8d", new DateTime(2022, 1, 17, 21, 6, 34, 393, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 1, 17, 21, 6, 34, 393, DateTimeKind.Utc).AddTicks(630), "2ba2bb52-f122-42c9-9da3-ccc85602829a", new DateTime(2022, 1, 17, 21, 6, 34, 393, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 17, 21, 6, 34, 408, DateTimeKind.Utc).AddTicks(8550), "9324ea59-3a82-41fc-9556-ae2fd2f55c2d" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 409, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 409, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 409, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 409, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 409, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 409, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 409, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 409, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 409, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 409, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 409, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 409, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 409, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 402, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 402, DateTimeKind.Utc).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 402, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "87a9fa85-01e8-4606-b78f-b314ae4686c9");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "83b50d57-5283-4bfe-8334-0b75775a7a35");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "43f440c4-e971-4ebd-9513-b3bd4622aa27");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "d7c1eae9-e6c8-44e4-887b-34caf6af0908", new DateTime(2022, 1, 17, 21, 6, 34, 399, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "dc8ecaaf-4737-465d-887a-a567300bc7a7", new DateTime(2022, 1, 17, 21, 6, 34, 402, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "eacd31a1-b355-418d-8c26-389a97517e50", new DateTime(2022, 1, 17, 21, 6, 34, 402, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(1550), "ba46be49-9ed1-447f-8643-74e078391d10" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 17, 21, 6, 34, 406, DateTimeKind.Utc).AddTicks(2320), "7e766be7-fd15-40e3-9674-576808dce82a" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 17, 21, 6, 34, 407, DateTimeKind.Utc).AddTicks(4440), "7b00c572-388e-4de7-bdb4-b52c7ec253f0" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 17, 21, 6, 34, 407, DateTimeKind.Utc).AddTicks(5100), "dc35122e-3571-4de7-bf74-e88c16ae894b" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 17, 21, 6, 34, 407, DateTimeKind.Utc).AddTicks(5120), "fbd4b149-0e55-4350-8867-47a141c7cc57" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 17, 21, 6, 34, 407, DateTimeKind.Utc).AddTicks(5130), "1c3a49e3-4b60-49df-97b5-4670da406f1d" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "162b4915-f6ac-4c94-8df5-4ebf7d703cff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "3d8142f3-b23e-4a65-9cae-3eb17ae4b0b7");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "26f24f9d-776f-413a-aabc-b40df3e57ba3");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "0be2c109-6749-4459-a254-a23ad35faa60");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "76ebd12f-0b38-4d2e-a221-0d794dd223b2");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "be69670f-3786-4725-9019-907e2535eafc");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "263ed187-dd24-449a-a468-6dd0b51a9d1d");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "eeb86610-3839-4fd0-b6e3-5068633db116");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "0ee7cef2-a089-489c-9fe9-0cfd9f3c07d0");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "f45eb983-545d-4980-a4d5-b627e7de032b");
        }
    }
}
