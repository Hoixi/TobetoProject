using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CountryRequests;
using Business.Dtos.Requests.CourseSubTypeRequests;
using Business.Dtos.Responses.CountryResponses;
using Business.Dtos.Responses.CourseSubTypeResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseSubTypeManager : ICourseSubTypeService
    {
        ICourseSubTypeDal _courseSubTypeDal;
        IMapper _mapper;

        public CourseSubTypeManager(ICourseSubTypeDal courseSubTypeDal, IMapper mapper)
        {
            _courseSubTypeDal = courseSubTypeDal;
            _mapper = mapper;
        }

        public async Task<CreatedCourseSubTypeResponse> AddAsync(CreateCourseSubTypeRequest createCourseSubTypeRequest)
        {
            CourseSubType courseSubType = _mapper.Map<CourseSubType>(createCourseSubTypeRequest);
            CourseSubType createdCourseSubType = await _courseSubTypeDal.AddAsync(courseSubType);
            CreatedCourseSubTypeResponse createdCourseSubTypeResponse = _mapper.Map<CreatedCourseSubTypeResponse>(createdCourseSubType);
            return createdCourseSubTypeResponse;
        }

        public async Task<CourseSubType> DeleteAsync(int id)
        {
            var data = await _courseSubTypeDal.GetAsync(i => i.Id == id);
            var result = await _courseSubTypeDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListCourseSubTypeResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _courseSubTypeDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListCourseSubTypeResponse>>(data);
            return result;
        }

        public async Task<UpdatedCourseSubTypeResponse> UpdateAsync(UpdateCourseSubTypeRequest updateCourseSubTypeRequest)
        {
            var data = await _courseSubTypeDal.GetAsync(i => i.Id == updateCourseSubTypeRequest.Id);
            _mapper.Map(updateCourseSubTypeRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _courseSubTypeDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedCourseSubTypeResponse>(data);
            return result;
        }
    }
}
