using AutoMapper;
using Business.Dtos.Requests.CityRequests;
using Business.Dtos.Responses.CityResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile()

        {
            CreateMap<CreateCityRequest, City>();
            CreateMap<City, CreatedCityResponse>();


            CreateMap<City, GetListCityResponse>().ReverseMap();
            CreateMap<Paginate<City>, Paginate<GetListCityResponse>>();

            CreateMap<UpdateCityRequest, City>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<City, UpdatedCityResponse>();
        }
    }
}
