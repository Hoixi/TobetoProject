using AutoMapper;
using Business.Dtos.Requests.ClassroomGroupCourseRequests;
using Business.Dtos.Responses.ClassroomGroupCourseResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ClassroomGroupCourseProfile : Profile
    {
        public ClassroomGroupCourseProfile()

        {
            CreateMap<CreateClassroomGroupCourseRequest, ClassroomGroupCourse>();
            CreateMap<ClassroomGroupCourse, CreatedClassroomGroupCourseResponse>();


            CreateMap<ClassroomGroupCourse, GetListClassroomGroupCourseResponse>().ReverseMap();
            CreateMap<Paginate<ClassroomGroupCourse>, Paginate<GetListClassroomGroupCourseResponse>>();

            CreateMap<UpdateClassroomGroupCourseRequest, ClassroomGroupCourse>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<ClassroomGroupCourse, UpdatedClassroomGroupCourseResponse>();
        }
    }
}
