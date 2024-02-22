using AutoMapper;
using Business.Dtos.Requests.BadgeRequests;
using Business.Dtos.Responses.BadgeResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class BadgeProfile : Profile
    {
        public BadgeProfile()
        {
            CreateMap<CreateBadgeRequest, Badge>();
            CreateMap<Badge, CreatedBadgeResponse>();


            CreateMap<Badge, GetListBadgeResponse>()
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.Image.Path))
                .ForMember(dest => dest.ImageName, opt => opt.MapFrom(src => src.Image.Name))
                .ReverseMap();
            CreateMap<Paginate<Badge>, Paginate<GetListBadgeResponse>>();

            CreateMap<UpdateBadgeRequest, Badge>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Badge, UpdatedBadgeResponse>();
        }
    }
}
