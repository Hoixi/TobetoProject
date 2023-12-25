using AutoMapper;
using Business.Dtos.Requests.ClassroomInstructorRequests;
using Business.Dtos.Responses.ClassroomInstructorResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class ClassroomInstructorProfile : Profile
{
    public ClassroomInstructorProfile()

    {
        CreateMap<CreateClassroomInstructorRequest, ClassroomInstructor>();
        CreateMap<ClassroomInstructor, CreatedClassroomInstructorResponse>();


        CreateMap<ClassroomInstructor, GetListClassroomInstructorResponse>()
            .ForMember(i => i.InstructorName, opt => opt.MapFrom(src => $"{src.Instructor.User.FirstName} {src.Instructor.User.LastName}"))
            .ReverseMap();
        CreateMap<Paginate<ClassroomInstructor>, Paginate<GetListClassroomInstructorResponse>>();

        CreateMap<UpdateClassroomInstructorRequest, ClassroomInstructor>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
        CreateMap<ClassroomInstructor, UpdatedClassroomInstructorResponse>();
    }
}