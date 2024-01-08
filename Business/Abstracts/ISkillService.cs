using Business.Dtos.Requests.SkillRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.SkillResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ISkillService
    {
        Task<CreatedSkillResponse> AddAsync(CreateSkillRequest createSkillRequest);
        Task<UpdatedSkillResponse> UpdateAsync(UpdateSkillRequest updateSkillRequest);
        Task<Skill> DeleteAsync(int id);
        Task<IPaginate<GetListSkillResponse>> GetAllAsync(PageRequest pageRequest);
        Task<CreatedSkillResponse> GetById(int id);
    }
}
