using System.ComponentModel.DataAnnotations;

namespace CarDeal.API.Services.EF.Entities.Cars
{
    public class PhotoAddress
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Address { get; set; }
    }
}