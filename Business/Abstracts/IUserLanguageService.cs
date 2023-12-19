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
    internal interface IUserLanguageService
    {
        Task<CreatedUserLanguageResponse> Add(CreateUserLanguageRequest createUserLanguageRequest);
        Task<UpdatedUserLanguageResponse> Update(UpdateUserLanguageRequest updateUserLanguageRequest);
        Task<UserLanguage> Delete(int id);
        Task<IPaginate<GetListUserLanguageResponse>> GetAll(PageRequest pageRequest);
    }
}