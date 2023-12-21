using Business.Abstracts;
using Business.Dtos.Requests.TownRequests;
using Business.Dtos.Requests.UserSurveyRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        public async Task<IActionResult> Update([FromQuery] UpdateUserSurveyRequest updateUserSurveyRequest)
        {
            var result = await _userSurveyService.UpdateAsync(updateUserSurveyRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _userSurveyService.DeleteAsync(id);
            return Ok(result);
        }
    }
}
