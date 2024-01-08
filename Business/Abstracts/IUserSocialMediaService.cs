using Business.Dtos.Requests.UserSocialMediaRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.UserSocialMediaResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserSocialMediaService
    {
        Task<CreatedUserSocialMediaResponse> AddAsync(CreateUserSocialMediaRequest createUserSociaMediaRequest);
        Task<UpdatedUserSocialMediaResponse> UpdateAsync(UpdateUserSocialMediaRequest updateUserSocialMediaRequest);
        Task<UserSocialMedia> DeleteAsync(int id);
        Task<IPaginate<GetListUserSocialMediaResponse>> GetAllAsync(PageRequest pageRequest);
        Task<CreatedUserSocialMediaResponse> GetById(int id);
    }
}
