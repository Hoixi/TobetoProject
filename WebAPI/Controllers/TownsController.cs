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
    [Authorize(Policy = "RequireAdminRole")]

    public class TownsController : ControllerBase
    {
        ITownService _townService;

        public TownsController(ITownService townService)
        {
            _townService = townService;
        }

        [HttpPost("Add")]

        public async Task<IActionResult> Add([FromQuery]CreateTownRequest createTownRequest)
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
        public async Task<IActionResult> Update([FromQuery] UpdateTownRequest updateTownRequest)
        {
            var result = await _townService.UpdateAsync(updateTownRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
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

    }
}
