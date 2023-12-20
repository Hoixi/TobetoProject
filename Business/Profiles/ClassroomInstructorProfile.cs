using AutoMapper;
using Business.Dtos.Requests.ClassroomInstructorRequests;
using Business.Dtos.Responses.ClassroomInstructorResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ClassroomInstructorProfile : Profile
    {
        public ClassroomInstructorProfile()

        {
            CreateMap<CreateClassroomInstructorRequest, ClassroomInstructor>();
            CreateMap<ClassroomInstructor, CreatedClassroomInstructorResponse>();


            CreateMap<ClassroomInstructor, GetListClassroomInstructorResponse>().ReverseMap();
            CreateMap<Paginate<ClassroomInstructor>, Paginate<GetListClassroomInstructorResponse>>();

            CreateMap<UpdateClassroomInstructorRequest, ClassroomInstructor>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<ClassroomInstructor, UpdatedClassroomInstructorResponse>();
        }
    }
}