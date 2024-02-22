using Business.Abstracts;
using Business.Dtos.Requests.BadgeRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BadgesController : ControllerBase
    {
        IBadgeService _badgeService;

        public BadgesController(IBadgeService badgeService)
        {
            _badgeService = badgeService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateBadgeRequest createBadgeRequest)
        {
            var result = await _badgeService.AddAsync(createBadgeRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _badgeService.GetAllAsync(pageRequest);
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateBadgeRequest updateBadgeRequest)
        {
            var result = await _badgeService.UpdateAsync(updateBadgeRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await _badgeService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _badgeService.GetById(id);
            return Ok(result);
        }

    }
}
