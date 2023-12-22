using AutoMapper;
using Business.Dtos.Requests.ExperienceRequests;
using Business.Dtos.Responses.ExperienceResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ExperienceProfile : Profile
    {
        public ExperienceProfile()

        {
            CreateMap<CreateExperienceRequest, Experience>();
            CreateMap<Experience, CreatedExperienceResponse>();

            CreateMap<Experience, GetListExperienceResponse>()
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City.Name))
                .ReverseMap();
            CreateMap<Paginate<Experience>, Paginate<GetListExperienceResponse>>();

            CreateMap<UpdateExperienceRequest, Experience>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Experience, UpdatedExperienceResponse>();
        }
    }

}
