using Business.Abstracts;
using Business.Dtos.Requests.UserRequests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery]CreateUserRequest createUserRequest)
        {
            var result = await _userService.AddAsync(createUserRequest);
            return Ok(result);
        }
    }
}
