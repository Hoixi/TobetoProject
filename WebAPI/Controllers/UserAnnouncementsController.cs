using Business.Abstracts;
using Business.Dtos.Requests.UserAnnouncementRequests;
using Business.Dtos.Requests.UserRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAnnouncementsController : ControllerBase
    {
        IUserAnnouncementService _userAnnouncementService;

        public UserAnnouncementsController(IUserAnnouncementService userAnnouncementService)
        {
            _userAnnouncementService = userAnnouncementService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateUserAnnouncementRequest createUserAnnouncementRequest)
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
        public async Task<IActionResult> Update([FromQuery] UpdateUserAnnouncementRequest updateUserAnnouncementRequest)
        {
            var result = await _userAnnouncementService.UpdateAsync(updateUserAnnouncementRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int Id)
        {
            var result = await _userAnnouncementService.DeleteAsync(Id);
            return Ok(result);
        }

    }
}
