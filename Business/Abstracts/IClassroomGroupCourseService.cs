using Business.Dtos.Requests.ClassroomGroupCourseRequest;
using Business.Dtos.Requests.ClassroomGroupCourseRequests;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Responses.ClassroomGroupCourseResponses;
using Business.Dtos.Responses.CourseResponses;
using Business.Dtos.Responses.GroupResponse;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IClassroomGroupCourseService
    {
        Task<CreatedClassroomGroupCourseResponse> Add(CreateClassroomGroupCourseRequest createClassroomGroupCourseRequest);
        Task<UpdatedClassroomGroupCourseResponse> Update(UpdateClassroomGroupCourseRequest updateClassroomGroupCourseRequest);
        Task<ClassroomGroupCourse> Delete(int Id, bool permanent);
        Task<IPaginate<GetClassroomGroupCourseListResponse>> GetAll(PageRequest pageRequest);
        Task<CreatedClassroomGroupCourseResponse> GetClassroomGroupCourseById(int id);
    }
}
