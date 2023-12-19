using Business.Dtos.Requests.UserSocialMediaRequests;
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
        Task<CreatedUserSocialMediaResponse> Add(CreateUserSocialMediaRequest createUserSociaMediaRequest);
        Task<UpdatedUserSocialMediaResponse> Update(UpdateUserSocialMediaRequest updateUserSocialMediaRequest);
        Task<UserSocialMedia> Delete(int id);
        Task<IPaginate<GetListUserSocialMediaResponse>> GetAll(PageRequest pageRequest);
    }
}
