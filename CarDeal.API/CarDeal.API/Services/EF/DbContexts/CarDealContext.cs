using CarDeal.API.Services.EF.Entities.Cars;
using Microsoft.EntityFrameworkCore;

namespace CarDeal.API.Services.EF.DbContexts
{
    public class CarDealContext : DbContext
    {
        public DbSet<CarAd> CarAds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // MAC Connection String
            optionsBuilder.UseSqlServer("Server=localhost,1433;database=CarDealDb" + 
                                        ";User Id=sa;Password=yourStrong(!)Password;MultipleActiveResultSets=true");
            
            // Windows Connection String
            // optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=CarDealDb;" +
                                        // "trusted_connection=true");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BodyType>().HasData(
                new BodyType
                {
                    Id = 1,
                    Type = "Coupe"
                },
                new BodyType
                {
                    Id = 2,
                    Type = "Cabriolet"
                },
                new BodyType
                {
                    Id = 3,
                    Type = "SUV"
                },
                new BodyType
                {
                    Id = 4,
                    Type = "Sedan"
                },
                new BodyType
                {
                    Id = 5,
                    Type = "Compact"
                },
                new BodyType
                {
                    Id = 6,
                    Type = "Combi"
                },
                new BodyType
                {
                    Id = 7,
                    Type = "Other"
                }
            );
            
            modelBuilder.Entity<VehicleBrand>().HasData(
                new VehicleBrand
                {
                    Id = 1,
                    Brand = "BMW"
                },
                new VehicleBrand
                {
                    Id = 2,
                    Brand = "Opel"
                },
                new VehicleBrand
                {
                    Id = 3,
                    Brand = "Audi"
                },
                new VehicleBrand
                {
                    Id = 4,
                    Brand = "Volkswagen"
                },
                new VehicleBrand
                {
                    Id = 5,
                    Brand = "Ford"
                },
                new VehicleBrand
                {
                    Id = 6,
                    Brand = "Mercedes-Benz"
                },
                new VehicleBrand
                {
                    Id = 7,
                    Brand = "Renault"
                },
                new VehicleBrand
                {
                    Id = 8,
                    Brand = "Toyota"
                },
                new VehicleBrand
                {
                    Id = 9,
                    Brand = "Skoda"
                },
                new VehicleBrand
                {
                    Id = 10,
                    Brand = "Other"
                }
            );
            
            modelBuilder.Entity<FuelType>().HasData(
                new FuelType
                {
                    Id = 1,
                    Type = "Diesel"
                },
                new FuelType
                {
                    Id = 2,
                    Type = "Electric"
                },
                new FuelType
                {
                    Id = 3,
                    Type = "Petrol"
                },
                new FuelType
                {
                    Id = 4,
                    Type = "LPG"
                }
            );
        }
    }
}