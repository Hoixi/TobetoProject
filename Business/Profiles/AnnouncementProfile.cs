using AutoMapper;
using Business.Dtos.Requests.AnnouncementRequests;
using Business.Dtos.Responses.AnnouncementResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class AnnouncementProfile : Profile
    {
        public AnnouncementProfile()

        {
            CreateMap<CreateAnnouncementRequest, Announcement>();
            CreateMap<Announcement, CreatedAnnouncementResponse>();


            CreateMap<Announcement, GetListAnnouncementResponse>().ReverseMap();
            CreateMap<Paginate<Announcement>, Paginate<GetListAnnouncementResponse>>();

            CreateMap<UpdateAnnouncementRequest, Announcement>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Announcement, UpdatedAnnouncementResponse>();
        }
    }
}
