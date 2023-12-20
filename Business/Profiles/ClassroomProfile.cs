using AutoMapper;
using Business.Dtos.Requests.ClassroomRequests;
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
    public class ClassroomProfile : Profile
    {
        public ClassroomProfile()

        {
            CreateMap<CreateClassroomRequest, Classroom>();
            CreateMap<Classroom, CreatedClassroomResponse>();


            CreateMap<Classroom, GetListClassroomResponse>().ReverseMap();
            CreateMap<Paginate<Classroom>, Paginate<GetListClassroomResponse>>();

            CreateMap<UpdateClassroomRequest, Classroom>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Classroom, UpdatedClassroomResponse>();
        }
    }
}
