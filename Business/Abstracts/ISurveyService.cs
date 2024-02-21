using Business.Dtos.Requests.SurveyRequests;
using Business.Dtos.Responses.SurveyResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ISurveyService
    {
        Task<CreatedSurveyResponse> AddAsync(CreateSurveyRequest createSurveyRequest);
        Task<UpdatedSurveyResponse> UpdateAsync(UpdateSurveyRequest updateSurveyRequest);
        Task<Survey> DeleteAsync(int id);
        Task<IPaginate<GetListSurveyResponse>> GetAllAsync(PageRequest pageRequest);
        Task<GetListSurveyResponse> GetById(int id);
    }
}
