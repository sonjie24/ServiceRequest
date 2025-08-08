using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class addRiderTrips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityDate",
                table: "RiderActivities");

            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "RiderActivities",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RiderTripsLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    BookingId = table.Column<string>(nullable: true),
                    BookingDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    RiderGUID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiderTripsLogs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 55, 13, 664, DateTimeKind.Unspecified).AddTicks(1110), "f4503944-d4f5-4f46-b120-3498a3ede427", new DateTime(2022, 3, 24, 12, 55, 13, 664, DateTimeKind.Utc).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 55, 13, 664, DateTimeKind.Unspecified).AddTicks(7050), "4c01a41d-dc7b-48d9-960d-3f9945d73fd4", new DateTime(2022, 3, 24, 12, 55, 13, 664, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 55, 13, 664, DateTimeKind.Unspecified).AddTicks(7190), "cc7ff73b-2633-4047-b5a4-547c1e4f9dff", new DateTime(2022, 3, 24, 12, 55, 13, 664, DateTimeKind.Utc).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 55, 13, 692, DateTimeKind.Unspecified).AddTicks(5090), "f2de4642-821f-446f-9773-2d0142c9ab67" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 694, DateTimeKind.Unspecified).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 694, DateTimeKind.Unspecified).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 694, DateTimeKind.Unspecified).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 694, DateTimeKind.Unspecified).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 694, DateTimeKind.Unspecified).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 694, DateTimeKind.Unspecified).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 694, DateTimeKind.Unspecified).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 694, DateTimeKind.Unspecified).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 694, DateTimeKind.Unspecified).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 694, DateTimeKind.Unspecified).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 694, DateTimeKind.Unspecified).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 694, DateTimeKind.Unspecified).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 694, DateTimeKind.Unspecified).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 681, DateTimeKind.Unspecified).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 681, DateTimeKind.Unspecified).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 681, DateTimeKind.Unspecified).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 687, DateTimeKind.Unspecified).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 688, DateTimeKind.Unspecified).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 688, DateTimeKind.Unspecified).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 688, DateTimeKind.Unspecified).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 688, DateTimeKind.Unspecified).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 688, DateTimeKind.Unspecified).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 688, DateTimeKind.Unspecified).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 688, DateTimeKind.Unspecified).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 688, DateTimeKind.Unspecified).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 688, DateTimeKind.Unspecified).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 688, DateTimeKind.Unspecified).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 688, DateTimeKind.Unspecified).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 688, DateTimeKind.Unspecified).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 24, 20, 55, 13, 688, DateTimeKind.Unspecified).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "0ee66da9-497c-4f04-824d-e630cee796df");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "fc5bcda6-9e50-4674-8c9a-09911a9ddc8f");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "c02ac06a-0e61-42d2-9d7a-30a7ccdbf862");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "036d0e0c-0e3a-4a31-8466-21870ec56446", new DateTime(2022, 3, 24, 20, 55, 13, 675, DateTimeKind.Unspecified).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "9dca077f-451e-425f-9734-817bb6cbdf13", new DateTime(2022, 3, 24, 20, 55, 13, 681, DateTimeKind.Unspecified).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "db518bc6-7c88-4524-8d5f-8c0b5ee8a757", new DateTime(2022, 3, 24, 20, 55, 13, 681, DateTimeKind.Unspecified).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 55, 13, 687, DateTimeKind.Unspecified).AddTicks(2680), "37ad4c2e-5426-493f-b8a8-314d8fb1b21e" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 55, 13, 687, DateTimeKind.Unspecified).AddTicks(4050), "73075628-8d99-418d-b321-82450b2859f4" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 55, 13, 689, DateTimeKind.Unspecified).AddTicks(7050), "0cff7cd9-1309-4ad8-9ea3-53c9a0397c5e" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 55, 13, 689, DateTimeKind.Unspecified).AddTicks(8190), "e68c5df8-788c-40ac-a90a-1c962c53becb" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 55, 13, 689, DateTimeKind.Unspecified).AddTicks(8230), "4ba7ff43-638c-4324-ad08-56c4a1509e56" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 55, 13, 689, DateTimeKind.Unspecified).AddTicks(8240), "68569ca2-4f47-4a28-aa6b-35da587d11cb" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "e7c9049e-43ec-4b57-aa49-bb234935a0fe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "cefd3981-82e8-4a06-bc48-de05d11f60f3");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "75f60b82-89c9-4dc5-ab9d-c0020c1c886d");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "91213fe2-6ebd-458b-a3f4-d2a77b40bc06");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "c9d3c843-8ffc-4460-88e0-0aefd045a0f6");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "d16a7fd9-170d-4e5d-9965-eeb6cb692f5e");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "761a2b7c-7269-4ce1-bad9-f23139e23454");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "847851ac-ad63-4ead-89d0-6efdbd3867f4");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "e8478346-c7f1-40ae-8ddd-af4c5ec30ae1");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "e3b20cdb-8092-4b2a-8386-dcbf1ae56297");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RiderTripsLogs");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "RiderActivities");

            migrationBuilder.AddColumn<DateTime>(
                name: "ActivityDate",
                table: "RiderActivities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 419, DateTimeKind.Unspecified).AddTicks(770), "585dfd02-5745-473b-9e24-4d0d6de489ba", new DateTime(2022, 3, 20, 13, 15, 39, 419, DateTimeKind.Utc).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 419, DateTimeKind.Unspecified).AddTicks(4880), "1e4c0ceb-a76b-411c-a49c-b858cc268ebd", new DateTime(2022, 3, 20, 13, 15, 39, 419, DateTimeKind.Utc).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 419, DateTimeKind.Unspecified).AddTicks(4970), "527e1371-18a6-46bb-b7a9-9b2e6caab2a6", new DateTime(2022, 3, 20, 13, 15, 39, 419, DateTimeKind.Utc).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(3200), "12a43f20-6831-46fd-9cc8-f23dbdfc4953" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 432, DateTimeKind.Unspecified).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 427, DateTimeKind.Unspecified).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 427, DateTimeKind.Unspecified).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 427, DateTimeKind.Unspecified).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 430, DateTimeKind.Unspecified).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "ea148047-c2e1-490e-847c-9983f2cd3a3f");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "7ae7db62-e7e8-4b54-9da3-b8d18d782bcd");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "8b1accea-c8b2-464e-9b7c-106762e5fb41");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "e0d13747-1494-49ff-935b-3916ee1bae00", new DateTime(2022, 3, 20, 21, 15, 39, 424, DateTimeKind.Unspecified).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "ba0ec5ba-9515-4bd1-b7e4-51a5459e737d", new DateTime(2022, 3, 20, 21, 15, 39, 427, DateTimeKind.Unspecified).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "e635f762-dd0a-4ae1-be2f-537a446cb078", new DateTime(2022, 3, 20, 21, 15, 39, 427, DateTimeKind.Unspecified).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 430, DateTimeKind.Unspecified).AddTicks(4840), "d3fd7d3f-d0e4-48de-b041-29c6ae19f149" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 430, DateTimeKind.Unspecified).AddTicks(5510), "540aff7c-7401-493b-8c07-495ed0c8fb75" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(5470), "77d7e460-6c95-42cf-a5d7-bea15dab1602" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(6040), "55d9f7ca-2cbb-456c-a406-b1a29708799d" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(6070), "e2841798-f387-4228-9538-a34a7855dc58" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 20, 21, 15, 39, 431, DateTimeKind.Unspecified).AddTicks(6080), "04c81622-7e68-4d39-97b9-40573fbc211f" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "dd536349-2421-4841-8a1e-ace60e9a5d92");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "56585d2c-7c3e-4dd6-82f6-b820abaf80af");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "73fac67f-ba65-4cba-a7e2-7d082d155323");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "a800fae1-151a-4c43-b47e-c4adf1fa3371");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "bee27098-776a-4c84-8b09-4845ed61436a");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "4425d10c-3e1b-46d6-9871-3ab8e3df0ce8");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "7115c6e3-05d5-45c7-b183-d2f48479da96");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "0da92947-c49a-488f-a6e3-1178fdb08d0c");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "3a35717c-cb0e-454f-89fa-35fc1a1e6a75");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "9a947b1a-9bf4-43a6-8597-4c6534098973");
        }
    }
}
