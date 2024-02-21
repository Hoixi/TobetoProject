using Business.Dtos.Requests.CourseSubTypeRequests;
using Business.Dtos.Responses.CourseSubTypeResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ICourseSubTypeService
{
    Task<CreatedCourseSubTypeResponse> AddAsync(CreateCourseSubTypeRequest createCourseSubTypeRequest);
    Task<UpdatedCourseSubTypeResponse> UpdateAsync(UpdateCourseSubTypeRequest updateCourseSubTypeRequest);
    Task<CourseSubType> DeleteAsync(int id);
    Task<IPaginate<GetListCourseSubTypeResponse>> GetAllAsync(PageRequest pageRequest);
    Task<GetListCourseSubTypeResponse> GetById(int id);

}
