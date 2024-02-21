using Business.Dtos.Requests.EducationDegreeRequests;
using Business.Dtos.Responses.EducationDegreeResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IEducationDegreeService
{
    Task<CreatedEducationDegreeResponse> AddAsync(CreateEducationDegreeRequest createEducationDegreeRequest);
    Task<UpdatedEducationDegreeResponse> UpdateAsync(UpdateEducationDegreeRequest updateEducationDegreeRequest);
    Task<EducationDegree> DeleteAsync(int id);
    Task<IPaginate<GetListEducationDegreeResponse>> GetAllAsync(PageRequest pageRequest);
    Task<GetListEducationDegreeResponse> GetById(int id);
}

