using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserServeyRequests;
using Business.Dtos.Responses.UserServeyResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

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
    }
}
