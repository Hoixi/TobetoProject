using AutoMapper;
using Business.Dtos.Requests.UserOperationClaimRequests;
using Business.Dtos.Requests.UserSkillRequests;
using Business.Dtos.Responses.UserOperationClaimResponses;
using Business.Dtos.Responses.UserSkillResponses;
using Core.DataAccess.Paging;
using Core.Entities.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserOperationClaimProfile:Profile
    {
        public UserOperationClaimProfile()
        {
            CreateMap<CreateUserOperationClaimRequest, UserOperationClaim>();
            CreateMap<UserOperationClaim, CreatedUserOperationClaimResponse>();


            CreateMap<UserOperationClaim, GetListUserOperationClaimResponse>().ReverseMap();
            CreateMap<Paginate<UserOperationClaim>, Paginate<GetListUserOperationClaimResponse>>();

            CreateMap<UpdateUserOperationClaimRequest, UserOperationClaim>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<UserOperationClaim, UpdatedUserOperationClaimResponse>();
        }
    }
}
