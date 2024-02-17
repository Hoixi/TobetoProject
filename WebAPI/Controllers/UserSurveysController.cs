using Business.Abstracts;
using Business.Dtos.Requests.TownRequests;
using Business.Dtos.Requests.UserSurveyRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]

    public class UserSurveysController : ControllerBase
    {

        IUserSurveyService _userSurveyService;

        public UserSurveysController(IUserSurveyService userSurveyService)
        {
            _userSurveyService = userSurveyService;
        }

        [HttpPost("Add")]

        public async Task<IActionResult> Add([FromBody] CreateUserSurveyRequest createUserSurveyRequest)
        {
            var result = await _userSurveyService.AddAsync(createUserSurveyRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _userSurveyService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateUserSurveyRequest updateUserSurveyRequest)
        {
            var result = await _userSurveyService.UpdateAsync(updateUserSurveyRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await _userSurveyService.DeleteAsync(id);
            return Ok(result);
        }
        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _userSurveyService.GetById(id);
            return Ok(result);
        }

        [HttpGet("getByUserId")]
        public async Task<IActionResult> GetByUserId(int userId, [FromQuery] PageRequest pageRequest)
        {
            var result = await _userSurveyService.GetByUserId(pageRequest, userId);
            return Ok(result);
        }
    }
}
