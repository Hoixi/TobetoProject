using Business.Dtos.Requests.UserOperationClaimRequests;
using Business.Dtos.Responses.UserOperationClaimResponses;
using Core.DataAccess.Paging;
using Core.Entities.Concretes;

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
