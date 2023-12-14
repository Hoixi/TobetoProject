using Business.Abstracts;
using Business.Dtos.Requests.GroupRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        IGroupService _groupService;

        public GroupsController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateGroupRequest createGroupRequest)
        {
            var result = await _groupService.Add(createGroupRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id, bool permanent)
        {
            var result = await _groupService.Delete(Id, permanent);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _groupService.GetAll(pageRequest);
            return Ok(result);
        }

        [HttpGet("GetGroupById")]
        public async Task<IActionResult> Get(int Id)
        {
            var result = await _groupService.GetGroupById(Id);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateGroupRequest updateGroupRequest)
        {
            var result = await _groupService.Update(updateGroupRequest);
            return Ok(result);
        }


    }
}
