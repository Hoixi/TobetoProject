using AutoMapper;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Requests.InstructorRequests;
using Business.Dtos.Requests.RoleRequests;
using Business.Dtos.Responses.CourseResponses;
using Business.Dtos.Responses.InstructorResponse;
using Business.Dtos.Responses.RoleResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile() 
        {
            CreateMap<CreateCourseRequest, Course>();
            CreateMap<Course, CreatedCourseResponse>();

            CreateMap<UpdateCourseRequest, Course>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Course, UpdatedCourseResponse>();



            CreateMap<Course, GetCourseListResponse>()
                .ForMember(destinationMember: p => p.Path, memberOptions: opt => opt.MapFrom(p => p.Image.Path));
            CreateMap<Paginate<Course>, Paginate<GetInstructorListResponse>>().ReverseMap();




        }
    }
}
