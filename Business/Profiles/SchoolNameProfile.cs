using AutoMapper;
using Business.Dtos.Requests.SchoolNameRequests;
using Business.Dtos.Responses.SchoolNameResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class SchoolNameProfile : Profile
    {
        public SchoolNameProfile()

        {
            CreateMap<CreateSchoolNameRequest, SchoolName>();
            CreateMap<SchoolName, CreatedSchoolNameResponse>();


            CreateMap<SchoolName, GetListSchoolNameResponse>().ReverseMap();
            CreateMap<Paginate<SchoolName>, Paginate<GetListSchoolNameResponse>>();

            CreateMap<UpdateSchoolNameRequest, SchoolName>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<SchoolName, UpdatedSchoolNameResponse>();
        }
    }
}
