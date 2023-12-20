using AutoMapper;
using Business.Dtos.Requests.UserAnnouncementRequests;
using Business.Dtos.Responses.UserAnnouncementResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserAnnouncementProfile : Profile
    {
        public UserAnnouncementProfile()

        {
            CreateMap<CreateUserAnnouncementRequest, UserAnnouncement>();
            CreateMap<UserAnnouncement, CreatedUserAnnouncementResponse>();


            CreateMap<UserAnnouncement, GetListUserAnnouncementResponse>().ReverseMap();
            CreateMap<Paginate<UserAnnouncement>, Paginate<GetListUserAnnouncementResponse>>();

            CreateMap<UpdateUserAnnouncementRequest, UserAnnouncement>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<UserAnnouncement, UpdatedUserAnnouncementResponse>();
        }
    }
}
