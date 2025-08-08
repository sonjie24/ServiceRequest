using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class updateRiderActivityLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "activity",
                table: "RiderActivities",
                newName: "Activity");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeLog",
                table: "RiderActivities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                columns: new[] { "DateCreated", "GUID" },
                values: new object[] { new DateTime(2022, 3, 25, 7, 11, 24, 9, DateTimeKind.Unspecified).AddTicks(4230), "d6f05409-8c15-4490-995f-af7938bbe670" });

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

            migrationBuilder.InsertData(
                table: "RiderRequirements",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DeletedBy", "DocumentName", "GUID", "ImagePath", "ModifiedBy", "RiderId" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(5920), null, null, null, "Drivers License(Back)", "47e1f4f6-bd84-4550-bc13-60b02042a186", "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1635517246/passafood/eog3og3lgvrsxd5ooaiy.png", null, "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF1" },
                    { 1, null, new DateTime(2022, 3, 25, 7, 11, 24, 8, DateTimeKind.Unspecified).AddTicks(4750), null, null, null, "Drivers License(Front)", "0a5e3269-159d-4c8b-ba5b-c7498fe337a4", "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1635517246/passafood/eog3og3lgvrsxd5ooaiy.png", null, "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF1" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RiderRequirements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "DateTimeLog",
                table: "RiderActivities");

            migrationBuilder.RenameColumn(
                name: "Activity",
                table: "RiderActivities",
                newName: "activity");

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
    }
}
