using Business.Dtos.Requests.UserLanguageRequests;
using Business.Dtos.Responses.UserLanguageResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IUserLanguageService
    {
        Task<CreatedUserLanguageResponse> AddAsync(CreateUserLanguageRequest createUserLanguageRequest);
        Task<UpdatedUserLanguageResponse> UpdateAsync(UpdateUserLanguageRequest updateUserLanguageRequest);
        Task<UserLanguage> DeleteAsync(int id);
        Task<IPaginate<GetListUserLanguageResponse>> GetAllAsync(PageRequest pageRequest);
        Task<GetListUserLanguageResponse> GetById(int id);
        Task<IPaginate<GetListUserLanguageResponse>> GetByUserId(PageRequest pageRequest, int userId);
    }
}