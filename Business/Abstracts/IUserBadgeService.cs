using Business.Dtos.Requests.UserBadgeRequests;
using Business.Dtos.Responses.UserBadgeResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IUserBadgeService
    {
        Task<CreatedUserBadgeResponse> AddAsync(CreateUserBadgeRequest createUserBadgeRequest);
        Task<UpdatedUserBadgeResponse> UpdateAsync(UpdateUserBadgeRequest updateUserBadgeRequest);
        Task<UserBadge> DeleteAsync(int id);
        Task<IPaginate<GetListUserBadgeResponse>> GetAllAsync(PageRequest pageRequest);
        Task<GetListUserBadgeResponse> GetById(int id);
        Task<GetListUserBadgeResponse> GetByUserId(int userId);
    }
}
