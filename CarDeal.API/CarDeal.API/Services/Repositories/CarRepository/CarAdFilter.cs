using System;
using System.Collections.Generic;
using System.Linq;
using CarDeal.API.Services.DTO.FiltersDto;
using CarDeal.API.Services.EF.Entities.Cars;

namespace CarDeal.API.Services.Repositories.CarRepository
{
    public static class CarAdFilter
    {
        public static List<CarAd> FilterAds(CarFilterDto filterObject, List<CarAd> adList)
        {
            adList = string.IsNullOrEmpty(filterObject.BodyType) switch
            {
                false => adList.Where(bodyType => bodyType.BodyType.Type == filterObject.BodyType).ToList(),
                _ => adList
            };
            
            adList = string.IsNullOrEmpty(filterObject.VehicleBrand) switch
            {
                false => adList.Where(vehicleBrand => vehicleBrand.VehicleBrand.Brand == filterObject.VehicleBrand)
                    .ToList(),
                _ => adList
            };
            
            adList = string.IsNullOrEmpty(filterObject.Model) switch
            {
                false => adList.Where(model =>
                        string.Equals(model.Model, filterObject.Model, StringComparison.CurrentCultureIgnoreCase))
                    .ToList(),
                _ => adList
            };
            
            adList = filterObject.MaximumPrice switch
            {
                > 0 => adList.Where(price =>
                        price.Price >= filterObject.MinimumPrice && price.Price <= filterObject.MaximumPrice)
                    .ToList(),
                _ => adList
            };
            
            adList = filterObject.MaximumMileage switch
            {
                > 0 => adList.Where(mileage =>
                        mileage.Mileage >= filterObject.MinimumMileage &&
                        mileage.Mileage <= filterObject.MaximumMileage)
                    .ToList(),
                _ => adList
            };
            
            adList = filterObject.MaximumPrice switch
            {
                > 0 => adList.Where(price =>
                        price.Price >= filterObject.MinimumPrice && price.Price <= filterObject.MaximumPrice)
                    .ToList(),
                _ => adList
            };
            
            adList = filterObject.MaxYearOfProduction switch
            {
                > 0 => adList.Where(year =>
                        year.YearOfProduction >= filterObject.MinYearOfProduction &&
                        year.YearOfProduction <= filterObject.MaxYearOfProduction)
                    .ToList(),
                _ => adList
            };
            
            adList = string.IsNullOrEmpty(filterObject.FuelType) switch
            {
                false => adList.Where(fuel => fuel.FuelType.Type == filterObject.FuelType).ToList(),
                _ => adList
            };

            return adList;
        }
    }
}