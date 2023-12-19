using Business.Dtos.Requests.ClassroomStudentRequests;
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
}
