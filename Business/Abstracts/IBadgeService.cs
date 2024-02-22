using Business.Dtos.Requests.BadgeRequests;
using Business.Dtos.Responses.BadgeResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IBadgeService
    {
        Task<CreatedBadgeResponse> AddAsync(CreateBadgeRequest createBadgeRequest);
        Task<UpdatedBadgeResponse> UpdateAsync(UpdateBadgeRequest updateBadgeRequest);
        Task<Badge> DeleteAsync(int id);
        Task<IPaginate<GetListBadgeResponse>> GetAllAsync(PageRequest pageRequest);
        Task<GetListBadgeResponse> GetById(int id);

    }
}
