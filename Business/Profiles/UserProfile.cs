using AutoMapper;
using Business.Dtos.Requests.UserRequests;
using Business.Dtos.Responses.CertificateResponses;
using Business.Dtos.Responses.UserLanguageResponses;
using Business.Dtos.Responses.UserResponses;
using Business.Dtos.Responses.UserSocialMediaResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()

        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, CreatedUserResponse>();

            CreateMap<Certificate, GetListCertificateResponse>();

            CreateMap<UserLanguage, GetListUserLanguageResponse>();
            

            CreateMap<UserSocialMedia, GetListUserSocialMediaResponse>();
            CreateMap<User, GetListUserResponse>()
                /*.ForMember(dest => dest.Certificates, opt => opt.MapFrom(src => src.Certificates))*/
                .ForMember(dest => dest.UserSocialMedias, opt => opt.MapFrom(src => src.UserSocialMedias))
                .ForMember(dest => dest.UserLanguages, opt => opt.MapFrom(src => src.UserLanguages))
                .ReverseMap();

            CreateMap<Paginate<User>, Paginate<GetListUserResponse>>();

            CreateMap<UpdateUserRequest, User>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<User, UpdatedUserResponse>();
        }
    }
}
