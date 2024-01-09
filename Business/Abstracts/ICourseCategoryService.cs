using Business.Dtos.Requests.CourseCategoryRequests;
using Business.Dtos.Responses.CountryResponses;
using Business.Dtos.Responses.CourseCategoryResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ICourseCategoryService
{
    Task<CreatedCourseCategoryResponse> AddAsync(CreateCourseCategoryRequest createCourseCategoryRequest);
    Task<UpdatedCourseCategoryResponse> UpdateAsync(UpdateCourseCategoryRequest updateCourseCategoryRequest);
    Task<CourseCategory> DeleteAsync(int id);
    Task<IPaginate<GetListCourseCategoryResponse>> GetAllAsync(PageRequest pageRequest);
    Task<CreatedCourseCategoryResponse> GetById(int id);

}


