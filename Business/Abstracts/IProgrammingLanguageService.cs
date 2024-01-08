using Business.Dtos.Requests.ProgrammingLanguageRequests;
using Business.Dtos.Responses.LanguageResponses;
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
        Task<CreatedProgrammingLanguageResponse> AddAsync(CreateProgrammingLanguageRequest createProgrammingLanguageRequest);
        Task<UpdatedProgrammingLanguageResponse> UpdateAsync(UpdateProgrammingLanguageRequest updateProgrammingLanguageRequest);
        Task<ProgrammingLanguage> DeleteAsync(int id);
        Task<IPaginate<GetListProgrammingLanguageResponse>> GetAllAsync(PageRequest pageRequest);
        Task<CreatedProgrammingLanguageResponse> GetById(int id);

    }
}
