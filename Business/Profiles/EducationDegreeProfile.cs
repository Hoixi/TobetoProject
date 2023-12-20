using AutoMapper;
using Business.Dtos.Requests.EducationDegreeRequests;
using Business.Dtos.Responses.EducationDegreeResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class EducationDegreeProfile : Profile
    {
        public EducationDegreeProfile()

        {
            CreateMap<CreateEducationDegreeRequest, EducationDegree>();
            CreateMap<EducationDegree, CreatedEducationDegreeResponse>();


            CreateMap<EducationDegree, GetListEducationDegreeResponse>().ReverseMap();
            CreateMap<Paginate<EducationDegree>, Paginate<GetListEducationDegreeResponse>>();

            CreateMap<UpdateEducationDegreeRequest, EducationDegree>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<EducationDegree, UpdatedEducationDegreeResponse>();
        }
    }
}
