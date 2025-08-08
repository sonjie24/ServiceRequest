using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace AccountManagement.Framework.Data.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account_Admin",
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
                    IsAccountConfirmed = table.Column<bool>(nullable: true),
                    Username = table.Column<string>(maxLength: 100, nullable: true),
                    Password = table.Column<string>(maxLength: 100, nullable: true),
                    MobileNumber = table.Column<string>(maxLength: 12, nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    JobPosition = table.Column<string>(maxLength: 100, nullable: true),
                    SetEffectivity = table.Column<bool>(nullable: false),
                    ValidUntil = table.Column<DateTime>(nullable: false),
                    DeliveryStatus = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    UserType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Account_Consumer",
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
                    IsAccountConfirmed = table.Column<bool>(nullable: true),
                    MobileNumber = table.Column<string>(maxLength: 12, nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    Rating = table.Column<double>(nullable: false),
                    RatingCount = table.Column<int>(nullable: false),
                    IsSocial = table.Column<bool>(nullable: false),
                    SocialId = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account_Consumer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MerchantOpeningHours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    MerchantId = table.Column<string>(nullable: true),
                    Day = table.Column<string>(nullable: true),
                    IsOn = table.Column<string>(nullable: true),
                    FromTime = table.Column<string>(nullable: true),
                    ToTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantOpeningHours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Merchants",
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
                    ParentMerchantStoreEntityId = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    BranchGroup = table.Column<string>(nullable: true),
                    Company = table.Column<string>(maxLength: 255, nullable: true),
                    LandMark = table.Column<string>(nullable: true),
                    NoOfEmployees = table.Column<int>(nullable: false),
                    ContactFirstName = table.Column<string>(maxLength: 100, nullable: true),
                    ContactLastName = table.Column<string>(maxLength: 100, nullable: true),
                    ContactNo = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Location = table.Column<Point>(nullable: true),
                    Address1 = table.Column<string>(maxLength: 255, nullable: true),
                    Address2 = table.Column<string>(maxLength: 255, nullable: true),
                    Barangay = table.Column<string>(maxLength: 255, nullable: true),
                    CityMunicipality = table.Column<string>(maxLength: 255, nullable: true),
                    Province = table.Column<string>(maxLength: 255, nullable: true),
                    Region = table.Column<string>(maxLength: 255, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 20, nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Prepaid = table.Column<bool>(nullable: false),
                    AutoAccept = table.Column<bool>(nullable: false),
                    MerchantKmRange = table.Column<double>(nullable: false),
                    RiderKmRange = table.Column<double>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    IsOnline = table.Column<bool>(nullable: false),
                    IsPause = table.Column<bool>(nullable: false),
                    IsClose = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Merchants_Merchants_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Merchants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MerchantStaffs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    MerchantId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ContactNo = table.Column<string>(nullable: true),
                    JobDescription = table.Column<string>(nullable: true),
                    SetEffectivity = table.Column<bool>(nullable: false),
                    EffectivityDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantStaffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MerchantUserTypeEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(nullable: true),
                    RoleName = table.Column<string>(nullable: true),
                    IsSave = table.Column<bool>(nullable: false),
                    IsView = table.Column<bool>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    IsPrint = table.Column<bool>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    MerchantUserId = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantUserTypeEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PasswordAdmins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordAdmins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PasswordMerchants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordMerchants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PasswordRiders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordRiders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokenAdmins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userGuid = table.Column<string>(nullable: true),
                    JwtId = table.Column<string>(maxLength: 100, nullable: true),
                    Token = table.Column<string>(nullable: true),
                    Creation = table.Column<DateTime>(nullable: false),
                    Expirydate = table.Column<DateTime>(nullable: false),
                    Used = table.Column<bool>(nullable: false),
                    Invalidated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokenAdmins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokenConsumers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userGuid = table.Column<string>(nullable: true),
                    JwtId = table.Column<string>(maxLength: 100, nullable: true),
                    Token = table.Column<string>(nullable: true),
                    Creation = table.Column<DateTime>(nullable: false),
                    Expirydate = table.Column<DateTime>(nullable: false),
                    Used = table.Column<bool>(nullable: false),
                    Invalidated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokenConsumers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokenMerchants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userGuid = table.Column<string>(nullable: true),
                    JwtId = table.Column<string>(maxLength: 100, nullable: true),
                    Token = table.Column<string>(nullable: true),
                    Creation = table.Column<DateTime>(nullable: false),
                    Expirydate = table.Column<DateTime>(nullable: false),
                    Used = table.Column<bool>(nullable: false),
                    Invalidated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokenMerchants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokenRiders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userGuid = table.Column<string>(nullable: true),
                    JwtId = table.Column<string>(maxLength: 100, nullable: true),
                    Token = table.Column<string>(nullable: true),
                    Creation = table.Column<DateTime>(nullable: false),
                    Expirydate = table.Column<DateTime>(nullable: false),
                    Used = table.Column<bool>(nullable: false),
                    Invalidated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokenRiders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RiderActivities",
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
                    RiderId = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    activity = table.Column<string>(nullable: true),
                    ActivityDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiderActivities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RiderRequirements",
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
                    RiderId = table.Column<string>(nullable: true),
                    DocumentName = table.Column<string>(maxLength: 100, nullable: true),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiderRequirements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
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
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RouteModelRoles",
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
                    table.PrimaryKey("PK_RouteModelRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RouteModels",
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
                    table.PrimaryKey("PK_RouteModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreCategories_StoreCategories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "StoreCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserLocationLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLocationLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
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
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
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
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsumerFavorites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    ConsumerGuid = table.Column<string>(nullable: true),
                    MerchantGuid = table.Column<string>(nullable: true),
                    ConsumerAccountEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumerFavorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsumerFavorites_Account_Consumer_ConsumerAccountEntityId",
                        column: x => x.ConsumerAccountEntityId,
                        principalTable: "Account_Consumer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddressBook",
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
                    ConsumerId = table.Column<int>(nullable: false),
                    isDefault = table.Column<bool>(nullable: false),
                    Type = table.Column<string>(maxLength: 15, nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    AddressDetail = table.Column<string>(nullable: true),
                    RiderInstruction = table.Column<string>(nullable: true),
                    Location = table.Column<Point>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddressBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAddressBook_Account_Consumer_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Account_Consumer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Account_Merchants",
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
                    IsAccountConfirmed = table.Column<bool>(nullable: true),
                    MerchantId = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(maxLength: 12, nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 100, nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    UserType = table.Column<string>(nullable: true),
                    StaffId = table.Column<string>(nullable: true),
                    IsSocial = table.Column<bool>(nullable: false),
                    SocialId = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(maxLength: 100, nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account_Merchants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_Merchants_Merchants_MerchantId",
                        column: x => x.MerchantId,
                        principalTable: "Merchants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MerchantCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    MerchantStoreId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MerchantCategories_StoreCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "StoreCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MerchantCategories_Merchants_MerchantStoreId",
                        column: x => x.MerchantStoreId,
                        principalTable: "Merchants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Account_Riders",
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
                    IsAccountConfirmed = table.Column<bool>(nullable: true),
                    MobileNumber = table.Column<string>(maxLength: 12, nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    Password = table.Column<string>(maxLength: 100, nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    Rating = table.Column<double>(nullable: false),
                    RatingCount = table.Column<int>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Location = table.Column<Point>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    DeliveryStatus = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    TotalTime = table.Column<string>(nullable: true),
                    TripsCount = table.Column<int>(nullable: false),
                    TotalCredits = table.Column<decimal>(nullable: false),
                    TotalEarnings = table.Column<decimal>(nullable: false),
                    TotalHours = table.Column<double>(nullable: false),
                    TotalKms = table.Column<double>(nullable: false),
                    DefaultWalletId = table.Column<int>(nullable: true),
                    LimitAmount = table.Column<decimal>(type: "decimal(26,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account_Riders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_Riders_Wallets_DefaultWalletId",
                        column: x => x.DefaultWalletId,
                        principalTable: "Wallets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonProfile",
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
                    RiderId = table.Column<int>(nullable: true),
                    Prefix = table.Column<string>(maxLength: 10, nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    Suffix = table.Column<string>(maxLength: 10, nullable: true),
                    Nationality = table.Column<string>(maxLength: 100, nullable: true),
                    CivilStatus = table.Column<string>(maxLength: 100, nullable: true),
                    Gender = table.Column<string>(maxLength: 10, nullable: true),
                    DateBirth = table.Column<DateTime>(nullable: true),
                    PlaceBirth = table.Column<string>(maxLength: 255, nullable: true),
                    MobileNumber = table.Column<string>(maxLength: 12, nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    TelNo = table.Column<string>(maxLength: 20, nullable: true),
                    Address1 = table.Column<string>(maxLength: 255, nullable: true),
                    Address2 = table.Column<string>(maxLength: 255, nullable: true),
                    Barangay = table.Column<string>(maxLength: 255, nullable: true),
                    CityMunicipality = table.Column<string>(maxLength: 255, nullable: true),
                    Province = table.Column<string>(maxLength: 255, nullable: true),
                    Region = table.Column<string>(maxLength: 255, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 15, nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    AboutMe = table.Column<string>(nullable: true),
                    TransportType = table.Column<string>(maxLength: 50, nullable: true),
                    yearModel = table.Column<string>(maxLength: 4, nullable: true),
                    Make = table.Column<string>(maxLength: 50, nullable: true),
                    Model = table.Column<string>(maxLength: 50, nullable: true),
                    PlateNo = table.Column<string>(maxLength: 50, nullable: true),
                    Color = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonProfile_Account_Riders_RiderId",
                        column: x => x.RiderId,
                        principalTable: "Account_Riders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiderDevices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    RiderId = table.Column<int>(nullable: false),
                    Brand = table.Column<string>(maxLength: 100, nullable: true),
                    Model = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiderDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiderDevices_Account_Riders_RiderId",
                        column: x => x.RiderId,
                        principalTable: "Account_Riders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonWorkExperience",
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
                    PersonId = table.Column<int>(nullable: false),
                    profileId = table.Column<int>(nullable: true),
                    MonthYearFrom = table.Column<string>(maxLength: 25, nullable: true),
                    MonthYearTo = table.Column<string>(maxLength: 25, nullable: true),
                    Company = table.Column<string>(maxLength: 255, nullable: true),
                    CompanyLocation = table.Column<string>(maxLength: 255, nullable: true),
                    Role = table.Column<string>(maxLength: 255, nullable: true),
                    Salary = table.Column<string>(maxLength: 255, nullable: true),
                    JobDescription = table.Column<string>(maxLength: 255, nullable: true),
                    Remarks = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonWorkExperience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonWorkExperience_PersonProfile_profileId",
                        column: x => x.profileId,
                        principalTable: "PersonProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Account_Admin",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DeletedBy", "DeliveryStatus", "EmailAddress", "FirstName", "GUID", "ImagePath", "IsAccountConfirmed", "JobPosition", "LastName", "MobileNumber", "ModifiedBy", "Password", "SetEffectivity", "Status", "UserType", "Username", "ValidUntil" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 15, 3, 29, 31, 227, DateTimeKind.Utc).AddTicks(2167), null, null, null, 0, "admin1@gmail.com", null, "deeceae7-0aa2-4bf6-9fe7-b4c987809604", null, true, null, null, "639198286400", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", false, 1, null, "admin1@gmail.com", new DateTime(2022, 1, 15, 3, 29, 31, 227, DateTimeKind.Utc).AddTicks(2595) },
                    { 2, null, new DateTime(2022, 1, 15, 3, 29, 31, 227, DateTimeKind.Utc).AddTicks(3881), null, null, null, 0, "admin2@gmail.com", null, "15dcef74-3c48-4ef6-a3ab-ce08438dc084", null, true, null, null, "639198286401", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", false, 1, null, "admin2@gmail.com", new DateTime(2022, 1, 15, 3, 29, 31, 227, DateTimeKind.Utc).AddTicks(3888) },
                    { 3, null, new DateTime(2022, 1, 15, 3, 29, 31, 227, DateTimeKind.Utc).AddTicks(3939), null, null, null, 0, "admin3@gmail.com", null, "46c043ff-5dcd-44e3-a32e-5c6b8381e9b5", null, true, null, null, "639198286402", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", false, 2, null, "admin3@gmail.com", new DateTime(2022, 1, 15, 3, 29, 31, 227, DateTimeKind.Utc).AddTicks(3940) }
                });

            migrationBuilder.InsertData(
                table: "Account_Consumer",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DeletedBy", "EmailAddress", "FirstName", "GUID", "ImagePath", "IsAccountConfirmed", "IsSocial", "LastName", "MobileNumber", "ModifiedBy", "Rating", "RatingCount", "SocialId", "Status" },
                values: new object[,]
                {
                    { 12, null, new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(614), null, null, null, "Consumer12@gmail.com", null, "fe3d2077-ff1a-4c51-9199-c115b3357935", null, false, false, null, "639198286711", null, 0.0, 0, "", 1 },
                    { 14, null, new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(620), null, null, null, "Consumer14@gmail.com", null, "e6f3fee9-8ffb-4d05-a66a-6866041a92cf", null, false, false, null, "639198286713", null, 0.0, 0, "", 1 },
                    { 13, null, new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(617), null, null, null, "Consumer13@gmail.com", null, "646f788f-262a-4be1-9158-a69f67e3db97", null, false, false, null, "639198286712", null, 0.0, 0, "", 1 },
                    { 11, null, new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(611), null, null, null, "Consumer11@gmail.com", null, "3dfd05ff-235f-4058-9699-968fa354d4cc", null, false, false, null, "639198286710", null, 0.0, 0, "", 1 },
                    { 10, null, new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(605), null, null, null, "Consumer10@gmail.com", null, "67f77d1d-6bcd-41f9-ac0d-1a3d03e208c7", null, false, false, null, "639198286709", null, 0.0, 0, "", 1 },
                    { 9, null, new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(602), null, null, null, "Consumer9@gmail.com", null, "2fac0a49-5949-414e-ac55-0100eae6ed65", null, false, false, null, "639198286708", null, 0.0, 0, "", 1 },
                    { 8, null, new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(599), null, null, null, "Consumer8@gmail.com", null, "8380df7b-3401-4567-ba19-55f5efccfe91", null, false, false, null, "639198286707", null, 0.0, 0, "", 1 },
                    { 7, null, new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(596), null, null, null, "Consumer7@gmail.com", null, "e98ad9f6-182e-4d02-be97-7c751a61cf91", null, false, false, null, "639198286706", null, 0.0, 0, "", 1 },
                    { 5, null, new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(589), null, null, null, "Consumer5@gmail.com", null, "e464beb5-94eb-4aa6-9bcf-267afc70cd3d", null, false, false, null, "639198286704", null, 0.0, 0, "", 1 },
                    { 4, null, new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(554), null, null, null, "Consumer4@gmail.com", null, "a2985585-a9a9-49d1-94fa-68ca08a78036", null, false, false, null, "639198286703", null, 0.0, 0, "", 1 },
                    { 3, null, new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(550), null, null, null, "Consumer3@gmail.com", null, "d51c7f00-f721-4314-a8af-70b8b57f7723", null, false, false, null, "639198286702", null, 0.0, 0, "", 1 },
                    { 6, null, new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(593), null, null, null, "Consumer6@gmail.com", null, "ff2bbd63-caf8-4822-b831-57fca4be32b3", null, false, false, null, "639198286705", null, 0.0, 0, "", 1 },
                    { 1, null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(9078), null, null, null, "Consumer1@gmail.com", null, "c3b51b43-5a0c-488a-9a16-88936f832777", null, false, false, null, "639198286700", null, 0.0, 0, "", 1 },
                    { 2, null, new DateTime(2022, 1, 15, 3, 29, 31, 237, DateTimeKind.Utc).AddTicks(493), null, null, null, "Consumer2@gmail.com", null, "d6f05409-8c15-4490-995f-af7938bbe670", null, false, false, null, "639198286701", null, 0.0, 0, "", 1 }
                });

            migrationBuilder.InsertData(
                table: "Account_Riders",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DefaultWalletId", "DeletedBy", "DeliveryStatus", "EmailAddress", "FirstName", "GUID", "ImagePath", "IsAccountConfirmed", "LastName", "Latitude", "LimitAmount", "Location", "Longitude", "MiddleName", "MobileNumber", "ModifiedBy", "Password", "Rating", "RatingCount", "StartTime", "Status", "TotalCredits", "TotalEarnings", "TotalHours", "TotalKms", "TotalTime", "TripsCount" },
                values: new object[,]
                {
                    { 4, null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1153), null, null, null, null, 0, "rider4@gmail.com", "rider 4", "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF4", null, true, null, 10.321177, 0m, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.918676 10.321177)"), 123.918676, null, "639198286604", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", 0.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, 0m, 0.0, 0.0, null, 0 },
                    { 3, null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1140), null, null, null, null, 0, "rider3@gmail.com", "rider 3", "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF3", null, true, null, 10.316795000000001, 0m, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.919382 10.316795)"), 123.919382, null, "639198286603", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", 0.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, 0m, 0.0, 0.0, null, 0 },
                    { 2, null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(988), null, null, null, null, 0, "rider2@gmail.com", "rider 2", "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF2", null, true, null, 10.31744, 0m, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.922918 10.31744)"), 123.922918, null, "639198286602", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", 0.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, 0m, 0.0, 0.0, null, 0 },
                    { 1, null, new DateTime(2022, 1, 15, 3, 29, 31, 235, DateTimeKind.Utc).AddTicks(9133), null, null, null, null, 0, "rider1@gmail.com", "rider 1", "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF1", null, true, null, 10.319055000000001, 0m, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.927663 10.319055)"), 123.927663, null, "639198286601", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", 0.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, 0m, 0.0, 0.0, null, 0 },
                    { 7, null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1187), null, null, null, null, 0, "rider7@gmail.com", "rider 7", "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF7", null, true, null, 10.322524, 0m, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.919163 10.322524)"), 123.919163, null, "639198286607", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", 0.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, 0m, 0.0, 0.0, null, 0 },
                    { 14, null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1290), null, null, null, null, 0, "rider14@gmail.com", "rider 14", "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF14", null, true, null, 10.312063999999999, 0m, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.91514 10.312064)"), 123.91513999999999, null, "639198286614", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", 0.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, 0m, 0.0, 0.0, null, 0 },
                    { 6, null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1177), null, null, null, null, 0, "rider6@gmail.com", "rider 6", "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF6", null, true, null, 10.323675, 0m, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (23.922006 10.323675)"), 23.922006, null, "639198286606", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", 0.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, 0m, 0.0, 0.0, null, 0 },
                    { 12, null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1266), null, null, null, null, 0, "rider12@gmail.com", "rider 12", "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF12", null, true, null, 10.313533, 0m, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.926971 10.313533)"), 123.92697099999999, null, "639198286612", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", 0.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, 0m, 0.0, 0.0, null, 0 },
                    { 11, null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1256), null, null, null, null, 0, "rider11@gmail.com", "rider 11", "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF11", null, true, null, 10.312856999999999, 0m, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.922765 10.312857)"), 123.922765, null, "639198286611", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", 0.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, 0m, 0.0, 0.0, null, 0 },
                    { 10, null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1218), null, null, null, null, 0, "rider10@gmail.com", "rider 10", "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF10", null, true, null, 10.313616, 0m, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.919796 10.313616)"), 123.91979600000001, null, "639198286610", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", 0.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, 0m, 0.0, 0.0, null, 0 },
                    { 5, null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1163), null, null, null, null, 0, "rider5@gmail.com", "rider 5", "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF5", null, true, null, 10.319350999999999, 0m, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.919407 10.319351)"), 123.91940700000001, null, "639198286605", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", 0.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, 0m, 0.0, 0.0, null, 0 },
                    { 9, null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1207), null, null, null, null, 0, "rider9@gmail.com", "rider 9", "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF9", null, true, null, 10.312856999999999, 0m, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.919796 10.312857)"), 123.91979600000001, null, "639198286609", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", 0.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, 0m, 0.0, 0.0, null, 0 },
                    { 8, null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1197), null, null, null, null, 0, "rider8@gmail.com", "rider 8", "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF8", null, true, null, 10.316311000000001, 0m, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.918791 10.316311)"), 123.918791, null, "639198286608", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", 0.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, 0m, 0.0, 0.0, null, 0 },
                    { 13, null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(1278), null, null, null, null, 0, "rider13@gmail.com", "rider 13", "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF13", null, true, null, 10.312573, 0m, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.919889 10.312573)"), 123.919889, null, "639198286613", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", 0.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, 0m, 0.0, 0.0, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Merchants",
                columns: new[] { "Id", "Address1", "Address2", "AutoAccept", "Barangay", "BranchGroup", "CityMunicipality", "Company", "ContactFirstName", "ContactLastName", "ContactNo", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DeletedBy", "Email", "GUID", "ImagePath", "IsClose", "IsOnline", "IsPause", "LandMark", "Latitude", "Location", "Longitude", "MerchantKmRange", "ModifiedBy", "NoOfEmployees", "ParentId", "ParentMerchantStoreEntityId", "Prepaid", "Province", "Region", "RiderKmRange", "Status", "ZipCode" },
                values: new object[,]
                {
                    { 1, null, null, true, null, "aeda1003-c339-4de0-bf76-77a70db0fe1d", null, "Merchant Company  1", null, null, null, null, new DateTime(2022, 1, 15, 3, 29, 31, 231, DateTimeKind.Utc).AddTicks(7464), null, null, null, "MerchantStore1@gmail.com", "ae36fbd3-a345-4f41-84a0-e6f65741d62e", "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1635517246/passafood/eog3og3lgvrsxd5ooaiy.png", false, false, false, null, 10.253758260084641, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.81194936066956 10.253758260084641)"), 123.81194936066956, 2000.0, null, 0, null, 0, false, null, null, 500.0, 1, null },
                    { 2, null, null, true, null, "237230ec-1722-4e51-b4de-ac5a5fe4f10a", null, "Merchant Company  2", null, null, null, null, new DateTime(2022, 1, 15, 3, 29, 31, 233, DateTimeKind.Utc).AddTicks(7400), null, null, null, "MerchantStore2@gmail.com", "6b8f70ed-11e8-4a12-9e82-1f4a6429c957", "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1635517246/passafood/eog3og3lgvrsxd5ooaiy.png", false, false, false, null, 10.253758260084641, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.81194936066957 10.253758260084641)"), 123.81194936066957, 2000.0, null, 0, null, 0, false, null, null, 500.0, 2, null },
                    { 3, null, null, true, null, "f6fad38d-ef24-4d8b-90dc-a7fc7627a153", null, "Merchant Company  3", null, null, null, null, new DateTime(2022, 1, 15, 3, 29, 31, 233, DateTimeKind.Utc).AddTicks(7496), null, null, null, "MerchantStore3@gmail.com", "7e48434c-7c9b-4d6c-9aeb-a99300ba8d78", "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1635517246/passafood/eog3og3lgvrsxd5ooaiy.png", false, false, false, null, 10.253758260084643, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (123.81194936066959 10.253758260084643)"), 123.81194936066959, 2000.0, null, 0, null, 0, false, null, null, 500.0, 3, null }
                });

            migrationBuilder.InsertData(
                table: "PersonProfile",
                columns: new[] { "Id", "AboutMe", "Address1", "Address2", "Barangay", "CityMunicipality", "CivilStatus", "Color", "CreatedBy", "DateBirth", "DateCreated", "DateDeleted", "DateModified", "DeletedBy", "EmailAddress", "FirstName", "GUID", "Gender", "ImagePath", "LastName", "Make", "MiddleName", "MobileNumber", "Model", "ModifiedBy", "Nationality", "PlaceBirth", "PlateNo", "Prefix", "Province", "Region", "RiderId", "Suffix", "TelNo", "TransportType", "ZipCode", "yearModel" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, new DateTime(2022, 1, 15, 3, 29, 31, 235, DateTimeKind.Utc).AddTicks(6796), null, null, null, null, null, "4b302a43-1342-4101-972b-39e590484de0", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null },
                    { 2, null, null, null, null, null, null, null, null, null, new DateTime(2022, 1, 15, 3, 29, 31, 235, DateTimeKind.Utc).AddTicks(7180), null, null, null, null, null, "f47e505c-880c-4d0e-97bc-3332b4cdb6b1", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "RiderActivities",
                columns: new[] { "Id", "ActivityDate", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DeletedBy", "GUID", "ModifiedBy", "RiderId", "Status", "activity" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(2826), null, null, null, "7306c58e-e1b5-458d-8377-623761413f5c", null, null, "ACCEPTED", "ORDER ID:YR-89731210" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(3170), null, null, null, "7e3121da-50d2-43fb-99b2-c311b44d0bb0", null, null, "STOPPED", "Last Moving Time 00:04:04" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(3189), null, null, null, "17c1feeb-3c95-4691-b43d-a17c96799ded", null, null, "STOPPED", "Last Moving Time 00:07:04" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 15, 3, 29, 31, 236, DateTimeKind.Utc).AddTicks(3185), null, null, null, "0d92a51a-3d43-4538-9404-f618db66acd9", null, null, "START MOVING", "Last Stoppage Time 00:06:04" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "GUID", "RoleName", "Status" },
                values: new object[,]
                {
                    { 2, "8310a842-516a-4946-91e4-3ddf2a524dbb", "User", true },
                    { 1, "a14af6e3-9bd4-47a0-89dd-18cf4ecf5c1f", "Admin", true }
                });

            migrationBuilder.InsertData(
                table: "StoreCategories",
                columns: new[] { "Id", "Description", "GUID", "ImagePath", "ParentId", "Remarks" },
                values: new object[,]
                {
                    { 8, "Food Truck", "91da6c23-2f03-4540-b77c-2b25b27bf99a", "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289992/passafood/merchant_categories/m0gyjtumgswn2ljs4k9p.png", null, null },
                    { 7, "Pop Up", "146fb086-7306-464b-a33a-f87195c12215", "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289991/passafood/merchant_categories/d6lkyr0rpxpgkw6fp9vv.png", null, null },
                    { 6, "Family Style", "402b755d-4641-4239-9378-1af21c6f4f7c", "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289992/passafood/merchant_categories/tdsqbyyfwxztw7xrdcpi.png", null, null },
                    { 5, "Prepare It Yourself", "9ac61d05-3b13-475d-b4ca-0ffdfebefc3a", "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289991/passafood/merchant_categories/o5xytte0r4jqs9sznpbo.png", null, null },
                    { 4, "Buffet", "e48a653d-4e69-4f8c-bad6-2d161689c6d6", "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289993/passafood/merchant_categories/gd8sjby9egzrdh5umx09.png", null, null },
                    { 3, "Fast Casual", "d402cbb6-4bc2-4235-9e6a-ee0fb4d8ebfe", "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289992/passafood/merchant_categories/m0gyjtumgswn2ljs4k9p.png", null, null },
                    { 2, "Fine Dining", "e1e39514-6719-4c83-8e70-8ade4faef97f", "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289992/passafood/merchant_categories/xjeqrxdfo2psbtj9qwgo.png", null, null },
                    { 1, "Fast Food", "2b29a005-abc1-46cc-aadf-a5f82ef87ea8", "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289991/passafood/merchant_categories/tixso8yavpwry41og13k.png", null, null }
                });

            migrationBuilder.InsertData(
                table: "Account_Merchants",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DeletedBy", "EmailAddress", "FirstName", "GUID", "ImagePath", "IsAccountConfirmed", "IsSocial", "LastName", "MerchantId", "MobileNumber", "ModifiedBy", "Password", "SocialId", "StaffId", "Status", "UserType" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 15, 3, 29, 31, 233, DateTimeKind.Utc).AddTicks(7985), null, null, null, "MerchantUser1@gmail.com", "MerchantUser  1", "ecfbcaf4-bf61-4f73-a37a-09b633340fd3", null, true, false, null, 1, "639198286601", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", null, null, 1, null },
                    { 2, null, new DateTime(2022, 1, 15, 3, 29, 31, 233, DateTimeKind.Utc).AddTicks(8828), null, null, null, "MerchantUser21@gmail.com", "MerchantUser  2", "b6a8ead5-b951-40c3-b712-0d7e00c2203a", null, true, false, null, 2, "639198286602", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", null, null, 2, null },
                    { 3, null, new DateTime(2022, 1, 15, 3, 29, 31, 233, DateTimeKind.Utc).AddTicks(8880), null, null, null, "MerchantUser3@gmail.com", "MerchantUser  3", "588ddb19-f845-431e-b653-c87748e6df3e", null, true, false, null, 3, "639198286603", null, "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", null, null, 3, null }
                });

            migrationBuilder.InsertData(
                table: "MerchantCategories",
                columns: new[] { "Id", "CategoryId", "GUID", "MerchantStoreId", "Status" },
                values: new object[,]
                {
                    { 1, 1, "766fe8ac-164e-47b8-9eb3-513148c88f8e", 1, 1 },
                    { 2, 1, "199fe4b0-361b-4fd6-a5c1-93ff9f0fc50a", 2, 1 },
                    { 3, 1, "15ceb3cd-65e9-4cff-bf0e-80450ed1cd5a", 3, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_Merchants_MerchantId",
                table: "Account_Merchants",
                column: "MerchantId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_Riders_DefaultWalletId",
                table: "Account_Riders",
                column: "DefaultWalletId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerFavorites_ConsumerAccountEntityId",
                table: "ConsumerFavorites",
                column: "ConsumerAccountEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddressBook_ConsumerId",
                table: "CustomerAddressBook",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_MerchantCategories_CategoryId",
                table: "MerchantCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MerchantCategories_MerchantStoreId",
                table: "MerchantCategories",
                column: "MerchantStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Merchants_ParentId",
                table: "Merchants",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonProfile_RiderId",
                table: "PersonProfile",
                column: "RiderId",
                unique: true,
                filter: "[RiderId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PersonWorkExperience_profileId",
                table: "PersonWorkExperience",
                column: "profileId");

            migrationBuilder.CreateIndex(
                name: "IX_RiderDevices_RiderId",
                table: "RiderDevices",
                column: "RiderId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreCategories_ParentId",
                table: "StoreCategories",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account_Admin");

            migrationBuilder.DropTable(
                name: "Account_Merchants");

            migrationBuilder.DropTable(
                name: "ConsumerFavorites");

            migrationBuilder.DropTable(
                name: "CustomerAddressBook");

            migrationBuilder.DropTable(
                name: "MerchantCategories");

            migrationBuilder.DropTable(
                name: "MerchantOpeningHours");

            migrationBuilder.DropTable(
                name: "MerchantStaffs");

            migrationBuilder.DropTable(
                name: "MerchantUserTypeEntities");

            migrationBuilder.DropTable(
                name: "PasswordAdmins");

            migrationBuilder.DropTable(
                name: "PasswordMerchants");

            migrationBuilder.DropTable(
                name: "PasswordRiders");

            migrationBuilder.DropTable(
                name: "PersonWorkExperience");

            migrationBuilder.DropTable(
                name: "RefreshTokenAdmins");

            migrationBuilder.DropTable(
                name: "RefreshTokenConsumers");

            migrationBuilder.DropTable(
                name: "RefreshTokenMerchants");

            migrationBuilder.DropTable(
                name: "RefreshTokenRiders");

            migrationBuilder.DropTable(
                name: "RiderActivities");

            migrationBuilder.DropTable(
                name: "RiderDevices");

            migrationBuilder.DropTable(
                name: "RiderRequirements");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "RouteModelRoles");

            migrationBuilder.DropTable(
                name: "RouteModels");

            migrationBuilder.DropTable(
                name: "UserLocationLogs");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Account_Consumer");

            migrationBuilder.DropTable(
                name: "StoreCategories");

            migrationBuilder.DropTable(
                name: "Merchants");

            migrationBuilder.DropTable(
                name: "PersonProfile");

            migrationBuilder.DropTable(
                name: "Account_Riders");

            migrationBuilder.DropTable(
                name: "Wallets");
        }
    }
}
