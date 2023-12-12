using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Requests.RoleRequests;
using Business.Dtos.Responses.CourseResponses;
using Business.Dtos.Responses.RoleResponses;
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
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        IMapper _mapper;
        public CourseManager(ICourseDal courseDal, IMapper mapper)
        {
            _courseDal = courseDal;
            _mapper = mapper;
        }

        public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
        {
            Course course = _mapper.Map<Course>(createCourseRequest);
            Course createdCourse = await _courseDal.AddAsync(course);
            CreatedCourseResponse createdCourseResponse = _mapper.Map<CreatedCourseResponse>(createdCourse);
            return createdCourseResponse;
        }

        public async Task<Course> Delete(int Id, bool permanent)
        {
            var data = await _courseDal.GetAsync(i => i.Id == Id);
            var result = await _courseDal.DeleteAsync(data, permanent);
            return result;
        }

        public async Task<IPaginate<GetCourseListResponse>> GetAll()
        {
            var data = await _courseDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetCourseListResponse>>(data);
            return result;
        }

        public async Task<CreatedCourseResponse> GetCourseById(int id)
        {
            var data = await _courseDal.GetAsync(i => i.Id == id);
            var result = _mapper.Map<CreatedCourseResponse>(data);
            return result;
        }

        public async Task<UpdatedCourseResponse> Update(UpdateCourseRequest updateCourseRequest)
        {
            var data = await _courseDal.GetAsync(i => i.Id == updateCourseRequest.Id);
            _mapper.Map(updateCourseRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _courseDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedCourseResponse>(data);
            return result;

        }
    }
}
