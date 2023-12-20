using AutoMapper;
using Business.Dtos.Requests.ImageRequests;
using Business.Dtos.Responses.ImageResponses;
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


            CreateMap<Image, GetListImageResponse>().ReverseMap();
            CreateMap<Paginate<Image>, Paginate<GetListImageResponse>>();

            CreateMap<UpdateImageRequest, Image>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Image, UpdatedImageResponse>();
        }
    }
}
