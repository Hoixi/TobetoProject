using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Responses.CourseResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ICourseService
{
    Task<CreatedCourseResponse> AddAsync(CreateCourseRequest createCourseRequest);
    Task<UpdatedCourseResponse> UpdateAsync(UpdateCourseRequest updateCourseRequest);
    Task<Course> DeleteAsync(int id);
    Task<IPaginate<GetListCourseResponse>> GetAllAsync(PageRequest pageRequest);
}


