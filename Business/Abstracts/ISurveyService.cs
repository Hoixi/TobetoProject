using Business.Dtos.Requests.SurveyRequests;
using Business.Dtos.Responses.SurveyResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ISurveyService
    {
        Task<CreatedSurveyResponse> Add(CreateSurveyRequest createSurveyRequest);
        Task<UpdatedSurveyResponse> Update(UpdateSurveyRequest updateSurveyRequest);
        Task<Survey> Delete(int id);
        Task<IPaginate<GetListSurveyResponse>> GetAll(PageRequest pageRequest);
    }
}
