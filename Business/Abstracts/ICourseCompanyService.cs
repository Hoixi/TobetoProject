using Business.Dtos.Requests.CourseCompanyRequests;
using Business.Dtos.Responses.ClassroomInstructorResponses;
using Business.Dtos.Responses.CourseCategoryResponses;
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
    Task<CreatedCourseCompanyResponse> GetById(int id);
    Task<IPaginate<GetListCourseCompanyResponse>> GetListByCourseId(int courseId, PageRequest pageRequest);
    Task<IPaginate<GetListCourseCompanyResponse>> GetListByCompanyId(int companyId, PageRequest pageRequest);
}


