using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserOperationClaimRequests;
using Business.Dtos.Requests.UserSkillRequests;
using Business.Dtos.Responses.UserOperationClaimResponses;
using Business.Dtos.Responses.UserSkillResponses;
using Core.DataAccess.Paging;
using Core.Entities.Concretes;
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
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        IUserOperationClaimDal _userOperationClaimDal;
        IMapper _mapper;

        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaimDal,IMapper mapper)
        {
            _userOperationClaimDal = userOperationClaimDal;
            _mapper = mapper;
        }

        public async Task<CreatedUserOperationClaimResponse> AddAsync(CreateUserOperationClaimRequest createUserOperationClaimRequest)
        {
            UserOperationClaim userOperationClaim = _mapper.Map<UserOperationClaim>(createUserOperationClaimRequest);
            UserOperationClaim createdUserOperationClaim = await _userOperationClaimDal.AddAsync(userOperationClaim);
            CreatedUserOperationClaimResponse createdUserOperationClaimResponse = _mapper.Map<CreatedUserOperationClaimResponse>(createdUserOperationClaim);
            return createdUserOperationClaimResponse;
        }

        public async Task<UserOperationClaim> DeleteAsync(int id)
        {
            var data = await _userOperationClaimDal.GetAsync(i => i.Id == id);
            var result = await _userOperationClaimDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListUserOperationClaimResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _userOperationClaimDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListUserOperationClaimResponse>>(data);
            return result;
        }

        public async Task<UpdatedUserOperationClaimResponse> UpdateAsync(UpdateUserOperationClaimRequest updateUserOperationClaimRequest)
        {
            var data = await _userOperationClaimDal.GetAsync(i => i.Id == updateUserOperationClaimRequest.Id);
            _mapper.Map(updateUserOperationClaimRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _userOperationClaimDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedUserOperationClaimResponse>(data);
            return result;
        }
    }
}
