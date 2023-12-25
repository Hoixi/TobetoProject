using AutoMapper;
using Business.Dtos.Requests.StudentRequests;
using Business.Dtos.Responses.StudentResponses;
using Business.Dtos.Responses.UserResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()

        {
            CreateMap<CreateStudentRequest, Student>();
            CreateMap<Student, CreatedStudentResponse>();

            CreateMap<User, GetListlimitedUserResponse>();

            CreateMap<Student, GetListStudentResponse>()
                 .ForMember(dest => dest.UserDetail, opt => opt.MapFrom(src => src.User))
                .ReverseMap();
            CreateMap<Paginate<Student>, Paginate<GetListStudentResponse>>();

            CreateMap<UpdateStudentRequest, Student>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Student, UpdatedStudentResponse>();
        }
    }
}


