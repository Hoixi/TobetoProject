using AutoMapper;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Requests.ImageRequests;
using Business.Dtos.Responses.CourseResponses;
using Business.Dtos.Responses.ImageResponse;
using Business.Dtos.Responses.RoleResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ImageProfile : Profile
    {
        public ImageProfile()
        {
            CreateMap<CreateImageRequest, Image>();
            CreateMap<Image, CreatedImageResponse>();

            CreateMap<Image, GetImageListResponse>().ReverseMap();
            CreateMap<Paginate<Image>, Paginate<GetImageListResponse>>();

            CreateMap<UpdateImageRequest, Image>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Image, UpdatedImageResponse>();

        }

    }
}
