using Business.Dtos.Requests.UserRequests;
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
        Task<CreatedUserResponse> Add(CreateUserRequest createUserRequest);
        Task<UpdatedUserResponse> Update(UpdateUserRequest updateUserRequest);
        Task<User> Delete(int id);
        Task<IPaginate<GetListUserResponse>> GetAll(PageRequest pageRequest);
    }
}
