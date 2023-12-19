using Business.Dtos.Requests.ClassroomRequests;
using Business.Dtos.Responses.ClassroomResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IClassroomService
{
    Task<CreatedClassroomResponse> AddAsync(CreateClassroomRequest createClassroomRequest);
    Task<UpdatedClassroomResponse> UpdateAsync(UpdateClassroomRequest updateClassroomRequest);
    Task<Classroom> DeleteAsync(int id);
    Task<IPaginate<GetListClassroomResponse>> GetAllAsync(PageRequest pageRequest);
}
