using AccountManagement.Framework.Models;
using AccountManagement.FrameWork.Models;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AccountManagement.Framework.Data
{
    public static class ModelBuilderExtensions
    {
         public static void SeedRoles(this ModelBuilder modelBuilder)
         {
            modelBuilder.Entity<Role>().HasData(
                       new Role
                       {
                           Id = 1,
                           RoleName = "Admin"

                       },
                       new Role
                       {
                           Id = 2,
                           RoleName = "User"
                       });
        }

        public static void SeedCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { Id = 1, Description = "Fast Food", ImagePath = "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289991/passafood/merchant_categories/tixso8yavpwry41og13k.png" },
                new CategoryEntity { Id = 2, Description = "Fine Dining", ImagePath = "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289992/passafood/merchant_categories/xjeqrxdfo2psbtj9qwgo.png" },
                new CategoryEntity { Id = 3, Description = "Fast Casual", ImagePath = "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289992/passafood/merchant_categories/m0gyjtumgswn2ljs4k9p.png" },
                new CategoryEntity { Id = 4, Description = "Buffet", ImagePath = "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289993/passafood/merchant_categories/gd8sjby9egzrdh5umx09.png" },
                new CategoryEntity { Id = 5, Description = "Prepare It Yourself", ImagePath = "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289991/passafood/merchant_categories/o5xytte0r4jqs9sznpbo.png" },
                new CategoryEntity { Id = 6, Description = "Family Style", ImagePath = "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289992/passafood/merchant_categories/tdsqbyyfwxztw7xrdcpi.png" },
                new CategoryEntity { Id = 7, Description = "Pop Up", ImagePath = "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289991/passafood/merchant_categories/d6lkyr0rpxpgkw6fp9vv.png" },
                new CategoryEntity { Id = 8, Description = "Food Truck", ImagePath = "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1637289992/passafood/merchant_categories/m0gyjtumgswn2ljs4k9p.png" }
                );


            // Asian
            //American
            //Bagels
            //Bakery
            //Bar
            //BBQ
            //Beverages
            //Breakfast
            //British
            //Burgers
            //Casual Dining
            //Chicken
            //Chinese
            //Coffee
            //Deli
            //Desserts
            //Doughnts
            //European
            //Fast Food
            //Filipino
            //Fine Dining
            //Food Trucks
            //French
            //German
            //Gluten - free
            //Greek
            //Hot Dogs
            //Ice Cream
            //Indian
            //Italian
            //Japanese
            //Korean
            //Milk Tea
            //Mediterranean
            //Mexican
            //Pancakes and Waffles
            //Pizza
            //Sandwiches
            //Seafoods
            //Soup and Salad
            //Steaks
            //Thai
            //Vegan


        }

        public static void SeedAdmin(this ModelBuilder modelBuilder)
        {
            //password123
            modelBuilder.Entity<AdminAccountEntity>().HasData(
                new AdminAccountEntity() { Id = 1, Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", Username = "admin1@gmail.com", EmailAddress = "admin1@gmail.com", MobileNumber = "639198286400", IsAccountConfirmed = true, Status = EStatus.Active },
                new AdminAccountEntity() { Id = 2, Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", Username = "admin2@gmail.com", EmailAddress = "admin2@gmail.com", MobileNumber = "639198286401", IsAccountConfirmed = true, Status = EStatus.Active },
                new AdminAccountEntity() { Id = 3, Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", Username = "admin3@gmail.com", EmailAddress = "admin3@gmail.com", MobileNumber = "639198286402", IsAccountConfirmed = true, Status = EStatus.Pending }
            );
        }
        public static void SeedRider(this ModelBuilder modelBuilder)
        {
            var gf = NtsGeometryServices.Instance.CreateGeometryFactory(4326);

            var wallet1 = new WalletEntity() { Id = 1, Name = "Passafood" };
            var wallet2 = new WalletEntity() { Id = 2, Name = "G-CASH" };


            modelBuilder.Entity<PersonProfile>().HasData(
                wallet1, wallet2
                );

            //password123
            var rider1 = new RiderAccountEntity() { Id = 1, MobileNumber = "639198286601", EmailAddress = "rider1@gmail.com", Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, Status = RiderStatus.Active, FirstName = "rider 1", GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF1", Latitude = 10.319055, Longitude = 123.927663, Location = gf.CreatePoint(new Coordinate(123.927663, 10.319055)) };
            var rider2 = new RiderAccountEntity() { Id = 2, MobileNumber = "639198286602", EmailAddress = "rider2@gmail.com", Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, Status = RiderStatus.Active, FirstName = "rider 2", GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF2", Latitude = 10.317440, Longitude = 123.922918, Location = gf.CreatePoint(new Coordinate(123.922918, 10.317440)) };
            var rider3 = new RiderAccountEntity() { Id = 3, MobileNumber = "639198286603", EmailAddress = "rider3@gmail.com", Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, Status = RiderStatus.Active, FirstName = "rider 3", GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF3", Latitude = 10.316795, Longitude = 123.919382, Location = gf.CreatePoint(new Coordinate(123.919382, 10.316795)) };
            var rider4 = new RiderAccountEntity() { Id = 4, MobileNumber = "639198286604", EmailAddress = "rider4@gmail.com", Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, Status = RiderStatus.Active, FirstName = "rider 4", GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF4", Latitude = 10.321177, Longitude = 123.918676, Location = gf.CreatePoint(new Coordinate(123.918676, 10.321177)) };
            var rider5 = new RiderAccountEntity() { Id = 5, MobileNumber = "639198286605", EmailAddress = "rider5@gmail.com", Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, Status = RiderStatus.Active, FirstName = "rider 5", GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF5", Latitude = 10.319351, Longitude = 123.919407, Location = gf.CreatePoint(new Coordinate(123.919407, 10.319351)) };
            var rider6 = new RiderAccountEntity() { Id = 6, MobileNumber = "639198286606", EmailAddress = "rider6@gmail.com", Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, Status = RiderStatus.Active, FirstName = "rider 6", GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF6", Latitude = 10.323675, Longitude = 23.922006, Location = gf.CreatePoint(new Coordinate(23.922006, 10.323675)) };
            var rider7 = new RiderAccountEntity() { Id = 7, MobileNumber = "639198286607", EmailAddress = "rider7@gmail.com", Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, Status = RiderStatus.Active, FirstName = "rider 7", GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF7", Latitude = 10.322524, Longitude = 123.919163, Location = gf.CreatePoint(new Coordinate(123.919163, 10.322524)) };
            var rider8 = new RiderAccountEntity() { Id = 8, MobileNumber = "639198286608", EmailAddress = "rider8@gmail.com", Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, Status = RiderStatus.Active, FirstName = "rider 8", GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF8", Latitude = 10.316311, Longitude = 123.918791, Location = gf.CreatePoint(new Coordinate(123.918791, 10.316311)) };
            var rider9 = new RiderAccountEntity() { Id = 9, MobileNumber = "639198286609", EmailAddress = "rider9@gmail.com", Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, Status = RiderStatus.Active, FirstName = "rider 9", GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF9", Latitude = 10.312857, Longitude = 123.919796, Location = gf.CreatePoint(new Coordinate(123.919796, 10.312857)) };
            var rider10 = new RiderAccountEntity() { Id = 10, MobileNumber = "639198286610", EmailAddress = "rider10@gmail.com", Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, Status = RiderStatus.Active, FirstName = "rider 10", GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF10", Latitude = 10.313616, Longitude = 123.919796, Location = gf.CreatePoint(new Coordinate(123.919796, 10.313616)) };
            var rider11 = new RiderAccountEntity() { Id = 11, MobileNumber = "639198286611", EmailAddress = "rider11@gmail.com", Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, Status = RiderStatus.Active, FirstName = "rider 11", GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF11", Latitude = 10.312857, Longitude = 123.922765, Location = gf.CreatePoint(new Coordinate(123.922765, 10.312857)) };
            var rider12 = new RiderAccountEntity() { Id = 12, MobileNumber = "639198286612", EmailAddress = "rider12@gmail.com", Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, Status = RiderStatus.Active, FirstName = "rider 12", GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF12", Latitude = 10.313533, Longitude = 123.926971, Location = gf.CreatePoint(new Coordinate(123.926971, 10.313533)) };
            var rider13 = new RiderAccountEntity() { Id = 13, MobileNumber = "639198286613", EmailAddress = "rider13@gmail.com", Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, Status = RiderStatus.Active, FirstName = "rider 13", GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF13", Latitude = 10.312573, Longitude = 123.919889, Location = gf.CreatePoint(new Coordinate(123.919889, 10.312573)) };
            var rider14 = new RiderAccountEntity() { Id = 14, MobileNumber = "639198286614", EmailAddress = "rider14@gmail.com", Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, Status = RiderStatus.Active, FirstName = "rider 14", GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF14", Latitude = 10.312064, Longitude = 123.915140, Location = gf.CreatePoint(new Coordinate(123.915140, 10.312064)) };

            //var profile1 = new PersonProfile() { Id = 1, RiderId = 1, GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF1", MobileNumber = "639198286601", EmailAddress = "rider1@gmail.com", FirstName = "Rider 1" };
            //var profile2 = new PersonProfile() { Id = 2, RiderId = 2, GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF2", MobileNumber = "639198286602", EmailAddress = "rider2@gmail.com", FirstName = "Rider 2" };
            //var profile3 = new PersonProfile() { Id = 3, RiderId = 3, GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF3", MobileNumber = "639198286603", EmailAddress = "rider3@gmail.com", FirstName = "Rider 3" };
            //var profile4 = new PersonProfile() { Id = 4, RiderId = 4, GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF4", MobileNumber = "639198286604", EmailAddress = "rider4@gmail.com", FirstName = "Rider 4" };
            //var profile5 = new PersonProfile() { Id = 5, RiderId = 5, GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF5", MobileNumber = "639198286605", EmailAddress = "rider5@gmail.com", FirstName = "Rider 5" };
            //var profile6 = new PersonProfile() { Id = 6, RiderId = 6, GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF6", MobileNumber = "639198286606", EmailAddress = "rider6@gmail.com", FirstName = "Rider 6" };
            //var profile7 = new PersonProfile() { Id = 7, RiderId = 7, GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF7", MobileNumber = "639198286607", EmailAddress = "rider7@gmail.com", FirstName = "Rider 7" };
            //var profile8 = new PersonProfile() { Id = 8, RiderId = 8, GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF8", MobileNumber = "639198286608", EmailAddress = "rider8@gmail.com", FirstName = "Rider 8" };
            //var profile9 = new PersonProfile() { Id = 9, RiderId = 9, GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF9", MobileNumber = "639198286609", EmailAddress = "rider9@gmail.com", FirstName = "Rider 9" };
            //var profile10 = new PersonProfile() { Id = 10, RiderId = 10, GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF10", MobileNumber = "639198286610", EmailAddress = "rider10@gmail.com", FirstName = "Rider 10" };
            //var profile11 = new PersonProfile() { Id = 11, RiderId = 11, GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF11", MobileNumber = "639198286611", EmailAddress = "rider11@gmail.com", FirstName = "Rider 11" };
            //var profile12 = new PersonProfile() { Id = 12, RiderId = 12, GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF12", MobileNumber = "639198286612", EmailAddress = "rider12@gmail.com", FirstName = "Rider 12" };
            //var profile13 = new PersonProfile() { Id = 13, RiderId = 13, GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF13", MobileNumber = "639198286613", EmailAddress = "rider13@gmail.com", FirstName = "Rider 13" };
            //var profile14 = new PersonProfile() { Id = 14, RiderId = 14, GUID = "71A8C0EC-2007-4E1A-A666-2D9AE917AFBF14", MobileNumber = "639198286614", EmailAddress = "rider14@gmail.com", FirstName = "Rider 14" };

            //rider1.profile = profile1;
            //rider2.profile = profile2;
            //rider3.profile = profile3;
            //rider4.profile = profile4;
            //rider5.profile = profile5;
            //rider6.profile = profile6;
            //rider7.profile = profile7;
            //rider8.profile = profile8;
            //rider9.profile = profile9;
            //rider10.profile = profile10;
            //rider11.profile = profile11;
            //rider12.profile = profile12;
            //rider13.profile = profile13;
            //rider14.profile = profile14;

            modelBuilder.Entity<RiderAccountEntity>().HasData(
                rider1,
                rider2,
                rider3,
                rider4,
                rider5,
                rider6,
                rider7,
                rider8,
                rider9,
                rider10,
                rider11,
                rider12,
                rider13,
                rider14
           );

          //  modelBuilder.Entity<PersonProfile>().HasData(
          //      profile1,
          //      profile2,
          //      profile3,
          //      profile4,
          //      profile5,
          //      profile6,
          //      profile7,
          //      profile8,
          //      profile9,
          //      profile10,
          //      profile11,
          //      profile12,
          //      profile13,
          //      profile14
          //);



            modelBuilder.Entity<RiderActivityEntity>().HasData(
                 new RiderActivityEntity { Id = 1, Status = "ACCEPTED", Activity = "ORDER ID:YR-89731210" },
                 new RiderActivityEntity { Id = 2, Status = "STOPPED", Activity = "Last Moving Time 00:04:04" },
                 new RiderActivityEntity { Id = 3, Status = "START MOVING", Activity = "Last Stoppage Time 00:06:04" },
                 new RiderActivityEntity { Id = 4, Status = "STOPPED", Activity = "Last Moving Time 00:07:04" }
                );


            modelBuilder.Entity<RiderRequirement>().HasData(
                new RiderRequirement() { Id = 1, RiderId = rider1.GUID, DocumentName = "Drivers License(Front)", ImagePath = "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1635517246/passafood/eog3og3lgvrsxd5ooaiy.png" },
                new RiderRequirement() { Id = 2, RiderId = rider1.GUID, DocumentName = "Drivers License(Back)", ImagePath = "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1635517246/passafood/eog3og3lgvrsxd5ooaiy.png" }
                );

        }

        public static void SeedMerchant(this ModelBuilder modelBuilder)
        {
            //password123
            //10.31272475780387, 123.89361262762247
            //POINT(123.8893126043795 10.293138653024998)
            // POINT(123.89008508055228 10.29301197895092)
            // POINT(123.89004216520935 10.294542620606679)

            var gf = NtsGeometryServices.Instance.CreateGeometryFactory(4326);
            var store1 = new MerchantStoreEntity() { Id = 1, Email = "MerchantStore1@gmail.com", Status = EStatus.Active, Company = "Merchant Company  1", Latitude = 10.253758260084641, Longitude = 123.81194936066956, Location = gf.CreatePoint(new Coordinate(123.81194936066956, 10.253758260084641)), GUID = "ae36fbd3-a345-4f41-84a0-e6f65741d62e", ImagePath = "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1635517246/passafood/eog3og3lgvrsxd5ooaiy.png" };
            var store2 = new MerchantStoreEntity() { Id = 2, Email = "MerchantStore2@gmail.com", Status = EStatus.Pending, Company = "Merchant Company  2", Latitude = 10.253758260084642, Longitude = 123.81194936066957, Location = gf.CreatePoint(new Coordinate(123.81194936066957, 10.253758260084642)), GUID = "6b8f70ed-11e8-4a12-9e82-1f4a6429c957", ImagePath = "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1635517246/passafood/eog3og3lgvrsxd5ooaiy.png" };
            var store3 = new MerchantStoreEntity() { Id = 3, Email = "MerchantStore3@gmail.com", Status = EStatus.Cancelled, Company = "Merchant Company  3", Latitude = 10.253758260084643, Longitude = 123.81194936066958, Location = gf.CreatePoint(new Coordinate(123.81194936066958, 10.253758260084643)), GUID = "7e48434c-7c9b-4d6c-9aeb-a99300ba8d78", ImagePath = "https://res.cloudinary.com/reddstar-transportation-solution-corp/image/upload/v1635517246/passafood/eog3og3lgvrsxd5ooaiy.png" };

            var muser1 = new MerchantAccountEntity() { Id = 1, MobileNumber = "639198286601", EmailAddress = "MerchantUser1@gmail.com", Status = EStatus.Active, Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, FirstName = "MerchantUser  1", GUID = "ecfbcaf4-bf61-4f73-a37a-09b633340fd3" };
            var muser2 = new MerchantAccountEntity() { Id = 2, MobileNumber = "639198286602", EmailAddress = "MerchantUser21@gmail.com", Status = EStatus.Pending, Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, FirstName = "MerchantUser  2", GUID = "b6a8ead5-b951-40c3-b712-0d7e00c2203a" };
            var muser3 = new MerchantAccountEntity() { Id = 3, MobileNumber = "639198286603", EmailAddress = "MerchantUser3@gmail.com", Status = EStatus.Cancelled, Password = "G30l0g!cH@$H2048$Iv2+u0Fn70iLUsSb33lJJfUNWgnYu1wYKiTwFRKLS36YBQzrJ1GYnQOa", IsAccountConfirmed = true, FirstName = "MerchantUser  3", GUID = "588ddb19-f845-431e-b653-c87748e6df3e" };

            var storeCat1 = new MerchantCategoryEntity() { Id = 1, CategoryId = 1, MerchantStoreId = 1, Status = EStatus.Active };
            var storeCat2 = new MerchantCategoryEntity() { Id = 2, CategoryId = 1, MerchantStoreId = 2, Status = EStatus.Active };
            var storeCat3 = new MerchantCategoryEntity() { Id = 3, CategoryId = 1, MerchantStoreId = 3, Status = EStatus.Active };

            muser1.MerchantId = store1.Id;
            muser2.MerchantId = store2.Id;
            muser3.MerchantId = store3.Id;



            modelBuilder.Entity<MerchantStoreEntity>().HasData(
                 store1, store2, store3
           );

            modelBuilder.Entity<MerchantAccountEntity>().HasData(
              muser1, muser2, muser3
            );

            modelBuilder.Entity<MerchantCategoryEntity>().HasData(
            storeCat1, storeCat2, storeCat3
          );

        }

        public static void SeedConsumer(this ModelBuilder modelBuilder)
        {
            var gf = NtsGeometryServices.Instance.CreateGeometryFactory(4326);
            //password123
            modelBuilder.Entity<ConsumerAccountEntity>().HasData(
           new ConsumerAccountEntity() { Id = 1, MobileNumber = "639198286700", EmailAddress = "Consumer1@gmail.com", IsSocial = false, SocialId = "", Status = ConsumerStatus.Active, GUID = "d6f05409-8c15-4490-995f-af7938bbe670" },
           new ConsumerAccountEntity() { Id = 2, MobileNumber = "639198286701", EmailAddress = "Consumer2@gmail.com", IsSocial = false, SocialId = "", Status = ConsumerStatus.Active, GUID = "d6f05409-8c15-4490-995f-af7938bbe670" },
           new ConsumerAccountEntity() { Id = 3, MobileNumber = "639198286702", EmailAddress = "Consumer3@gmail.com", IsSocial = false, SocialId = "", Status = ConsumerStatus.Active, GUID = "d51c7f00-f721-4314-a8af-70b8b57f7723" },
           new ConsumerAccountEntity() { Id = 4, MobileNumber = "639198286703", EmailAddress = "Consumer4@gmail.com", IsSocial = false, SocialId = "", Status = ConsumerStatus.Active, GUID = "a2985585-a9a9-49d1-94fa-68ca08a78036" },
           new ConsumerAccountEntity() { Id = 5, MobileNumber = "639198286704", EmailAddress = "Consumer5@gmail.com", IsSocial = false, SocialId = "", Status = ConsumerStatus.Active, GUID = "e464beb5-94eb-4aa6-9bcf-267afc70cd3d" },
           new ConsumerAccountEntity() { Id = 6, MobileNumber = "639198286705", EmailAddress = "Consumer6@gmail.com", IsSocial = false, SocialId = "", Status = ConsumerStatus.Active, GUID = "ff2bbd63-caf8-4822-b831-57fca4be32b3" },
           new ConsumerAccountEntity() { Id = 7, MobileNumber = "639198286706", EmailAddress = "Consumer7@gmail.com", IsSocial = false, SocialId = "", Status = ConsumerStatus.Active, GUID = "e98ad9f6-182e-4d02-be97-7c751a61cf91" },
           new ConsumerAccountEntity() { Id = 8, MobileNumber = "639198286707", EmailAddress = "Consumer8@gmail.com", IsSocial = false, SocialId = "", Status = ConsumerStatus.Active, GUID = "8380df7b-3401-4567-ba19-55f5efccfe91" },
           new ConsumerAccountEntity() { Id = 9, MobileNumber = "639198286708", EmailAddress = "Consumer9@gmail.com", IsSocial = false, SocialId = "", Status = ConsumerStatus.Active, GUID = "2fac0a49-5949-414e-ac55-0100eae6ed65" },
           new ConsumerAccountEntity() { Id = 10, MobileNumber = "639198286709", EmailAddress = "Consumer10@gmail.com", IsSocial = false, SocialId = "", Status = ConsumerStatus.Active, GUID = "67f77d1d-6bcd-41f9-ac0d-1a3d03e208c7" },
           new ConsumerAccountEntity() { Id = 11, MobileNumber = "639198286710", EmailAddress = "Consumer11@gmail.com", IsSocial = false, SocialId = "", Status = ConsumerStatus.Active, GUID = "3dfd05ff-235f-4058-9699-968fa354d4cc" },
           new ConsumerAccountEntity() { Id = 12, MobileNumber = "639198286711", EmailAddress = "Consumer12@gmail.com", IsSocial = false, SocialId = "", Status = ConsumerStatus.Active, GUID = "fe3d2077-ff1a-4c51-9199-c115b3357935" },
           new ConsumerAccountEntity() { Id = 13, MobileNumber = "639198286712", EmailAddress = "Consumer13@gmail.com", IsSocial = false, SocialId = "", Status = ConsumerStatus.Active, GUID = "646f788f-262a-4be1-9158-a69f67e3db97" },
           new ConsumerAccountEntity() { Id = 14, MobileNumber = "639198286713", EmailAddress = "Consumer14@gmail.com", IsSocial = false, SocialId = "", Status = ConsumerStatus.Active, GUID = "e6f3fee9-8ffb-4d05-a66a-6866041a92cf", }
           );
        }
    }
}
