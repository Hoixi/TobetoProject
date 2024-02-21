using Business.Dtos.Requests.UserAnnouncementRequests;
using Business.Dtos.Responses.UserAnnouncementResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IUserAnnouncementService
    {
        Task<CreatedUserAnnouncementResponse> AddAsync(CreateUserAnnouncementRequest createUserAnnouncementRequest);
        Task<UpdatedUserAnnouncementResponse> UpdateAsync(UpdateUserAnnouncementRequest updateUserAnnouncementRequest);
        Task<UserAnnouncement> DeleteAsync(int id);
        Task<IPaginate<GetListUserAnnouncementResponse>> GetAllAsync(PageRequest pageRequest);
        Task<GetListUserAnnouncementResponse> GetById(int id);
    }
}