using AutoMapper;
using Business.Dtos.Requests.CourseSubTypeRequests;
using Business.Dtos.Responses.CourseSubTypeResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CourseSubTypeProfile : Profile
    {
        public CourseSubTypeProfile()

        {
            CreateMap<CreateCourseSubTypeRequest, CourseSubType>();
            CreateMap<CourseSubType, CreatedCourseSubTypeResponse>();


            CreateMap<CourseSubType, GetListCourseSubTypeResponse>().ReverseMap();
            CreateMap<Paginate<CourseSubType>, Paginate<GetListCourseSubTypeResponse>>();

            CreateMap<UpdateCourseSubTypeRequest, CourseSubType>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<CourseSubType, UpdatedCourseSubTypeResponse>();
        }
    }
}
