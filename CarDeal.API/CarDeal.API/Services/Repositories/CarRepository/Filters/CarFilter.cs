namespace CarDeal.API.Services.Repositories.CarRepository.Filters
{
    public class CarFilter
    {
        public string BodyType { get; set; }

        public string VehicleBrand { get; set; }

        public string Model { get; set; }

        public int MaximumPrice { get; set; }

        public int MinimumPrice { get; set; }

        public int MaximumMileage { get; set; }
        
        public int MinimumMileage { get; set; }
        
        public int MaxYearOfProduction { get; set; }
        
        public int MinYearOfProduction { get; set; }

        public string FuelType { get; set; }
    }
}