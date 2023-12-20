using Business.Abstracts;
using Business.Dtos.Requests.UserAnnouncementRequests;
using Business.Dtos.Requests.UserCertificateRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCertificatesController : ControllerBase
    {
        IUserCertificateService _userCertificateService;

        public UserCertificatesController(IUserCertificateService userCertificateService)
        {
            _userCertificateService = userCertificateService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateUserCertificateRequest createUserCertificateRequest)
        {
            var result = await _userCertificateService.AddAsync(createUserCertificateRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _userCertificateService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateUserCertificateRequest updateUserCertificateRequest)
        {
            var result = await _userCertificateService.UpdateAsync(updateUserCertificateRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int Id)
        {
            var result = await _userCertificateService.DeleteAsync(Id);
            return Ok(result);
        }
    }
}
