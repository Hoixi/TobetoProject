using Business.Dtos.Requests.ProgrammingLanguageRequests;
using Business.Dtos.Responses.ProgrammingLanguageResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IProgrammingLanguageService
    {
        Task<CreatedProgrammingLanguageResponse> AddAsync(CreateProgrammingLanguageRequest createProgrammingLanguageRequest);
        Task<UpdatedProgrammingLanguageResponse> UpdateAsync(UpdateProgrammingLanguageRequest updateProgrammingLanguageRequest);
        Task<ProgrammingLanguage> DeleteAsync(int id);
        Task<IPaginate<GetListProgrammingLanguageResponse>> GetAllAsync(PageRequest pageRequest);
        Task<GetListProgrammingLanguageResponse> GetById(int id);

    }
}
