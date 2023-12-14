using AutoMapper;
using Business.Dtos.Requests.InstructorRequests;
using Business.Dtos.Requests.StudentRequests;
using Business.Dtos.Responses.InstructorResponse;
using Business.Dtos.Responses.StudentResponse;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles;

public class StudentProfile : Profile
{
    public StudentProfile()
    {
        CreateMap<CreateStudentRequest, Student>();
        CreateMap<Student, CreatedStudentResponse>();

        CreateMap<UpdateStudentRequest, Student>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
        CreateMap<Student, UpdatedStudentResponse>();

        CreateMap<Student, GetStudentListResponse>()
            .ForMember(destinationMember: p => p.FirstName, memberOptions: opt => opt.MapFrom(p => p.User.FirstName))
            .ForMember(destinationMember: p => p.LastName, memberOptions: opt => opt.MapFrom(p => p.User.LastName))
            .ForMember(destinationMember: p => p.GroupName, memberOptions: opt => opt.MapFrom(p => p.Classroom.Group.GroupName))
            .ForMember(destinationMember: p => p.ClassName, memberOptions: opt => opt.MapFrom(p => p.Classroom.Name));
        CreateMap<Paginate<Student>, Paginate<GetStudentListResponse>>().ReverseMap();
    }
}
