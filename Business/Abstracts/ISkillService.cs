using Business.Dtos.Requests.SkillRequests;
using Business.Dtos.Responses.SkillResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ISkillService
    {
        Task<CreatedSkillResponse> AddAsync(CreateSkillRequest createSkillRequest);
        Task<UpdatedSkillResponse> UpdateAsync(UpdateSkillRequest updateSkillRequest);
        Task<Skill> DeleteAsync(int id);
        Task<IPaginate<GetListSkillResponse>> GetAllAsync(PageRequest pageRequest);
        Task<GetListSkillResponse> GetById(int id);
    }
}
