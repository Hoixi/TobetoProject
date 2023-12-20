using AutoMapper;
using Business.Dtos.Requests.LanguageRequests;
using Business.Dtos.Responses.LanguageResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class LanguageProfile : Profile
    {
        public LanguageProfile()

        {
            CreateMap<CreateLanguageRequest, Language>();
            CreateMap<Language, CreatedLanguageResponse>();


            CreateMap<Language, GetListLanguageResponse>().ReverseMap();
            CreateMap<Paginate<Language>, Paginate<GetListLanguageResponse>>();

            CreateMap<UpdateLanguageRequest, Language>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Language, UpdatedLanguageResponse>();
        }
    }
}
