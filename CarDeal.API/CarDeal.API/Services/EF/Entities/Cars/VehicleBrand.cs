using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDeal.API.Services.EF.Entities.Cars
{
    public class VehicleBrand
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }
        
        public List<CarAd> CarAds { get; set; }
    }
}