
using AccountManagement.Framework.Models;
using AccountManagement.FrameWork.Models;
using AccountManagement.FrameWork.Models.Models.Accounts.Admin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite;

namespace AccountManagement.Framework.Data
{
    public partial class AccountDbContext : DbContext
    {
        public virtual DbSet<CategoryEntity> StoreCategories { get; set; }
        public virtual DbSet<MerchantAccountEntity> MerchantAccounts { get; set; }
        public virtual DbSet<MerchantStoreEntity> MerchantStores { get; set; }
        public virtual DbSet<MerchantCategoryEntity> MerchantCategories { get; set; }
        public virtual DbSet<AdminAccountEntity> AdminAccounts { get; set; }
        public virtual DbSet<AdminEmployeeEntity>  AdminEStaffs { get; set; }
        public virtual DbSet<MerchantStaff>   MerchantStaffs { get; set; }
        public virtual DbSet<MerchantOpeningHour>  MerchantOpeningHours { get; set; }
        public virtual DbSet<MerchantUserRestrictionEntity>   MerchantUserRestrictionEntities { get; set; }
        public virtual DbSet<MerchantUserTypeEntity>   MerchantUserTypeEntities { get; set; }
        public virtual DbSet<AppOsMonitoring>   AppOsMonitorings { get; set; }
        public virtual DbSet<AppVersion>  AppVersions { get; set; }
        public virtual DbSet<StoreOfflineReasonEntity> StoreOfflineReasons { get; set; }

        //riders
        public virtual DbSet<RiderAccountEntity>  RiderAccounts  { get; set; }
        public virtual DbSet<WalletEntity>  Wallets { get; set; }
        public virtual DbSet<RiderRequirement>  RiderRequirements  { get; set; }
        public virtual DbSet<MerchantRequirement>   MerchantRequirements  { get; set; }

   
        public virtual DbSet<ConsumerAccountEntity> ConsumerAccounts { get; set; }
        public virtual DbSet<ConsumerFavorites>  ConsumerFavorites  { get; set; }
        public virtual DbSet<ConsumerAddressBookEntity> ConsumerAddresses  { get; set; }
        public virtual DbSet<PersonProfile> PersonProfile { get; set; }
        public virtual DbSet<PersonWorkExperience> PersonWorkExperience { get; set; }

        public virtual DbSet<PasswordAdmin>  PasswordAdmins  { get; set; }
        public virtual DbSet<PasswordRider>  PasswordRiders  { get; set; }
        public virtual DbSet<PasswordMerchant>  PasswordMerchants  { get; set; }
        public virtual DbSet<RiderDevice> RiderDevices { get; set; }
        public virtual DbSet<MaintanceMode>  MaintanceModes { get; set; }
   
        //Others     
        public virtual DbSet<RefreshTokenAdmin>   RefreshTokenAdmins { get; set; }
        public virtual DbSet<RefreshTokenConsumer>  RefreshTokenConsumers { get; set; }
        public virtual DbSet<RefreshTokenRider>   RefreshTokenRiders { get; set; }
        public virtual DbSet<RefreshTokenMerchant>  RefreshTokenMerchants { get; set; }


        //roles merchant

        public   DbSet<RouteModel> RouteModels { get; set; }
        public   DbSet<Role>  Roles { get; set; }
        public   DbSet<RouteModelRole> RouteModelRoles { get; set; }
        public   DbSet<UserRole>  UserRoles { get; set; }

        // Role admin
        public   DbSet<AdminRouteModel> AdminRouteModels { get; set; }
        public   DbSet<AdminRole> AdminRoles { get; set; }
        public   DbSet<AdminRouteModelRole> AdminRouteModelRoles { get; set; }
        public   DbSet<AdminUserRole> AdminUserRoles { get; set; }

        //logs
        public virtual DbSet<UserLocationLog> UserLocationLogs { get; set; }
        public virtual DbSet<RiderTripsLog> RiderTripsLogs { get; set; }
        public virtual DbSet<RiderActivityEntity> RiderActivities { get; set; }

        public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedRoles();
            modelBuilder.SeedAdmin();
            modelBuilder.SeedCategories();
            modelBuilder.SeedMerchant();
            modelBuilder.SeedRider();
            modelBuilder.SeedConsumer();

            //modelBuilder.Entity<MerchantOpeningHour>()
            //     .Property(x => x.FromTime)
            //     .HasConversion(new TimeSpanToTicksConverter());

            //modelBuilder.Entity<MerchantOpeningHour>()
            //.Property(x => x.ToTime)
            //.HasConversion(new TimeSpanToTicksConverter());

            //modelBuilder.Ignore<BookingHistory>();
            //modelBuilder.Ignore<BookingMain>();
        }
    }
}
