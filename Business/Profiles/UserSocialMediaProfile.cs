using AutoMapper;
using Business.Dtos.Requests.UserSocialMediaRequests;
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
    public class UserSocialMediaProfile : Profile
    {
        public UserSocialMediaProfile()

        {
            CreateMap<CreateUserSocialMediaRequest, UserSocialMedia>();
            CreateMap<UserSocialMedia, CreatedUserSocialMediaResponse>();


            CreateMap<UserSocialMedia, GetListUserSocialMediaResponse>()
                .ForMember(dest => dest.SocialMediaName, opt => opt.MapFrom(src => src.SocialMedia.Name))
                .ReverseMap();
            CreateMap<Paginate<UserSocialMedia>, Paginate<GetListUserSocialMediaResponse>>();

            CreateMap<UpdateUserSocialMediaRequest, UserSocialMedia>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<UserSocialMedia, UpdatedUserSocialMediaResponse>();
        }
    }
}
