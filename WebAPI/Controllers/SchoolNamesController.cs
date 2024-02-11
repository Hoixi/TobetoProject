using Business.Abstracts;
using Business.Dtos.Requests.SchoolNameRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]

    public class SchoolNamesController : ControllerBase
    {
        ISchoolNameService _schoolNameService;

        public SchoolNamesController(ISchoolNameService schoolNameService)
        {
            _schoolNameService = schoolNameService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateSchoolNameRequest createSchoolNameRequest)
        {
            var result = await _schoolNameService.AddAsync(createSchoolNameRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _schoolNameService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateSchoolNameRequest updateSchoolNameRequest)
        {
            var result = await _schoolNameService.UpdateAsync(updateSchoolNameRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await _schoolNameService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _schoolNameService.GetById(id);
            return Ok(result);
        }
    }
}

