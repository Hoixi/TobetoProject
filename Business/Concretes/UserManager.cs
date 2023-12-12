using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IMapper _mapper;

        public UserManager(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }

        public async Task<CreateUserResponse> Add(CreateUserRequest createUserRequest)
        {
            User user = _mapper.Map<User>(createUserRequest);
            User createdUser = await _userDal.AddAsync(user);
            CreateUserResponse createUserResponse = _mapper.Map<CreateUserResponse>(createdUser);
            return createUserResponse;
        }

        public Task<DeleteUserResponse> Delete(DeleteUserRequest deleteUserRequest)
        {
            throw new NotImplementedException();
        }

        public Task<IPaginate<GetListUserResponse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UpdateUserResponse> Update(UpdateUserRequest updateUserRequest)
        {
            throw new NotImplementedException();
        }
    }
}
