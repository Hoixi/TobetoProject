using Business.Dtos.Requests.UserAnnouncementRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.UserAnnouncementResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserAnnouncementService
    {
        Task<CreatedUserAnnouncementResponse> AddAsync(CreateUserAnnouncementRequest createUserAnnouncementRequest);
        Task<UpdatedUserAnnouncementResponse> UpdateAsync(UpdateUserAnnouncementRequest updateUserAnnouncementRequest);
        Task<UserAnnouncement> DeleteAsync(int id);
        Task<IPaginate<GetListUserAnnouncementResponse>> GetAllAsync(PageRequest pageRequest);
        Task<CreatedUserAnnouncementResponse> GetById(int id);
    }
}