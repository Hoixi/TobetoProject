using System;
using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserLanguageRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.UserLanguageResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class UserLanguageManager : IUserLanguageService
    {
        IUserLanguageDal _userLanguageDal;
        IMapper _mapper;

        public UserLanguageManager(IUserLanguageDal userLanguageDal, IMapper mapper)
        {
            _userLanguageDal = userLanguageDal;
            _mapper = mapper;
        }

        public async Task<CreatedUserLanguageResponse> AddAsync(CreateUserLanguageRequest createUserLanguageRequest)
        {
            UserLanguage userLanguage = _mapper.Map<UserLanguage>(createUserLanguageRequest);
            UserLanguage createdUserLanguage = await _userLanguageDal.AddAsync(userLanguage);
            CreatedUserLanguageResponse createdUserLanguageResponse = _mapper.Map<CreatedUserLanguageResponse>(createdUserLanguage);
            return createdUserLanguageResponse;
        }

        public async Task<UserLanguage> DeleteAsync(int id)
        {
            var data = await _userLanguageDal.GetAsync(i => i.Id == id);
            var result = await _userLanguageDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListUserLanguageResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _userLanguageDal.GetListAsync(include: p => p
        .Include(p => p.Language)
        .Include(p => p.LanguageLevel),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListUserLanguageResponse>>(data);
            return result;
        }

        public async Task<UpdatedUserLanguageResponse> UpdateAsync(UpdateUserLanguageRequest updateUserLanguageRequest)
        {
            var data = await _userLanguageDal.GetAsync(i => i.Id == updateUserLanguageRequest.Id);
            _mapper.Map(updateUserLanguageRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _userLanguageDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedUserLanguageResponse>(data);
            return result;
        }

        public async Task<CreatedUserLanguageResponse> GetById(int id)
        {
            var data = await _userLanguageDal.GetAsync(c => c.Id == id);
            var result = _mapper.Map<CreatedUserLanguageResponse>(data);
            return result;
        }

        public async Task<IPaginate<GetListUserLanguageResponse>> GetByUserId(PageRequest pageRequest, int userId)
        {
            var data = await _userLanguageDal.GetListAsync(include: p => p
        .Include(p => p.Language)
        .Include(p => p.LanguageLevel),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize,
                predicate: u => userId == u.UserId
               );
            var result = _mapper.Map<Paginate<GetListUserLanguageResponse>>(data);
            return result;
        }
    }

}

