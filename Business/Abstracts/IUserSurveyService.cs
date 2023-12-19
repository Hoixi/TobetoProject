using Business.Dtos.Requests.UserServeyRequests;
using Business.Dtos.Responses.UserServeyResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserSurveyService
    {
        Task<CreatedUserSurveyResponse> AddAsync(CreateUserSurveyRequest createUserSurveyRequest);
        Task<UpdatedUserSurveyResponse> UpdateAsync(UpdateUserSurveyRequest updateUserSurveyRequest);
        Task<UserSurvey> DeleteAsync(int id);
        Task<IPaginate<GetListUserSurveyResponse>> GetAllAsync(PageRequest pageRequest);

    }
}
