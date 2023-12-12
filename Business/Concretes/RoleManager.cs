using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
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
        IRoleDal _roleDal;
        IMapper _mapper;

        public RoleManager(IRoleDal roleDal,IMapper mapper)
        {
            _roleDal = roleDal;
            _mapper = mapper;
        }

        public async Task<CreatedRoleResponse> Add(CreateRoleRequest createRoleRequest)
        {
            Role role = _mapper.Map<Role>(createRoleRequest);
            Role createdRole = await _roleDal.AddAsync(role);
            CreatedRoleResponse createdRoleResponse = _mapper.Map<CreatedRoleResponse>(createdRole);
            return createdRoleResponse;
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
