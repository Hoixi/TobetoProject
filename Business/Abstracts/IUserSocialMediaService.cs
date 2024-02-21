using Business.Dtos.Requests.UserSocialMediaRequests;
using Business.Dtos.Responses.UserSocialMediaResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IUserSocialMediaService
    {
        Task<CreatedUserSocialMediaResponse> AddAsync(CreateUserSocialMediaRequest createUserSociaMediaRequest);
        Task<UpdatedUserSocialMediaResponse> UpdateAsync(UpdateUserSocialMediaRequest updateUserSocialMediaRequest);
        Task<UserSocialMedia> DeleteAsync(int id);
        Task<IPaginate<GetListUserSocialMediaResponse>> GetAllAsync(PageRequest pageRequest);
        Task<GetListUserSocialMediaResponse> GetById(int id);
        Task<IPaginate<GetListUserSocialMediaResponse>> GetByUserId(PageRequest pageRequest, int userId);
    }
}
