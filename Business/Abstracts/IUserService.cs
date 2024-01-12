using Business.Dtos.Requests.UserRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.UserResponses;
using Core.DataAccess.Paging;
using Core.Entities.Concretes;
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
        Task<UserBase> AddAsync(UserBase user);
        Task<UpdatedUserResponse> UpdateAsync(UpdateUserRequest updateUserRequest);
        Task<User> DeleteAsync(int id);
        Task<IPaginate<GetListUserResponse>> GetAllAsync(PageRequest pageRequest);
        Task<CreatedUserResponse> GetById(int id);
        List<OperationClaim> GetClaims(UserBase user);
        UserBase GetByMail(string email);
        void Add(UserBase user);
        Task<UserBase> GetByEMail(string email);
    }
}
