using Business.Dtos.Requests.ClassroomInstructorRequests;
using Business.Dtos.Responses.ClassroomInstructorResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IClassroomInstructorService
{
    Task<CreatedClassroomInstructorResponse> AddAsync(CreateClassroomInstructorRequest createClassroomInstructorRequest);
    Task<UpdatedClassroomInstructorResponse> UpdateAsync(UpdateClassroomInstructorRequest updateClassroomInstructorRequest);
    Task<ClassroomInstructor> DeleteAsync(int id);
    Task<IPaginate<GetListClassroomInstructorResponse>> GetAllAsync(PageRequest pageRequest);
}
