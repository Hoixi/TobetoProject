using Business.Abstracts;
using Business.Dtos.Requests.AddressRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        IAddressService _addressService;

        public AddressesController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateAddressRequest createAddressRequest)
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
        public async Task<IActionResult> Update([FromQuery] UpdateAddressRequest updateAddressRequest)
        {
            var result = await _addressService.UpdateAsync(updateAddressRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int Id)
        {
            var result = await _addressService.DeleteAsync(Id);
            return Ok(result);
        }




    }
}
