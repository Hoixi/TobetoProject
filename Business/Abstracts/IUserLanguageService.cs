using Business.Dtos.Requests.UserLanguageRequests;
using Business.Dtos.Responses.UserLanguageResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserLanguageService
    {
        Task<CreatedUserLanguageResponse> AddAsync(CreateUserLanguageRequest createUserLanguageRequest);
        Task<UpdatedUserLanguageResponse> UpdateAsync(UpdateUserLanguageRequest updateUserLanguageRequest);
        Task<UserLanguage> DeleteAsync(int id);
        Task<IPaginate<GetListUserLanguageResponse>> GetAllAsync(PageRequest pageRequest);
    }
}