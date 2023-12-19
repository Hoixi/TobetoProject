using Business.Dtos.Requests.CourseCompanyRequests;
using Business.Dtos.Responses.CourseCompanyResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ICourseCompanyService
{
    Task<CreatedCourseCompanyResponse> AddAsync(CreateCourseCompanyRequest createCourseCompanyRequest);
    Task<UpdatedCourseCompanyResponse> UpdateAsync(UpdateCourseCompanyRequest updateCourseCompanyRequest);
    Task<CourseCompany> DeleteAsync(int id);
    Task<IPaginate<GetListCourseCompanyResponse>> GetAllAsync(PageRequest pageRequest);
}


