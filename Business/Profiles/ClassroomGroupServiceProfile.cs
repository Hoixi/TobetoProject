using AutoMapper;
using Business.Dtos.Requests.ClassroomGroupCourseRequest;
using Business.Dtos.Requests.ClassroomGroupCourseRequests;
using Business.Dtos.Requests.ClassroomRequests;
using Business.Dtos.Responses.ClasroomResponses;
using Business.Dtos.Responses.ClassroomGroupCourseResponses;
using Business.Dtos.Responses.ClassroomResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ClassroomGroupServiceProfile:Profile
    {
        public ClassroomGroupServiceProfile()
        {
            CreateMap<CreateClassroomGroupCourseRequest, ClassroomGroupCourse>();
            CreateMap<ClassroomGroupCourse, CreatedClassroomGroupCourseResponse>();

            //CreateMap<ClassroomGroupCourse, GetClassroomGroupCourseListResponse>()
            //    .ForMember(destinationMember: p => p.GroupName, memberOptions: opt => opt.MapFrom(p => p.Group.Name));
            //CreateMap<Paginate<ClassroomGroupCourse>, Paginate<GetClassroomGroupCourseListResponse>>();

            CreateMap<UpdateClassroomGroupCourseRequest, ClassroomGroupCourse>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<ClassroomGroupCourse, UpdatedClassroomGroupCourseResponse>();

        }
    }
}
