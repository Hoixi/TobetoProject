using Business.Abstracts;
using Business.Dtos.Requests.UserLanguageRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLanguagesController : ControllerBase
    {
        IUserLanguageService _userLanguageService;

        public UserLanguagesController(IUserLanguageService userLanguageService)
        {
            _userLanguageService = userLanguageService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateUserLanguageRequest createUserLanguageRequest)
        {
            var result = await _userLanguageService.AddAsync(createUserLanguageRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _userLanguageService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateUserLanguageRequest updateUserLanguageRequest)
        {
            var result = await _userLanguageService.UpdateAsync(updateUserLanguageRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _userLanguageService.DeleteAsync(id);
            return Ok(result);
        }
        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _userLanguageService.GetById(id);
            return Ok(result);
        }
    }
}
