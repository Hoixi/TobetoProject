using AutoMapper;
using Business.Dtos.Requests.TownRequests;
using Business.Dtos.Responses.TownResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class TownProfile : Profile
    {
        public TownProfile()

        {
            CreateMap<CreateTownRequest, Town>();
            CreateMap<Town, CreatedTownResponse>();


            CreateMap<Town, GetListTownResponse>().ReverseMap();
            CreateMap<Paginate<Town>, Paginate<GetListTownResponse>>();

            CreateMap<UpdateTownRequest, Town>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Town, UpdatedTownResponse>();
        }
    }
}
