using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class adminroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    RoleName = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminRouteModelRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: true),
                    RouteModelId = table.Column<string>(nullable: true),
                    RoutePath = table.Column<string>(nullable: true),
                    Action = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminRouteModelRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminRouteModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    Module = table.Column<string>(nullable: true),
                    Grouping = table.Column<string>(nullable: true),
                    RouteName = table.Column<string>(nullable: true),
                    RoutePath = table.Column<string>(nullable: true),
                    Action = table.Column<string>(nullable: true),
                    Global = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminRouteModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminUserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminUserRoles", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminRoles");

            migrationBuilder.DropTable(
                name: "AdminRouteModelRoles");

            migrationBuilder.DropTable(
                name: "AdminRouteModels");

            migrationBuilder.DropTable(
                name: "AdminUserRoles");

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
    }
}
