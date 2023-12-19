using Business.Dtos.Requests.SkillRequests;
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
        Task<CreatedSkillResponse> Add(CreateSkillRequest createSkillRequest);
        Task<UpdatedSkillResponse> Update(UpdateSkillRequest updateSkillRequest);
        Task<Skill> Delete(int id);
        Task<IPaginate<GetListSkillResponse>> GetAll(PageRequest pageRequest);
    }
}
