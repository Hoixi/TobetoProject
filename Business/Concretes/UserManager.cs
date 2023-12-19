using System;
using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserRequests;
using Business.Dtos.Responses.UserResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class UserManager : IUserService
{
    IUserDal _userDal;
    IMapper _mapper;

    public UserManager(IUserDal userDal, IMapper mapper)
    {
        _userDal = userDal;
        _mapper = mapper;
    }

    public async Task<CreatedUserResponse> AddAsync(CreateUserRequest createUserRequest)
    {
        User user = _mapper.Map<User>(createUserRequest);
        User createdUser = await _userDal.AddAsync(user);
        CreatedUserResponse createdUserResponse = _mapper.Map<CreatedUserResponse>(createdUser);
        return createdUserResponse;
    }

    public async Task<User> DeleteAsync(int id)
    {
        var data = await _userDal.GetAsync(i => i.Id == id);
        var result = await _userDal.DeleteAsync(data);
        return result;
    }

    public async Task<IPaginate<GetListUserResponse>> GetAllAsync(PageRequest pageRequest)
    {
        var data = await _userDal.GetListAsync(
            index: pageRequest.PageIndex,
            size: pageRequest.PageSize
           );
        var result = _mapper.Map<Paginate<GetListUserResponse>>(data);
        return result;
    }

    public async Task<UpdatedUserResponse> UpdateAsync(UpdateUserRequest updateUserRequest)
    {
        var data = await _userDal.GetAsync(i => i.Id == updateUserRequest.Id);
        _mapper.Map(updateUserRequest, data);
        data.UpdatedDate = DateTime.Now;
        await _userDal.UpdateAsync(data);
        var result = _mapper.Map<UpdatedUserResponse>(data);
        return result;
    }
}

