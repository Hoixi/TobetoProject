using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserBadgeRequests;
using Business.Dtos.Responses.UserBadgeResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserBadgeManager : IUserBadgeService
    {
        IUserBadgeDal _userBadgeDal;
        IMapper _mapper;

        public UserBadgeManager(IUserBadgeDal userBadgeDal, IMapper mapper)
        {
            _userBadgeDal = userBadgeDal;
            _mapper = mapper;
        }

        public async Task<CreatedUserBadgeResponse> AddAsync(CreateUserBadgeRequest createUserBadgeRequest)
        {
            UserBadge UserBadge = _mapper.Map<UserBadge>(createUserBadgeRequest);
            UserBadge createdUserBadge = await _userBadgeDal.AddAsync(UserBadge);
            CreatedUserBadgeResponse createdUserBadgeResponse = _mapper.Map<CreatedUserBadgeResponse>(createdUserBadge);
            return createdUserBadgeResponse;
        }

        public async Task<UserBadge> DeleteAsync(int id)
        {
            var data = await _userBadgeDal.GetAsync(i => i.Id == id);
            var result = await _userBadgeDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListUserBadgeResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _userBadgeDal.GetListAsync(
                include: b => b                
                .Include(b => b.Badge),
               index: pageRequest.PageIndex,
               size: pageRequest.PageSize
              );
            var result = _mapper.Map<Paginate<GetListUserBadgeResponse>>(data);
            return result;
        }

        public async Task<GetListUserBadgeResponse> GetById(int id)
        {
            var data = await _userBadgeDal.GetAsync(
                c => c.Id == id,
                include: b => b                
                .Include(b => b.Badge)
                );
            var result = _mapper.Map<GetListUserBadgeResponse>(data);
            return result;
        }

        public async Task<UpdatedUserBadgeResponse> UpdateAsync(UpdateUserBadgeRequest updateUserBadgeRequest)
        {
            var data = await _userBadgeDal.GetAsync(i => i.Id == updateUserBadgeRequest.Id);
            _mapper.Map(updateUserBadgeRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _userBadgeDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedUserBadgeResponse>(data);
            return result;
        }
    }
}
