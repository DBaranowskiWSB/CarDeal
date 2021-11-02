using System.Collections.Generic;
using System.Threading.Tasks;
using CarDeal.API.Services.EF.Entities.Cars;
using CarDeal.API.Services.Repositories.CarRepository.Filters;

namespace CarDeal.API.Services.Repositories.CarRepository.Interfaces
{
    public interface ICarRepository
    {
       Task<List<CarAd>> GetNewest(int numberOfRecords); 
       
       Task<List<CarAd>> GetFiltered(int numberOfRecords, CarFilter filterObject); 
    }
}