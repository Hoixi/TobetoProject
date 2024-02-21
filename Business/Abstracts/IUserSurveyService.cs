
using Business.Dtos.Requests.UserSurveyRequests;
using Business.Dtos.Responses.UserSurveyResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IUserSurveyService
    {
        Task<CreatedUserSurveyResponse> AddAsync(CreateUserSurveyRequest createUserSurveyRequest);
        Task<UpdatedUserSurveyResponse> UpdateAsync(UpdateUserSurveyRequest updateUserSurveyRequest);
        Task<UserSurvey> DeleteAsync(int id);
        Task<IPaginate<GetListUserSurveyResponse>> GetAllAsync(PageRequest pageRequest);
        Task<GetListUserSurveyResponse> GetById(int id);
        Task<IPaginate<GetListUserSurveyResponse>> GetByUserId(PageRequest pageRequest, int userId);
    }
}
