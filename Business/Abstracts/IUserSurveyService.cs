
using Business.Dtos.Requests.UserSurveyRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.UserSurveyResponses;
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
        Task<CreatedUserSurveyResponse> GetById(int id);
    }
}
