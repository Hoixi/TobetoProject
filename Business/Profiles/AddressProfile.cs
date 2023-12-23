using AutoMapper;
using Business.Dtos.Requests.AddressRequests;
using Business.Dtos.Responses.AddressResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()

        {
            CreateMap<CreateAddressRequest, Address>();
            CreateMap<Address, CreatedAddressResponse>();


            CreateMap<Address, GetListAddressResponse>()
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City.Name))
                .ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => src.Country.Name))
                .ForMember(dest => dest.TownName , opt => opt.MapFrom(src => src.Town.Name))
                .ReverseMap();
            CreateMap<Paginate<Address>, Paginate<GetListAddressResponse>>();

            CreateMap<UpdateAddressRequest, Address>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Address, UpdatedAddressResponse>();
        }
    }
}
