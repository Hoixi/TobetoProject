using AutoMapper;
using Business.Dtos.Requests.SkillRequests;
using Business.Dtos.Responses.SkillResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class SkillProfile : Profile
    {
        public SkillProfile()

        {
            CreateMap<CreateSkillRequest, Skill>();
            CreateMap<Skill, CreatedSkillResponse>();


            CreateMap<Skill, GetListSkillResponse>().ReverseMap();
            CreateMap<Paginate<Skill>, Paginate<GetListSkillResponse>>();

            CreateMap<UpdateSkillRequest, Skill>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Skill, UpdatedSkillResponse>();
        }
    }

}
