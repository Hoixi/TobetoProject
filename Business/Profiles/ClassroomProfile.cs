using AutoMapper;
using Business.Dtos.Requests.ClassroomRequests;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Responses.ClasroomResponses;
using Business.Dtos.Responses.ClassroomResponses;
using Business.Dtos.Responses.CourseResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles;

public class ClassroomProfile : Profile
{
    public ClassroomProfile()
    {
        CreateMap<CreateClassroomRequest, Classroom>();
        CreateMap<Classroom, CreatedClassroomResponse>();

        CreateMap<Classroom, GetClassroomListResponse>()
            .ForMember(destinationMember: p => p.GroupName, memberOptions: opt => opt.MapFrom(p => p.Group.GroupName));
        CreateMap<Paginate<Classroom>, Paginate<GetClassroomListResponse>>(); 

        CreateMap<UpdateClassroomRequest, Classroom>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
        CreateMap<Classroom, UpdatedClassroomResponse>();



    }
}

