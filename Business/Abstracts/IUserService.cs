using Business.Dtos.Requests.UserRequests;
using Business.Dtos.Responses.RoleResponses;
using Business.Dtos.Responses.UserResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
        Task<CreateUserResponse> Add(CreateUserRequest createUserRequest);
        Task<UpdateUserResponse> Update(UpdateUserRequest updateUserRequest);
        Task<User> Delete(int Id, bool permanent);
        Task<IPaginate<GetListUserResponse>> GetAll(PageRequest pageRequest);
        Task<CreateUserResponse> GetUserById(int id);
    }
}
