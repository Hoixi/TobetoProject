using Business.Dtos.Requests.SocialMediaRequests;
using Business.Dtos.Responses.SocialMediaResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ISocialMediaService
    {
        Task<CreatedSocialMediaResponse> AddAsync(CreateSocialMediaRequest createSocialMediaRequest);
        Task<UpdatedSocialMediaResponse> UpdateAsync(UpdateSocialMediaRequest updateSocialMediaRequest);
        Task<SocialMedia> DeleteAsync(int id);
        Task<IPaginate<GetListSocialMediaResponse>> GetAllAsync(PageRequest pageRequest);
        Task<GetListSocialMediaResponse> GetById(int id);
    }
}
