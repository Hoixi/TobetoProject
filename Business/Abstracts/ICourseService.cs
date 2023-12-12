using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Responses.CourseResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest);
        Task<CreatedCourseResponse> Update(Course course);
        Task<CreatedCourseResponse> Delete(Course course);

        Task<IPaginate<GetCourseListResponse>> GetAll();
        Task<CreatedCourseResponse> GetCourseById(int id);
    }
}

