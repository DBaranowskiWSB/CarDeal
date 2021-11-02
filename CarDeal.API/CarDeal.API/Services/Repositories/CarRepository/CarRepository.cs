using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CarDeal.API.Services.EF.DbContexts;
using CarDeal.API.Services.EF.Entities.Cars;
using CarDeal.API.Services.Repositories.CarRepository.Filters;
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
                        .Include(x=>x.BodyType)
                        .Include(f=>f.FuelType)
                        .Include(b=>b.VehicleBrand)
                        .Include(a=>a.PhotoAddresses)
                        .TakeLast(numberOfRecords).ToListAsync();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return adList;
        }

        public async Task<List<CarAd>> GetFiltered(int numberOfRecords, CarFilter filterObject)
        {
            var adList = new List<CarAd>();
            
            try
            {
                if (numberOfRecords is > 0 and < 1000)
                {
                    adList = await _carDealContext.CarAds
                        .Include(x=>x.BodyType)
                        .Include(f=>f.FuelType)
                        .Include(b=>b.VehicleBrand)
                        .Include(a=>a.PhotoAddresses)
                        .Where(bodyType => bodyType.BodyType.Type == filterObject.BodyType)
                        .Where(vehicleBrand => vehicleBrand.VehicleBrand.Brand == filterObject.VehicleBrand)
                        .Where(model => string.Equals(model.Model, filterObject.Model, StringComparison.CurrentCultureIgnoreCase))
                        .Where(price => price.Price >= filterObject.MinimumPrice && price.Price <= filterObject.MaximumPrice)
                        .Where(mileage => mileage.Mileage >= filterObject.MinimumMileage && mileage.Mileage <= filterObject.MaximumMileage)
                        .Where(year => year.YearOfProduction >= filterObject.MinYearOfProduction && year.YearOfProduction <= filterObject.MaxYearOfProduction)
                        .Where(fuel => fuel.FuelType.Type == filterObject.FuelType)
                        .TakeLast(numberOfRecords)
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
        
        private Task<List<CarAd>> Get(Expression<Func<CarAd, bool>> filter = null,
            Func<IQueryable<CarAd>, IOrderedQueryable<CarAd>> orderBy = null,
            string includeProperties = null)
        {
            var query = _carDealContext.CarAds.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                var properties = includeProperties.Split(',');
                properties.ToList().ForEach(p => { query = query.Include(p); });
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return query.ToListAsync();
        }
    }
}