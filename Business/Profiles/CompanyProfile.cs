using AutoMapper;
using Business.Dtos.Requests.CompanyRequests;
using Business.Dtos.Responses.CompanyResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()

        {
            CreateMap<CreateCompanyRequest, Company>();
            CreateMap<Company, CreatedCompanyResponse>();


            CreateMap<Company, GetListCompanyResponse>().ReverseMap();
            CreateMap<Paginate<Company>, Paginate<GetListCompanyResponse>>();

            CreateMap<UpdateCompanyRequest, Company>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Company, UpdatedCompanyResponse>();
        }
    }
}
