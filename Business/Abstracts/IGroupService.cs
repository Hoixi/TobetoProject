using Business.Dtos.Requests.GroupRequests;
using Business.Dtos.Requests.ImageRequests;
using Business.Dtos.Responses.GroupResponse;
using Business.Dtos.Responses.ImageResponse;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IGroupService
    {
        Task<CreatedGroupResponse> Add(CreateGroupRequest createGroupRequest);
        Task<UpdatedGroupResponse> Update(UpdateGroupRequest updateGroupRequest);
        Task<Group> Delete(int Id, bool permanent);
        Task<IPaginate<GetGroupListResponse>> GetAll(PageRequest pageRequest);
        Task<CreatedGroupResponse> GetGroupById(int id);
    }
}
