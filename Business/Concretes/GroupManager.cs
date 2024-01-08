using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.GroupRequests;
using Business.Dtos.Requests.RoleRequests;
using Business.Dtos.Responses.ExperienceResponses;
using Business.Dtos.Responses.GroupResponses;
using Business.Dtos.Responses.RoleResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class GroupManager : IGroupService
    {
        IGroupDal _groupDal;
        IMapper _mapper;
        public GroupManager(IGroupDal groupDal, IMapper mapper)
        {
            _groupDal = groupDal;
            _mapper = mapper;
        }

        public async Task<CreatedGroupResponse> AddAsync(CreateGroupRequest createGroupRequest)
        {
            Group group = _mapper.Map<Group>(createGroupRequest);
            Group createdGroup = await _groupDal.AddAsync(group);
            CreatedGroupResponse createdGroupResponse = _mapper.Map<CreatedGroupResponse>(createdGroup);
            return createdGroupResponse;
        }

        public async Task<Group> DeleteAsync(int id)
        {
            var data = await _groupDal.GetAsync(i => i.Id == id);
            var result = await _groupDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListGroupResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _groupDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
                );
            var result = _mapper.Map<Paginate<GetListGroupResponse>>(data);
            return result;
        }

        public async Task<CreatedGroupResponse> GetById(int id)
        {
            var data = await _groupDal.GetAsync(c => c.Id == id);
            var result = _mapper.Map<CreatedGroupResponse>(data);
            return result;
        }

        public async Task<UpdatedGroupResponse> UpdateAsync(UpdateGroupRequest updateGroupRequest)
        {
            var data = await _groupDal.GetAsync(i => i.Id == updateGroupRequest.Id);
            _mapper.Map(updateGroupRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _groupDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedGroupResponse>(data);
            return result;

        }
    }
}
