using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IRoleService
    {
        Task<CreatedRoleResponse> Add(CreateRoleRequest createRoleRequest);
        Task<CreatedRoleResponse> Update(Role role);
        Task<CreatedRoleResponse> Delete(Role role);

        Task<IPaginate<GetListRoleResponse>> GetAll();
        Task<CreatedRoleResponse> Get(int id);
    }
}
