using AutoMapper;
using Business.Dtos.Requests.CountryRequests;
using Business.Dtos.Responses.CountryResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()

        {
            CreateMap<CreateCountryRequest, Country>();
            CreateMap<Country, CreatedCountryResponse>();


            CreateMap<Country, GetListCountryResponse>().ReverseMap();
            CreateMap<Paginate<Country>, Paginate<GetListCountryResponse>>();

            CreateMap<UpdateCountryRequest, Country>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Country, UpdatedCountryResponse>();
        }
    }
}
