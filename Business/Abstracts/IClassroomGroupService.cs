using Business.Dtos.Requests.ClassroomGroupRequests;
using Business.Dtos.Responses.ClassroomGroupResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;


public interface IClassroomGroupService
{
    Task<CreatedClassroomGroupResponse> AddAsync(CreateClassroomGroupRequest createClassroomGroupRequest);
    Task<UpdatedClassroomGroupResponse> UpdateAsync(UpdateClassroomGroupRequest updateClassroomGroupRequest);
    Task<ClassroomGroup> DeleteAsync(int id);
    Task<IPaginate<GetListClassroomGroupResponse>> GetAllAsync(PageRequest pageRequest);
}
