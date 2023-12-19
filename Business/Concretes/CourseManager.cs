using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Responses.CourseResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

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

        public async Task<CreatedCourseResponse> AddAsync(CreateCourseRequest createCourseRequest)
        {
            Course course = _mapper.Map<Course>(createCourseRequest);
            Course createdCourse = await _courseDal.AddAsync(course);
            CreatedCourseResponse createdCourseResponse = _mapper.Map<CreatedCourseResponse>(createdCourse);
            return createdCourseResponse;
        }

        public async Task<Course> DeleteAsync(int id)
        {
            var data = await _courseDal.GetAsync(i => i.Id == id);
            var result = await _courseDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListCourseResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _courseDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListCourseResponse>>(data);
            return result;
        }

        public async Task<UpdatedCourseResponse> UpdateAsync(UpdateCourseRequest updateCourseRequest)
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
