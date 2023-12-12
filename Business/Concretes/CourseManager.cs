using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Responses.CourseResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
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

        public Task<CreatedCourseResponse> Delete(Course course)
        {
            throw new NotImplementedException();
        }

        public Task<IPaginate<GetCourseListResponse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CreatedCourseResponse> GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CreatedCourseResponse> Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
