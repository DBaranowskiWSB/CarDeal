using System.Collections.Generic;
using CarDeal.API.Services.EF.Entities.Cars;

namespace CarDeal.API.Services.DTO.CarAdDto
{
    public class CarAdDto
    {
        public string Title { get; set; }
        
        public string Description { get; set; }

        public int Price { get; set; }

        public string MerchantName { get; set; }

        public string Model { get; set; }

        public BodyTypeDto BodyType { get; set; }

        public VehicleBrandDto VehicleBrand { get; set; }

        public int Mileage { get; set; }

        public int YearOfProduction { get; set; }

        public List<PhotoAddress> PhotoAddresses { get; set; }

        public FuelTypeDto FuelType { get; set; }

        public string MerchantTelephoneNumber { get; set; }

        public string MerchantEmailAddress { get; set; }
    }
}