using AutoMapper;
using Business.Dtos.Requests.SocialMediaRequests;
using Business.Dtos.Responses.SocialMediaResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class SocialMediaProfile : Profile
    {
        public SocialMediaProfile()

        {
            CreateMap<CreateSocialMediaRequest, SocialMedia>();
            CreateMap<SocialMedia, CreatedSocialMediaResponse>();


            CreateMap<SocialMedia, GetListSocialMediaResponse>().ReverseMap();
            CreateMap<Paginate<SocialMedia>, Paginate<GetListSocialMediaResponse>>();

            CreateMap<UpdateSocialMediaRequest, SocialMedia>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<SocialMedia, UpdatedSocialMediaResponse>();
        }
    }
}
