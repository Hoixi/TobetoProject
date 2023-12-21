using Business.Abstracts;
using Business.Dtos.Requests.SurveyRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveysController : ControllerBase
    {
        ISurveyService _surveyService;

        public SurveysController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateSurveyRequest createSurveyRequest)
        {
            var result = await _surveyService.AddAsync(createSurveyRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _surveyService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateSurveyRequest updateSurveyRequest)
        {
            var result = await _surveyService.UpdateAsync(updateSurveyRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _surveyService.DeleteAsync(id);
            return Ok(result);
        }
    }
}
