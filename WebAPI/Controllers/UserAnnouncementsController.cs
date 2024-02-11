using Business.Abstracts;
using Business.Dtos.Requests.UserAnnouncementRequests;
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

    public class UserAnnouncementsController : ControllerBase
    {
        IUserAnnouncementService _userAnnouncementService;

        public UserAnnouncementsController(IUserAnnouncementService userAnnouncementService)
        {
            _userAnnouncementService = userAnnouncementService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateUserAnnouncementRequest createUserAnnouncementRequest)
        {
            var result = await _userAnnouncementService.AddAsync(createUserAnnouncementRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _userAnnouncementService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateUserAnnouncementRequest updateUserAnnouncementRequest)
        {
            var result = await _userAnnouncementService.UpdateAsync(updateUserAnnouncementRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await _userAnnouncementService.DeleteAsync(id);
            return Ok(result);
        }
        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _userAnnouncementService.GetById(id);
            return Ok(result);
        }


    }
}
