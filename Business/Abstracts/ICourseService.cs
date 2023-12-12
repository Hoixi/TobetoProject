using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Requests.RoleRequests;
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
        Task<UpdatedCourseResponse> Update(UpdateCourseRequest updateCourseRequest);
        Task<Course> Delete(int Id, bool permanent);
        Task<IPaginate<GetCourseListResponse>> GetAll();
        Task<CreatedCourseResponse> GetCourseById(int id);
    }
}

