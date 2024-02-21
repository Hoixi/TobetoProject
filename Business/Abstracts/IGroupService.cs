using Business.Dtos.Requests.GroupRequests;
using Business.Dtos.Responses.GroupResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IGroupService
{
    Task<CreatedGroupResponse> AddAsync(CreateGroupRequest createGroupRequest);
    Task<UpdatedGroupResponse> UpdateAsync(UpdateGroupRequest updateGroupRequest);
    Task<Group> DeleteAsync(int id);
    Task<IPaginate<GetListGroupResponse>> GetAllAsync(PageRequest pageRequest);
    Task<GetListGroupResponse> GetById(int id);

}

