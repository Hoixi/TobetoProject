using Business.Abstracts;
using Business.Dtos.Requests.AddressRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.CategoryResponses;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AddressesController : ControllerBase
    {
        IAddressService _addressService;

        public AddressesController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateAddressRequest createAddressRequest)
        {
            var result = await _addressService.AddAsync(createAddressRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _addressService.GetAllAsync(pageRequest);
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAddressRequest updateAddressRequest)
        {
            var result = await _addressService.UpdateAsync(updateAddressRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await _addressService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _addressService.GetById(id);
            return Ok(result);
        }




    }
}
