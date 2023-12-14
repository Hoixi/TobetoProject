using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.GroupRequests;
using Business.Dtos.Requests.ImageRequests;
using Business.Dtos.Responses.GroupResponse;
using Business.Dtos.Responses.ImageResponse;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
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

        public async Task<CreatedGroupResponse> Add(CreateGroupRequest createGroupRequest)
        {
            Group group = _mapper.Map<Group>(createGroupRequest);
            Group createdGroup = await _groupDal.AddAsync(group);
            CreatedGroupResponse createdGroupResponse = _mapper.Map<CreatedGroupResponse>(createdGroup);
            return createdGroupResponse;
        }

        public async Task<Group> Delete(int Id, bool permanent)
        {
            var data = await _groupDal.GetAsync(i => i.Id == Id);
            var result = await _groupDal.DeleteAsync(data, permanent);
            return result;
        }

        public async Task<IPaginate<GetGroupListResponse>> GetAll(PageRequest pageRequest)
        {
            var data = await _groupDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
                );
            var result = _mapper.Map<Paginate<GetGroupListResponse>>(data);
            return result;
        }

        public async Task<CreatedGroupResponse> GetGroupById(int id)
        {
            var data = await _groupDal.GetAsync(i => i.Id == id);
            var result = _mapper.Map<CreatedGroupResponse>(data);
            return result;
        }

        public async Task<UpdatedGroupResponse> Update(UpdateGroupRequest updateGroupRequest)
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
