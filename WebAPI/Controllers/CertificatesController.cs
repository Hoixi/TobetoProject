using Business.Abstracts;
using Business.Dtos.Requests.CertificateRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificatesController : ControllerBase
    {
        ICertificateService _certificateService;

        public CertificatesController(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateCertificateRequest createCertificateRequest)
        {
            var result = await _certificateService.AddAsync(createCertificateRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _certificateService.GetAllAsync(pageRequest);
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateCertificateRequest updateCertificateRequest)
        {
            var result = await _certificateService.UpdateAsync(updateCertificateRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _certificateService.DeleteAsync(id);
            return Ok(result);
        }

    }
}
