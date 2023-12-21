﻿using Business.Abstracts;
using Business.Dtos.Requests.CityRequests;
using Business.Dtos.Requests.TownRequests;
using Business.Dtos.Requests.UserSkillRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSkillsController : ControllerBase
    {

        IUserSkillService _userSkillService;

        public UserSkillsController(IUserSkillService userSkillService)
        {
            _userSkillService = userSkillService;
        }


        [HttpPost("Add")]

        public async Task<IActionResult> Add([FromBody] CreateUserSkillRequest createUserSkillRequest)
        {
            var result = await _userSkillService.AddAsync(createUserSkillRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _userSkillService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateUserSkillRequest updateUserSkillRequest)
        {
            var result = await _userSkillService.UpdateAsync(updateUserSkillRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _userSkillService.DeleteAsync(id);
            return Ok(result);
        }
    }
}
