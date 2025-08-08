using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class addAdminStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminEStaffs",
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
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    JobDescription = table.Column<string>(nullable: true),
                    ContactNo = table.Column<string>(nullable: true),
                    EffectivityDate = table.Column<DateTime>(nullable: false),
                    WithEffectivity = table.Column<bool>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminEStaffs", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminEStaffs");

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 1, 15, 3, 29, 31, 227, DateTimeKind.Utc).AddTicks(2167), "deeceae7-0aa2-4bf6-9fe7-b4c987809604", new DateTime(2022, 1, 15, 3, 29, 31, 227, DateTimeKind.Utc).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 1, 15, 3, 29, 31, 227, DateTimeKind.Utc).AddTicks(3881), "15dcef74-3c48-4ef6-a3ab-ce08438dc084", new DateTime(2022, 1, 15, 3, 29, 31, 227, DateTimeKind.Utc).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Account_Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID", "ValidUntil" },
                values: new object[] { new DateTime(2022, 1, 15, 3, 29, 31, 227, DateTimeKind.Utc).AddTicks(3939), "46c043ff-5dcd-44e3-a32e-5c6b8381e9b5", new DateTime(2022, 1, 15, 3, 29, 31, 227, DateTimeKind.Utc).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(9078), "c3b51b43-5a0c-488a-9a16-88936f832777" });

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Account_Consumer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 233, DateTimeKind.Utc).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 233, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Account_Merchants",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 233, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 235, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Account_Riders",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "766fe8ac-164e-47b8-9eb3-513148c88f8e");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "199fe4b0-361b-4fd6-a5c1-93ff9f0fc50a");

            migrationBuilder.UpdateData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "15ceb3cd-65e9-4cff-bf0e-80450ed1cd5a");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "aeda1003-c339-4de0-bf76-77a70db0fe1d", new DateTime(2022, 1, 15, 3, 29, 31, 231, DateTimeKind.Utc).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "237230ec-1722-4e51-b4de-ac5a5fe4f10a", new DateTime(2022, 1, 15, 3, 29, 31, 233, DateTimeKind.Utc).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BranchGroup", "DateCreated" },
                values: new object[] { "f6fad38d-ef24-4d8b-90dc-a7fc7627a153", new DateTime(2022, 1, 15, 3, 29, 31, 233, DateTimeKind.Utc).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 15, 3, 29, 31, 235, DateTimeKind.Utc).AddTicks(6796), "4b302a43-1342-4101-972b-39e590484de0" });

            migrationBuilder.UpdateData(
                table: "PersonProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 15, 3, 29, 31, 235, DateTimeKind.Utc).AddTicks(7180), "f47e505c-880c-4d0e-97bc-3332b4cdb6b1" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(2826), "7306c58e-e1b5-458d-8377-623761413f5c" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(3170), "7e3121da-50d2-43fb-99b2-c311b44d0bb0" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(3185), "0d92a51a-3d43-4538-9404-f618db66acd9" });

            migrationBuilder.UpdateData(
                table: "RiderActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(3189), "17c1feeb-3c95-4691-b43d-a17c96799ded" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "a14af6e3-9bd4-47a0-89dd-18cf4ecf5c1f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "8310a842-516a-4946-91e4-3ddf2a524dbb");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "GUID",
                value: "2b29a005-abc1-46cc-aadf-a5f82ef87ea8");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "GUID",
                value: "e1e39514-6719-4c83-8e70-8ade4faef97f");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "GUID",
                value: "d402cbb6-4bc2-4235-9e6a-ee0fb4d8ebfe");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "GUID",
                value: "e48a653d-4e69-4f8c-bad6-2d161689c6d6");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "GUID",
                value: "9ac61d05-3b13-475d-b4ca-0ffdfebefc3a");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "GUID",
                value: "402b755d-4641-4239-9378-1af21c6f4f7c");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "GUID",
                value: "146fb086-7306-464b-a33a-f87195c12215");

            migrationBuilder.UpdateData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "GUID",
                value: "91da6c23-2f03-4540-b77c-2b25b27bf99a");
        }
    }
}
