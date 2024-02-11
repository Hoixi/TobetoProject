using Business.Abstracts;
using Business.Dtos.Requests.ExperienceRequests;
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
    public class ExperiencesController : ControllerBase
    {
        IExperienceService _experienceService;

        public ExperiencesController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateExperienceRequest createExperienceRequest)
        {
            var result = await _experienceService.AddAsync(createExperienceRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _experienceService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateExperienceRequest updateExperienceRequest)
        {
            var result = await _experienceService.UpdateAsync(updateExperienceRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await _experienceService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _experienceService.GetById(id);
            return Ok(result);
        }

    }
}
