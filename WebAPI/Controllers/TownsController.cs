using Business.Abstracts;
using Business.Dtos.Requests.TownRequests;
using Business.Dtos.Requests.UserRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]

    public class TownsController : ControllerBase
    {
        ITownService _townService;

        public TownsController(ITownService townService)
        {
            _townService = townService;
        }

        [HttpPost("Add")]

        public async Task<IActionResult> Add([FromBody]CreateTownRequest createTownRequest)
        {
            var result = await _townService.AddAsync(createTownRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _townService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateTownRequest updateTownRequest)
        {
            var result = await _townService.UpdateAsync(updateTownRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await _townService.DeleteAsync(id);
            return Ok(result);
        }
        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _townService.GetById(id);
            return Ok(result);
        }

        [HttpGet("getByCityId")]
        public async Task<IActionResult> GetByCityId([FromQuery] PageRequest pageRequest, int cityId)
        {
            var result = await _townService.GetListByCityId(pageRequest, cityId);
            return Ok(result);
        }

    }
}
