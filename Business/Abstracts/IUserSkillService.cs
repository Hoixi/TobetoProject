using Business.Dtos.Requests.UserSkillRequests;
using Business.Dtos.Responses.UserSkillResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserSkillService
    {
        Task<CreatedUserSkillResponse> Add(CreateUserSkillRequest createUserSkillRequest);
        Task<UpdatedUserSkillResponse> Update(UpdateUserSkillRequest updateUserSkillRequest);
        Task<UserSkill> Delete(int id);
        Task<IPaginate<GetListUserSkillResponse>> GetAll(PageRequest pageRequest);
    }
}