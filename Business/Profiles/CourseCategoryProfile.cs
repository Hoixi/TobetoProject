using AutoMapper;
using Business.Dtos.Requests.CourseCategoryRequests;
using Business.Dtos.Responses.CourseCategoryResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CourseCategoryProfile : Profile
    {
        public CourseCategoryProfile()

        {
            CreateMap<CreateCourseCategoryRequest, CourseCategory>();
            CreateMap<CourseCategory, CreatedCourseCategoryResponse>();


            CreateMap<CourseCategory, GetListCourseCategoryResponse>()
                .ForMember(c => c.CourseName, opt => opt.MapFrom(src => src.Course.Name))
                .ForMember(c => c.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ReverseMap();
            CreateMap<Paginate<CourseCategory>, Paginate<GetListCourseCategoryResponse>>();

            CreateMap<UpdateCourseCategoryRequest, CourseCategory>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<CourseCategory, UpdatedCourseCategoryResponse>();
        }
    }
}
