using AutoMapper;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Requests.InstructorRequests;
using Business.Dtos.Responses.CourseResponses;
using Business.Dtos.Responses.InstructorResponse;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class InstructorProfile : Profile
    {
        public InstructorProfile()
        {
            CreateMap<CreateInstructorRequest, Instructor>();
            CreateMap<Instructor, CreatedInstructorResponse>();

            CreateMap<UpdateInstructorRequest, Instructor>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Instructor, UpdatedInstructorResponse>();

            CreateMap<Instructor, GetInstructorListResponse>()
                .ForMember(destinationMember: p => p.CourseName, memberOptions: opt => opt.MapFrom(p => p.Course))
                .ForMember(destinationMember: p => p.FirstName, memberOptions: opt => opt.MapFrom(p => p.User));
            CreateMap<Paginate<Instructor>, Paginate<GetInstructorListResponse>>().ReverseMap();

        }
    }
}
