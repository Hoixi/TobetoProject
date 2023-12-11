using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class RoleManager : IRoleService
    {
        public Task<CreatedRoleResponse> Add(CreateRoleRequest createRoleRequest)
        {
            throw new NotImplementedException();
        }

        public Task<CreatedRoleResponse> Delete(Role role)
        {
            throw new NotImplementedException();
        }

        public Task<CreatedRoleResponse> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IPaginate<GetListRoleResponse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CreatedRoleResponse> Update(Role role)
        {
            throw new NotImplementedException();
        }
    }
}
