using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserSurveyRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.UserSkillResponses;
using Business.Dtos.Responses.UserSurveyResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class UserSurveyManager : IUserSurveyService
    {
        IUserSurveyDal _userSurveyDal;
        IMapper _mapper;

        public UserSurveyManager(IUserSurveyDal userSurveyDal, IMapper mapper)
        {
            _userSurveyDal = userSurveyDal;
            _mapper = mapper;
        }

        public async Task<CreatedUserSurveyResponse> AddAsync(CreateUserSurveyRequest createUserSurveyRequest)
        {
            UserSurvey userSurvey = _mapper.Map<UserSurvey>(createUserSurveyRequest);
            UserSurvey createdUserSurvey = await _userSurveyDal.AddAsync(userSurvey);
            CreatedUserSurveyResponse createdUserSurveyResponse = _mapper.Map<CreatedUserSurveyResponse>(createdUserSurvey);
            return createdUserSurveyResponse;
        }

        public async Task<UserSurvey> DeleteAsync(int id)
        {
            var data = await _userSurveyDal.GetAsync(i => i.Id == id);
            var result = await _userSurveyDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListUserSurveyResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _userSurveyDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListUserSurveyResponse>>(data);
            return result;
        }

        public async Task<UpdatedUserSurveyResponse> UpdateAsync(UpdateUserSurveyRequest updateUserSurveyRequest)
        {
            var data = await _userSurveyDal.GetAsync(i => i.Id == updateUserSurveyRequest.Id);
            _mapper.Map(updateUserSurveyRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _userSurveyDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedUserSurveyResponse>(data);
            return result;
        }

        public async Task<CreatedUserSurveyResponse> GetById(int id)
        {
            var data = await _userSurveyDal.GetAsync(c => c.Id == id);
            var result = _mapper.Map<CreatedUserSurveyResponse>(data);
            return result;
        }

        public async Task<IPaginate<GetListUserSurveyResponse>> GetByUserId(PageRequest pageRequest, int userId)
        {
            var data = await _userSurveyDal.GetListAsync(
                predicate: u => u.UserId == userId,
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListUserSurveyResponse>>(data);
            return result;
        }
    }
}
