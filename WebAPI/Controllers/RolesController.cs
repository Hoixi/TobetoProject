using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Abstracts;
using Business.Dtos.Requests.RoleRequests;

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

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id, bool permanent)
        {
            var result = await _roleService.Delete(Id, permanent);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _roleService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetRoleById")]
        public async Task<IActionResult> Get(int Id)
        {
            var result = await _roleService.GetRoleById(Id);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody]UpdateRoleRequest updateRoleRequest)
        {
            var result = await _roleService.Update(updateRoleRequest);
            return Ok(result);
        }
    }
}
