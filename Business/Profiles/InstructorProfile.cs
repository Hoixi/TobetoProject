using AutoMapper;
using Business.Dtos.Requests.InstructorRequests;
using Business.Dtos.Responses.InstructorResponses;
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


            CreateMap<Instructor, GetListInstructorResponse>().ReverseMap();
            CreateMap<Paginate<Instructor>, Paginate<GetListInstructorResponse>>();

            CreateMap<UpdateInstructorRequest, Instructor>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Instructor, UpdatedInstructorResponse>();
        }
    }
}
