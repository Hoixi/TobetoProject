using Business.Abstracts;
using Business.Dtos.Requests.TownRequests;
using Business.Dtos.Requests.UserSocialMediaRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSocialMediasController : ControllerBase
    {
        IUserSocialMediaService _userSocialMediaService;

        public UserSocialMediasController(IUserSocialMediaService userSocialMediaService)
        {
            _userSocialMediaService = userSocialMediaService;
        }

        [HttpPost("Add")]

        public async Task<IActionResult> Add([FromBody] CreateUserSocialMediaRequest createUserSocialMediaRequest)
        {
            var result = await _userSocialMediaService.AddAsync(createUserSocialMediaRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _userSocialMediaService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateUserSocialMediaRequest updateUserSocialMediaRequest)
        {
            var result = await _userSocialMediaService.UpdateAsync(updateUserSocialMediaRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _userSocialMediaService.DeleteAsync(id);
            return Ok(result);
        }
    }
}
