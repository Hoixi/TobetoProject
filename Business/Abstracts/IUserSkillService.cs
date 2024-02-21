using Business.Dtos.Requests.UserSkillRequests;
using Business.Dtos.Responses.UserSkillResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IUserSkillService
    {
        Task<CreatedUserSkillResponse> AddAsync(CreateUserSkillRequest createUserSkillRequest);
        Task<UpdatedUserSkillResponse> UpdateAsync(UpdateUserSkillRequest updateUserSkillRequest);
        Task<UserSkill> DeleteAsync(int id);
        Task<IPaginate<GetListUserSkillResponse>> GetAllAsync(PageRequest pageRequest);
        Task<GetListUserSkillResponse> GetById(int id);
        Task<IPaginate<GetListUserSkillResponse>> GetByUserId(PageRequest pageRequest, int userId);
    }
}