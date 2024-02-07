using Business.Abstracts;
using Business.Dtos.Requests.AddressRequests;
using Business.Dtos.Requests.AnnouncementRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AnnouncementsController : ControllerBase
    {
        IAnnouncementService _announcementService;

        public AnnouncementsController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateAnnouncementRequest createAnnouncementRequest)
        {
            var result = await _announcementService.AddAsync(createAnnouncementRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _announcementService.GetAllAsync(pageRequest);
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateAnnouncementRequest updateAnnouncementRequest)
        {
            var result = await _announcementService.UpdateAsync(updateAnnouncementRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _announcementService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _announcementService.GetById(id);
            return Ok(result);
        }
    }
}
