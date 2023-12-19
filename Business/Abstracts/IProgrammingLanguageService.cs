using Business.Dtos.Requests.ProgrammingLanguageRequests;
using Business.Dtos.Responses.ProgrammingLanguageResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IProgrammingLanguageService
    {
        Task<CreatedProgrammingLanguageResponse> Add(CreateProgrammingLanguageRequest createProgrammingLanguageRequest);
        Task<UpdatedProgrammingLanguageResponse> Update(UpdateProgrammingLanguageRequest updateProgrammingLanguageRequest);
        Task<ProgrammingLanguage> Delete(int id);
        Task<IPaginate<GetListProgrammingLanguageResponse>> GetAll(PageRequest pageRequest);
    }
}
