using Business.Dtos.Requests.UserOperationClaimRequests;
using Business.Dtos.Requests.UserRequests;
using Business.Dtos.Responses.UserOperationClaimResponses;
using Business.Dtos.Responses.UserResponses;
using Core.DataAccess.Paging;
using Core.Entities.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserOperationClaimService
    {
        Task<CreatedUserOperationClaimResponse> AddAsync(CreateUserOperationClaimRequest createUserOperationClaimRequest);
        Task<UpdatedUserOperationClaimResponse> UpdateAsync(UpdateUserOperationClaimRequest updateUserOperationClaimRequest);
        Task<UserOperationClaim> DeleteAsync(int id);
        Task<IPaginate<GetListUserOperationClaimResponse>> GetAllAsync(PageRequest pageRequest);
    }
}
