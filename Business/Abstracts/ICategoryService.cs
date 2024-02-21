using Business.Dtos.Requests.CategoryRequests;
using Business.Dtos.Responses.CategoryResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ICategoryService
{
    Task<CreatedCategoryResponse> AddAsync(CreateCategoryRequest createCategoryRequest);
    Task<UpdatedCategoryResponse> UpdateAsync(UpdateCategoryRequest updateCategoryRequest);
    Task<Category> DeleteAsync(int id);
    Task<IPaginate<GetListCategoryResponse>> GetAllAsync(PageRequest pageRequest);
    Task<GetListCategoryResponse> GetById(int id);
}
