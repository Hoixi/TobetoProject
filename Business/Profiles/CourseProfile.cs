using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
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

            CreateMap<Course, GetCourseListResponse>().ReverseMap();
            CreateMap<Paginate<Course>, Paginate<GetCourseListResponse>>();

        }
    }
}
