using Business.Abstracts;
using Business.Dtos.Requests.CityRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "RequireAdminRole")]
    public class CitiesController : ControllerBase
    {
        ICityService _cityService;

        public CitiesController(ICityService citySerrvice)
        {
            _cityService = citySerrvice;
        }


        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateCityRequest createCityRequest)
        {
            var result = await _cityService.AddAsync(createCityRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _cityService.GetAllAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _cityService.GetById(id);
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateCityRequest updateCityRequest)
        {
            var result = await _cityService.UpdateAsync(updateCityRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _cityService.DeleteAsync(id);
            return Ok(result);
        }

    }
}
