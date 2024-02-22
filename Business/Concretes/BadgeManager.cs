using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.BadgeRequests;
using Business.Dtos.Requests.CategoryRequests;
using Business.Dtos.Responses.BadgeResponses;
using Business.Dtos.Responses.CategoryResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class BadgeManager : IBadgeService
    {
        IBadgeDal _badgeDal;
        IMapper _mapper;

        public BadgeManager(IBadgeDal badgeDal, IMapper mapper)
        {
            _badgeDal = badgeDal;
            _mapper = mapper;
        }

        public async Task<CreatedBadgeResponse> AddAsync(CreateBadgeRequest createBadgeRequest)
        {
            Badge Badge = _mapper.Map<Badge>(createBadgeRequest);
            Badge createdBadge = await _badgeDal.AddAsync(Badge);
            CreatedBadgeResponse createdBadgeResponse = _mapper.Map<CreatedBadgeResponse>(createdBadge);
            return createdBadgeResponse;
        }

        public async Task<Badge> DeleteAsync(int id)
        {
            var data = await _badgeDal.GetAsync(i => i.Id == id);
            var result = await _badgeDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListBadgeResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _badgeDal.GetListAsync(
                include: b => b.Include(b => b.Image),
               index: pageRequest.PageIndex,
               size: pageRequest.PageSize
              );
            var result = _mapper.Map<Paginate<GetListBadgeResponse>>(data);
            return result;
        }

        public async Task<GetListBadgeResponse> GetById(int id)
        {
            var data = await _badgeDal.GetAsync(c => c.Id == id);
            var result = _mapper.Map<GetListBadgeResponse>(data);
            return result;
        }

        public async Task<UpdatedBadgeResponse> UpdateAsync(UpdateBadgeRequest updateBadgeRequest)
        {
            var data = await _badgeDal.GetAsync(i => i.Id == updateBadgeRequest.Id);
            _mapper.Map(updateBadgeRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _badgeDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedBadgeResponse>(data);
            return result;
        }
    }
}
