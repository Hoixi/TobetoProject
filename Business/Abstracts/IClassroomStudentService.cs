using Business.Dtos.Requests.ClassroomStudentRequests;
using Business.Dtos.Responses.ClassroomResponses;
using Business.Dtos.Responses.ClassroomStudentResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IClassroomStudentService
{
    Task<CreatedClassroomStudentResponse> AddAsync(CreateClassroomStudentRequest createClassroomStudentRequest);
    Task<UpdatedClassroomStudentResponse> UpdateAsync(UpdateClassroomStudentRequest updateClassroomStudentRequest);
    Task<ClassroomStudent> DeleteAsync(int id);
    Task<IPaginate<GetListClassroomStudentResponse>> GetAllAsync(PageRequest pageRequest);
    Task<IPaginate<GetListClassroomStudentResponse>> GetById(int id, PageRequest pageRequest);
    Task<IPaginate<GetListClassroomStudentResponse>> GetListByStudentId(int studentId,PageRequest pageRequest);
    Task<IPaginate<GetListClassroomStudentResponse>> GetListByClassroomGroupId(int classroomGroupId, PageRequest pageRequest);
}
