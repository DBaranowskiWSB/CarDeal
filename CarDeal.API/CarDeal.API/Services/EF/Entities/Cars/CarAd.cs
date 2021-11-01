using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDeal.API.Services.EF.Entities.Cars
{
    public class CarAd
    {
        [Required] 
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string MerchantName { get; set; }

        public string Model { get; set; }

        public BodyType BodyType { get; set; }

        public VehicleBrand VehicleBrand { get; set; }

        public int Mileage { get; set; }

        public int YearOfProduction { get; set; }

        public List<PhotoAddress> PhotoAddresses { get; set; }

        public FuelType FuelType { get; set; }

        public string MerchantTelephoneNumber { get; set; }

        public string MerchantEmailAddress { get; set; }
    }
}