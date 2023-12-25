using AutoMapper;
using Business.Dtos.Requests.ClassroomInstructorRequests;
using Business.Dtos.Responses.ClassroomInstructorResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class CourseInstructorProfile : Profile
{
    public CourseInstructorProfile()

    {
        CreateMap<CreateCourseInstructorRequest, CourseInstructor>();
        CreateMap<CourseInstructor, CreatedCourseInstructorResponse>();


        CreateMap<CourseInstructor, GetListCourseInstructorResponse>()
            .ForMember(i => i.InstructorName, opt => opt.MapFrom(src => $"{src.Instructor.User.FirstName} {src.Instructor.User.LastName}"))
            .ReverseMap();
        CreateMap<Paginate<CourseInstructor>, Paginate<GetListCourseInstructorResponse>>();
        CreateMap<UpdateCourseInstructorRequest, CourseInstructor>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
        CreateMap<CourseInstructor, UpdatedCourseInstructorResponse>();
    }
}