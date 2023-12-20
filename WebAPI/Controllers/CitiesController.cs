using Business.Abstracts;
using Business.Dtos.Requests.CityRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        ICityService _citySerrvice;

        public CitiesController(ICityService citySerrvice)
        {
            _citySerrvice = citySerrvice;
        }


        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateCityRequest createCityRequest)
        {
            var result = await _citySerrvice.AddAsync(createCityRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _citySerrvice.GetAllAsync(pageRequest);
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateCityRequest updateCityRequest)
        {
            var result = await _citySerrvice.UpdateAsync(updateCityRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _citySerrvice.DeleteAsync(id);
            return Ok(result);
        }

    }
}
