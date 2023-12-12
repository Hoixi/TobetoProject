using Business.Dtos.Requests.RoleRequests;
using Business.Dtos.Responses.RoleResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IRoleService
{
    Task<CreatedRoleResponse> Add(CreateRoleRequest createRoleRequest);
    Task<UpdatedRoleResponse> Update(UpdateRoleRequest updateRoleRequest);
    Task<Role> Delete(int Id, bool permanent);
    Task<IPaginate<GetListRoleResponse>> GetAll();
    Task<CreatedRoleResponse> GetRoleById(int id);
}
