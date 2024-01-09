using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstracts;
using Business.Dtos.Requests.LanguageRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : Controller
    {
        ILanguageService _languageService;

        public LanguagesController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateLanguageRequest createLanguageRequest)
        {
            var result = await _languageService.AddAsync(createLanguageRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _languageService.GetAllAsync(pageRequest);
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateLanguageRequest updateLanguageRequest)
        {
            var result = await _languageService.UpdateAsync(updateLanguageRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _languageService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _languageService.GetById(id);
            return Ok(result);
        }

    }
}

