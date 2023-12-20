using AutoMapper;
using Business.Dtos.Requests.ProgrammingLanguageRequests;
using Business.Dtos.Responses.ProgrammingLanguageResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ProgrammingLanguageProfile : Profile
    {
        public ProgrammingLanguageProfile()

        {
            CreateMap<CreateProgrammingLanguageRequest, ProgrammingLanguage>();
            CreateMap<ProgrammingLanguage, CreatedProgrammingLanguageResponse>();


            CreateMap<ProgrammingLanguage, GetListProgrammingLanguageResponse>().ReverseMap();
            CreateMap<Paginate<ProgrammingLanguage>, Paginate<GetListProgrammingLanguageResponse>>();

            CreateMap<UpdateProgrammingLanguageRequest, ProgrammingLanguage>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<ProgrammingLanguage, UpdatedProgrammingLanguageResponse>();
        }
    }
}
