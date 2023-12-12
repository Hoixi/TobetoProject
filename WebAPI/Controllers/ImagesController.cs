using Business.Abstracts;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Requests.ImageRequests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        IImageService _imageService;

        public ImagesController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateImageRequest createImageRequest)
        {
            var result = await _imageService.Add(createImageRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id, bool permanent)
        {
            var result = await _imageService.Delete(Id, permanent);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _imageService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetImageById")]
        public async Task<IActionResult> Get(int Id)
        {
            var result = await _imageService.GetImageById(Id);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateImageRequest updateImageRequest)
        {
            var result = await _imageService.Update(updateImageRequest);
            return Ok(result);
        }

    }
}
