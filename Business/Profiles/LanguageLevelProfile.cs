using AutoMapper;
using Business.Dtos.Requests.LanguageLevelRequests;
using Business.Dtos.Responses.LanguageLevelResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class LanguageLevelProfile : Profile
    {
        public LanguageLevelProfile()

        {
            CreateMap<CreateLanguageLevelRequest, LanguageLevel>();
            CreateMap<LanguageLevel, CreatedLanguageLevelResponse>();


            CreateMap<LanguageLevel, GetListLanguageLevelResponse>().ReverseMap();
            CreateMap<Paginate<LanguageLevel>, Paginate<GetListLanguageLevelResponse>>();

            CreateMap<UpdateLanguageLevelRequest, LanguageLevel>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<LanguageLevel, UpdatedLanguageLevelResponse>();
        }
    }
}
