using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarDeal.API.Services.DTO.CarAdDto;
using CarDeal.API.Services.DTO.FiltersDto;
using CarDeal.API.Services.EF.Entities.Cars;
using CarDeal.API.Services.Repositories.CarRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarDeal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public MainController(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        [HttpGet("GetNewestCars/{numberOfItems:int}")]
        public async Task<IActionResult> GetNewestCars(int numberOfItems)
        {
            try
            {
                if (numberOfItems is <= 0 or > 1000) return BadRequest("Number of cars must be between 0 and 1000");
                
                var carAds = await _carRepository.GetNewest(numberOfItems);

                if (carAds.Any())
                {
                    return Ok(_mapper.Map<List<CarAd>, List<CarAdDto>>(carAds));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Problem(e.ToString());
            }

            return NotFound();
        }

        [HttpPost("PostCarsFilters/{numberOfItems:int}")]
        public async Task<IActionResult> PostCarsFilters(int numberOfItems, [FromBody]CarFilterDto carFilterDto)
        {
            try
            {
                if (numberOfItems is <= 0 or > 1000) return BadRequest("Number of cars must be between 0 and 1000");

                if (!ModelState.IsValid) return BadRequest("Model is not valid");
                
                var carAds = await _carRepository.GetFiltered(numberOfItems, carFilterDto);

                if (carAds.Any())
                {
                    return Ok(_mapper.Map<List<CarAd>, List<CarAdDto>>(carAds));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Problem(e.ToString());
            }

            return NotFound();
        }
    }
}