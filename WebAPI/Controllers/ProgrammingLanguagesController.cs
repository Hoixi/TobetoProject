using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstracts;
using Business.Dtos.Requests.ProgrammingLanguageRequests;
using Core.DataAccess.Paging;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammingLanguagesController : Controller
    {
        IProgrammingLanguageService _programmingLanguageService;

        public ProgrammingLanguagesController(IProgrammingLanguageService programmingLanguageService)
        {
            _programmingLanguageService = programmingLanguageService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateProgrammingLanguageRequest createProgrammingLanguageRequest)
        {
            var result = await _programmingLanguageService.AddAsync(createProgrammingLanguageRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _programmingLanguageService.GetAllAsync(pageRequest);
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateProgrammingLanguageRequest updateProgrammingLanguageRequest)
        {
            var result = await _programmingLanguageService.UpdateAsync(updateProgrammingLanguageRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _programmingLanguageService.DeleteAsync(id);
            return Ok(result);
        }

    }
}

