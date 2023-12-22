using AutoMapper;
using Business.Dtos.Requests.UserLanguageRequests;
using Business.Dtos.Responses.UserLanguageResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserLanguageProfile : Profile
    {
        public UserLanguageProfile()

        {
            CreateMap<CreateUserLanguageRequest, UserLanguage>();
            CreateMap<UserLanguage, CreatedUserLanguageResponse>();


            CreateMap<UserLanguage, GetListUserLanguageResponse>()
                .ForMember(dest => dest.LanguageName, opt => opt.MapFrom(src => src.Language.Name))
                .ForMember(dest => dest.LanguageLevelId, opt => opt.MapFrom(src => src.LanguageLevel.Name))
                .ReverseMap(); ;
            CreateMap<Paginate<UserLanguage>, Paginate<GetListUserLanguageResponse>>();

            CreateMap<UpdateUserLanguageRequest, UserLanguage>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<UserLanguage, UpdatedUserLanguageResponse>();
        }
    }
}
