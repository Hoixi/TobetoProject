using Business.Dtos.Requests.UserAnnouncementRequests;
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
        Task<CreatedUserAnnouncementResponse> Add(CreateUserAnnouncementRequest createUserAnnouncementRequest);
        Task<UpdatedUserAnnouncementResponse> Update(UpdateUserAnnouncementRequest updateUserAnnouncementRequest);
        Task<UserAnnouncement> Delete(int id);
        Task<IPaginate<GetListUserAnnouncementResponse>> GetAll(PageRequest pageRequest);
    }
}