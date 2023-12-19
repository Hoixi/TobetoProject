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
        Task<CreatedUserSurveyResponse> Add(CreateUserSurveyRequest createUserSurveyRequest);
        Task<UpdatedUserSurveyResponse> Update(UpdateUserSurveyRequest updateUserSurveyRequest);
        Task<UserSurvey> Delete(int id);
        Task<IPaginate<GetListUserSurveyResponse>> GetAll(PageRequest pageRequest);

    }
}
