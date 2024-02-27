using Business.Dtos.Requests.EducationRequests;
using Business.Dtos.Responses.EducationResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IEducationService
{
    Task<CreatedEducationResponse> AddAsync(CreateEducationRequest createEducationRequest);
    Task<UpdatedEducationResponse> UpdateAsync(UpdateEducationRequest updateEducationRequest);
    Task<Education> DeleteAsync(int id);
    Task<IPaginate<GetListEducationResponse>> GetAllAsync(PageRequest pageRequest);
    Task<GetListEducationResponse> GetById(int id);
    Task<GetListEducationResponse> GetByUserId(int userId);
  

}
