using AutoMapper;
using Business.Dtos.Requests.EducationRequests;
using Business.Dtos.Responses.EducationResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class EducationProfile : Profile
    {
        public EducationProfile()

        {
            CreateMap<CreateEducationRequest, Education>();
            CreateMap<Education, CreatedEducationResponse>();


            CreateMap<Education, GetListEducationResponse>().ReverseMap();
            CreateMap<Paginate<Education>, Paginate<GetListEducationResponse>>();

            CreateMap<UpdateEducationRequest, Education>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Education, UpdatedEducationResponse>();
        }
    }
}
