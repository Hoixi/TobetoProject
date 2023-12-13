using Business.Abstracts;
using Business.Dtos.Responses.ClasroomResponses;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    //Örnek sayfadır şuan için bir değeri bulunmamaktadır!! @Furkan Kayali
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IInstructorService _instructorService;
        IUserService _userService;
        ICourseService _courseService;
        IClassroomService _classroomService;

        public AuthController(IInstructorService instructorService,IUserService userService,ICourseService courseService,IClassroomService classroomService)
        {
            _instructorService = instructorService;
            _userService = userService;
            _courseService = courseService;
            _classroomService = classroomService;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get(int Id)
        {
            AuthModel authModel = new AuthModel();
            authModel.Instructor = await _instructorService.GetInstructorById(Id);
            authModel.User = await _userService.GetUserById(authModel.Instructor.UserId);
            authModel.Course = await _courseService.GetCourseById(authModel.Instructor.CourseId);
            var result = await _classroomService.GetAll();
            List<GetClassroomListResponse> list = new List<GetClassroomListResponse>();
            foreach (var item in result.Items)
            {
                list.Add(item);
            }
            authModel.Classroom = list;
            return Ok(authModel);
        }
    }
}
