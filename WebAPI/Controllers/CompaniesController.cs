using Business.Abstracts;
using Business.Dtos.Requests.CompanyRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        ICompanyService _companyService;

        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateCompanyRequest createCompanyRequest)
        {
            var result = await _companyService.AddAsync(createCompanyRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _companyService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateCompanyRequest updateCompanyRequest)
        {
            var result = await _companyService.UpdateAsync(updateCompanyRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _companyService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _companyService.GetById(id);
            return Ok(result);
        }
    }
}
