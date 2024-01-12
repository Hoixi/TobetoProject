using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CategoryRequests;
using Business.Dtos.Responses.CategoryResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        IMapper _mapper;

        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }

        public async Task<CreatedCategoryResponse> AddAsync(CreateCategoryRequest createCategoryRequest)
        {
            Category category = _mapper.Map<Category>(createCategoryRequest);
            Category createdCategory = await _categoryDal.AddAsync(category);
            CreatedCategoryResponse createdCategoryResponse = _mapper.Map<CreatedCategoryResponse>(createdCategory);
            return createdCategoryResponse;
        }

        public async Task<Category> DeleteAsync(int id)
        {
            var data = await _categoryDal.GetAsync(i => i.Id == id);
            var result = await _categoryDal.DeleteAsync(data);
            return result;
        }
        
        public async Task<IPaginate<GetListCategoryResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _categoryDal.GetListAsync(
               index: pageRequest.PageIndex,
               size: pageRequest.PageSize
              );
            var result = _mapper.Map<Paginate<GetListCategoryResponse>>(data);
            return result;
        }

        public async Task<UpdatedCategoryResponse> UpdateAsync(UpdateCategoryRequest updateCategoryRequest)
        {
            var data = await _categoryDal.GetAsync(i => i.Id == updateCategoryRequest.Id);
            _mapper.Map(updateCategoryRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _categoryDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedCategoryResponse>(data);
            return result;
        }
        public async Task<CreatedCategoryResponse> GetById(int id)
        {
            var data = await _categoryDal.GetAsync(c => c.Id == id);
            var result = _mapper.Map<CreatedCategoryResponse>(data);
            return result;
        }
    }
}
