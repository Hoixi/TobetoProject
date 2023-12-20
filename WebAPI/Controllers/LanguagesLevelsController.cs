using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstracts;
using Business.Dtos.Requests.LanguageLevelRequests;
using Core.DataAccess.Paging;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    public class LanguagesLevelsController : Controller
    {
        ILanguageLevelService _languageLevelService;

        public LanguagesLevelsController(ILanguageLevelService languageLevelService)
        {
            _languageLevelService = languageLevelService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateLanguageLevelRequest createLanguageLevelRequest)
        {
            var result = await _languageLevelService.AddAsync(createLanguageLevelRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _languageLevelService.GetAllAsync(pageRequest);
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateLanguageLevelRequest updateLanguageLevelRequest)
        {
            var result = await _languageLevelService.UpdateAsync(updateLanguageLevelRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _languageLevelService.DeleteAsync(id);
            return Ok(result);
        }


    }
}

