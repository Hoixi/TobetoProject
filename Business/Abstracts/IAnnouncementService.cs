using Business.Dtos.Requests.AnnouncementRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.AnnouncementResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IAnnouncementService
{
    Task<CreatedAnnouncementResponse> AddAsync(CreateAnnouncementRequest createAnnouncementRequest);
    Task<UpdatedAnnouncementResponse> UpdateAsync(UpdateAnnouncementRequest updateAnnouncementRequest);
    Task<Announcement> DeleteAsync(int id);
    Task<IPaginate<GetListAnnouncementResponse>> GetAllAsync(PageRequest pageRequest);
    Task<CreatedAnnouncementResponse> GetById(int id);
}