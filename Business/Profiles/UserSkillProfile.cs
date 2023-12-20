using AutoMapper;
using Business.Dtos.Requests.UserSkillRequests;
using Business.Dtos.Responses.UserSkillResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserSkillProfile : Profile
    {
        public UserSkillProfile()

        {
            CreateMap<CreateUserSkillRequest, UserSkill>();
            CreateMap<UserSkill, CreatedUserSkillResponse>();


            CreateMap<UserSkill, GetListUserSkillResponse>().ReverseMap();
            CreateMap<Paginate<UserSkill>, Paginate<GetListUserSkillResponse>>();

            CreateMap<UpdateUserSkillRequest, UserSkill>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<UserSkill, UpdatedUserSkillResponse>();
        }
    }
}
