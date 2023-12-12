using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Requests.UserRequests;
using Business.Dtos.Responses.CourseResponses;
using Business.Dtos.Responses.UserResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
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

        public async Task<User> Delete(int Id, bool permanent)
        {
            var data = await _userDal.GetAsync(i => i.Id == Id);
            var result = await _userDal.DeleteAsync(data, permanent);
            return result;
        }

        public async Task<IPaginate<GetListUserResponse>> GetAll()
        {
            var data = await _userDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListUserResponse>>(data);
            return result;
        }

        public async Task<CreateUserResponse> GetUserById(int id)
        {
            var data = await _userDal.GetAsync(i => i.Id == id);
            var result = _mapper.Map<CreateUserResponse>(data);
            return result;
        }

        public async Task<UpdateUserResponse> Update(UpdateUserRequest updateUserRequest)
        {
            var data = await _userDal.GetAsync(i => i.Id == updateUserRequest.Id);
            _mapper.Map(updateUserRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _userDal.UpdateAsync(data);
            var result = _mapper.Map<UpdateUserResponse>(data);
            return result;
        }
    }
}
