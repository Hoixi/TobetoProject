using Business.Dtos.Requests.ExperienceRequests;
using Business.Dtos.Responses.ExperienceResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IExperienceService
{
    Task<CreatedExperienceResponse> AddAsync(CreateExperienceRequest createExperienceRequest);
    Task<UpdatedExperienceResponse> UpdateAsync(UpdateExperienceRequest updateExperienceRequest);
    Task<Experience> DeleteAsync(int id);
    Task<IPaginate<GetListExperienceResponse>> GetAllAsync(PageRequest pageRequest);
    Task<GetListExperienceResponse> GetById(int id);
    Task<IPaginate<GetListExperienceResponse>> GetByUserId(PageRequest pageRequest, int userId);
}

