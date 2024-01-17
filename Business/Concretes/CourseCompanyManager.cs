using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseCompanyRequests;
using Business.Dtos.Responses.CourseCategoryResponses;
using Business.Dtos.Responses.CourseCompanyResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class CourseCompanyManager : ICourseCompanyService
    {
        ICourseCompanyDal _courseCompanyDal;
        IMapper _mapper;

        public CourseCompanyManager(ICourseCompanyDal courseCompanyDal, IMapper mapper)
        {
            _courseCompanyDal = courseCompanyDal;
            _mapper = mapper;
        }

        public async Task<CreatedCourseCompanyResponse> AddAsync(CreateCourseCompanyRequest createCourseCompanyRequest)
        {
            CourseCompany courseCompany = _mapper.Map<CourseCompany>(createCourseCompanyRequest);
            CourseCompany createdCourseCompany = await _courseCompanyDal.AddAsync(courseCompany);
            CreatedCourseCompanyResponse createdCourseCompanyResponse = _mapper.Map<CreatedCourseCompanyResponse>(createdCourseCompany);
            return createdCourseCompanyResponse;
        }

        public async Task<CourseCompany> DeleteAsync(int id)
        {
            var data = await _courseCompanyDal.GetAsync(i => i.Id == id);
            var result = await _courseCompanyDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListCourseCompanyResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _courseCompanyDal.GetListAsync(
                include: ci => ci
                .Include(cl => cl.Course)
                .Include(c => c.Company),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListCourseCompanyResponse>>(data);
            return result;
        }

        public async Task<CreatedCourseCompanyResponse> GetById(int id)
        {
            var data = await _courseCompanyDal.GetAsync(c => c.Id == id);
            var result = _mapper.Map<CreatedCourseCompanyResponse>(data);
            return result;
        }

        public async Task<UpdatedCourseCompanyResponse> UpdateAsync(UpdateCourseCompanyRequest updateCourseCompanyRequest)
        {
            var data = await _courseCompanyDal.GetAsync(i => i.Id == updateCourseCompanyRequest.Id);
            _mapper.Map(updateCourseCompanyRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _courseCompanyDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedCourseCompanyResponse>(data);
            return result;
        }        
    }
}
