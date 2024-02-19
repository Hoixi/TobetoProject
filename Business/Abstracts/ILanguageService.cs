using Business.Dtos.Requests.LanguageRequests;
using Business.Dtos.Responses.LanguageResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ILanguageService
{
    Task<CreatedLanguageResponse> AddAsync(CreateLanguageRequest createLanguageRequest);
    Task<UpdatedLanguageResponse> UpdateAsync(UpdateLanguageRequest updateLanguageRequest);
    Task<Language> DeleteAsync(int id);
    Task<IPaginate<GetListLanguageResponse>> GetAllAsync(PageRequest pageRequest);
    Task<GetListLanguageResponse> GetById(int id);

}

