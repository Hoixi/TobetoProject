using Business.Dtos.Requests.ClassroomGroupCourseRequests;
using Business.Dtos.Responses.ClassroomGroupCourseResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IClassroomGroupCourseService
{
    Task<CreatedClassroomGroupCourseResponse> AddAsync(CreateClassroomGroupCourseRequest createClassroomGroupCourseRequest);
    Task<UpdatedClassroomGroupCourseResponse> UpdateAsync(UpdateClassroomGroupCourseRequest updateClassroomGroupCourseRequest);
    Task<ClassroomGroupCourse> DeleteAsync(int id);
    Task<IPaginate<GetListClassroomGroupCourseResponse>> GetAllAsync(PageRequest pageRequest);
    Task<GetListClassroomGroupCourseResponse> GetById(int id);
    Task<IPaginate<GetListClassroomGroupCourseResponse>> GetListByClassroomGroupId(int classroomGroupId, PageRequest pageRequest);
    Task<IPaginate<GetListClassroomGroupCourseResponse>> GetListByCourseId(int courseId, PageRequest pageRequest);
}