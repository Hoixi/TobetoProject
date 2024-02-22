using AutoMapper;
using Business.Dtos.Requests.UserBadgeRequests;
using Business.Dtos.Responses.UserBadgeResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserBadgeProfile : Profile
    {
        public UserBadgeProfile()
        {
            CreateMap<CreateUserBadgeRequest, UserBadge>();
            CreateMap<UserBadge, CreatedUserBadgeResponse>();


            CreateMap<UserBadge, GetListUserBadgeResponse>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}"))
                .ForMember(dest => dest.BadgeName, opt => opt.MapFrom(src => src.Badge.Name))
                .ReverseMap();
            CreateMap<Paginate<UserBadge>, Paginate<GetListUserBadgeResponse>>();

            CreateMap<UpdateUserBadgeRequest, UserBadge>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<UserBadge, UpdatedUserBadgeResponse>();
        }
    }
}
