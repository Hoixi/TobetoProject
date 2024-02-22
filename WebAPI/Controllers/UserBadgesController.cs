using Business.Abstracts;
using Business.Dtos.Requests.UserBadgeRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBadgesController : ControllerBase
    {
        IUserBadgeService _userBadgeService;

        public UserBadgesController(IUserBadgeService userBadgeService)
        {
            _userBadgeService = userBadgeService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateUserBadgeRequest createUserBadgeRequest)
        {
            var result = await _userBadgeService.AddAsync(createUserBadgeRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _userBadgeService.GetAllAsync(pageRequest);
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateUserBadgeRequest updateUserBadgeRequest)
        {
            var result = await _userBadgeService.UpdateAsync(updateUserBadgeRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await _userBadgeService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _userBadgeService.GetById(id);
            return Ok(result);
        }

    }
}
  