using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserAnnouncementRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.UserAnnouncementResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class UserAnnouncementManager : IUserAnnouncementService
    {
        IUserAnnouncementDal _userAnnouncementDal;
        IMapper _mapper;

        public UserAnnouncementManager(IUserAnnouncementDal userAnnouncementDal, IMapper mapper)
        {
            _userAnnouncementDal = userAnnouncementDal;
            _mapper = mapper;
        }

        public async Task<CreatedUserAnnouncementResponse> AddAsync(CreateUserAnnouncementRequest createUserAnnouncementRequest)
        {
            UserAnnouncement userAnnouncement = _mapper.Map<UserAnnouncement>(createUserAnnouncementRequest);
            UserAnnouncement createdUserAnnouncement = await _userAnnouncementDal.AddAsync(userAnnouncement);
            CreatedUserAnnouncementResponse createdUserAnnouncementResponse = _mapper.Map<CreatedUserAnnouncementResponse>(createdUserAnnouncement);
            return createdUserAnnouncementResponse;
        }

        public async Task<UserAnnouncement> DeleteAsync(int id)
        {
            var data = await _userAnnouncementDal.GetAsync(i => i.Id == id);
            var result = await _userAnnouncementDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListUserAnnouncementResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _userAnnouncementDal.GetListAsync(
                include : ua => ua.Include(a => a.Announcement),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListUserAnnouncementResponse>>(data);
            return result;
        }

        public async Task<CreatedUserAnnouncementResponse> GetById(int id)
        {
            var data = await _userAnnouncementDal.GetAsync(c => c.Id == id);
            var result = _mapper.Map<CreatedUserAnnouncementResponse>(data);
            return result;
        }

        public async Task<UpdatedUserAnnouncementResponse> UpdateAsync(UpdateUserAnnouncementRequest updateUserAnnouncementRequest)
        {
            var data = await _userAnnouncementDal.GetAsync(i => i.Id == updateUserAnnouncementRequest.Id);
            _mapper.Map(updateUserAnnouncementRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _userAnnouncementDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedUserAnnouncementResponse>(data);
            return result;
        }
    }

}

