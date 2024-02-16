using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserSkillRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.UserSkillResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class UserSkillManager : IUserSkillService
    {
        IUserSkillDal _userSkillDal;
        IMapper _mapper;

        public UserSkillManager(IUserSkillDal userSkillDal, IMapper mapper)
        {
            _userSkillDal = userSkillDal;
            _mapper = mapper;
        }

        public async Task<CreatedUserSkillResponse> AddAsync(CreateUserSkillRequest createUserSkillRequest)
        {
            UserSkill userSkill = _mapper.Map<UserSkill>(createUserSkillRequest);
            UserSkill createdUserSkill = await _userSkillDal.AddAsync(userSkill);
            CreatedUserSkillResponse createdUserSkillResponse = _mapper.Map<CreatedUserSkillResponse>(createdUserSkill);
            return createdUserSkillResponse;
        }

        public async Task<UserSkill> DeleteAsync(int id)
        {
            var data = await _userSkillDal.GetAsync(i => i.Id == id);
            var result = await _userSkillDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListUserSkillResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _userSkillDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListUserSkillResponse>>(data);
            return result;
        }

        public async Task<UpdatedUserSkillResponse> UpdateAsync(UpdateUserSkillRequest updateUserSkillRequest)
        {
            var data = await _userSkillDal.GetAsync(i => i.Id == updateUserSkillRequest.Id);
            _mapper.Map(updateUserSkillRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _userSkillDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedUserSkillResponse>(data);
            return result;
        }

        public async Task<CreatedUserSkillResponse> GetById(int id)
        {
            var data = await _userSkillDal.GetAsync(c => c.Id == id);
            var result = _mapper.Map<CreatedUserSkillResponse>(data);
            return result;
        }

        public async Task<IPaginate<GetListUserSkillResponse>> GetByUserId(PageRequest pageRequest, int userId)
        {
            var data = await _userSkillDal.GetListAsync(include: p => p
        .Include(p => p.Skill),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize,
                predicate: u => userId == u.UserId
               );
            var result = _mapper.Map<Paginate<GetListUserSkillResponse>>(data);
            return result;
        }
    }

}

