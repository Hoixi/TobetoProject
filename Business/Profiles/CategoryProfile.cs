using AutoMapper;
using Business.Dtos.Requests.CategoryRequests;
using Business.Dtos.Responses.CategoryResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CreateCategoryRequest, Category>();
            CreateMap<Category, CreatedCategoryResponse>();


            CreateMap<Category, GetListCategoryResponse>().ReverseMap();
            CreateMap<Paginate<Category>, Paginate<GetListCategoryResponse>>();

            CreateMap<UpdateCategoryRequest, Category>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Category, UpdatedCategoryResponse>();
        }
    }
}
