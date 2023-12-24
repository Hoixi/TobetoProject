using AutoMapper;
using Business.Dtos.Requests.InstructorRequests;
using Business.Dtos.Responses.InstructorResponses;
using Business.Dtos.Responses.UserResponses;
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

            CreateMap<User, GetListUserResponse>();

            CreateMap<Instructor, GetListInstructorResponse>()
                .ForMember(dest => dest.InstructorName, opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}"))


                .ReverseMap();
            CreateMap<Paginate<Instructor>, Paginate<GetListInstructorResponse>>();

            CreateMap<UpdateInstructorRequest, Instructor>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Instructor, UpdatedInstructorResponse>();
        }
    }
}
