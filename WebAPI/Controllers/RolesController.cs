using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Abstracts;
using Business.Dtos.Requests;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateRoleRequest createRoleRequest)
        {
            var result = await _roleService.Add(createRoleRequest);
            return Ok(result);
        }
    }
}
