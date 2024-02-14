using Business.Abstracts;
using Business.Dtos.Requests.LanguageRequests;
using Business.Dtos.Requests.UserOperationClaimRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]

    public class UserOperationClaimsController : ControllerBase
    {
        IUserOperationClaimService _userOperationClaimService;

        public UserOperationClaimsController(IUserOperationClaimService userOperationClaimService)
        {
            _userOperationClaimService = userOperationClaimService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateUserOperationClaimRequest createUserOperationClaimRequest)
        {
            var result = await _userOperationClaimService.AddAsync(createUserOperationClaimRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _userOperationClaimService.GetAllAsync(pageRequest);
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateUserOperationClaimRequest userOperationClaimRequest)
        {
            var result = await _userOperationClaimService.UpdateAsync(userOperationClaimRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await _userOperationClaimService.DeleteAsync(id);
            return Ok(result);
        }
    }
}
