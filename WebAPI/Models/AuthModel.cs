using Business.Dtos.Responses.ClasroomResponses;
using Business.Dtos.Responses.ClassroomResponses;
using Business.Dtos.Responses.CourseResponses;
using Business.Dtos.Responses.InstructorResponse;
using Business.Dtos.Responses.UserResponses;

namespace WebAPI.Models;

public class AuthModel
{
    public CreatedInstructorResponse Instructor { get; set; }
    public CreateUserResponse User { get; set; }
    public CreatedCourseResponse Course { get; set; }
    public List<GetClassroomListResponse> Classroom { get; set; }
}
