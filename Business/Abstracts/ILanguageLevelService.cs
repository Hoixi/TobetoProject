using Business.Dtos.Requests.LanguageLevelRequests;
using Business.Dtos.Responses.LanguageLevelResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ILanguageLevelService
{
    Task<CreatedLanguageLevelResponse> AddAsync(CreateLanguageLevelRequest createLanguageLevelRequest);
    Task<UpdatedLanguageLevelResponse> UpdateAsync(UpdateLanguageLevelRequest updateLanguageLevelRequest);
    Task<LanguageLevel> DeleteAsync(int id);
    Task<IPaginate<GetListLanguageLevelResponse>> GetAllAsync(PageRequest pageRequest);
}

