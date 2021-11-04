using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CarDeal.API.Services.DTO.FiltersDto;
using CarDeal.API.Services.EF.DbContexts;
using CarDeal.API.Services.EF.Entities.Cars;
using CarDeal.API.Services.Repositories.CarRepository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarDeal.API.Services.Repositories.CarRepository
{
    public class CarRepository : ICarRepository
    {
        private readonly CarDealContext _carDealContext;

        public CarRepository(CarDealContext carDealContext)
        {
            _carDealContext = carDealContext;
        }
        
        public async Task<List<CarAd>> GetNewest(int numberOfRecords)
        {
            var adList = new List<CarAd>();
            
            try
            {
                if (numberOfRecords is > 0 and < 1000)
                {
                    adList = await _carDealContext.CarAds
                        .Include(x => x.BodyType)
                        .Include(f => f.FuelType)
                        .Include(b => b.VehicleBrand)
                        .Include(a => a.PhotoAddresses)
                        .OrderByDescending(x=>x.Id)
                        .Take(numberOfRecords)
                        .ToListAsync();
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return adList;
        }

        public async Task<List<CarAd>> GetFiltered(int numberOfRecords, CarFilterDto filterObject)
        {
            var adList = new List<CarAd>();
            
            try
            {
                if (numberOfRecords is > 0 and < 1000)
                {
                    adList = CarAdFilter.FilterAds(filterObject, await GetNewest(numberOfRecords));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return adList;
        }
    }
}