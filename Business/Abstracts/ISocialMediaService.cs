using Business.Dtos.Requests.SocialMediaRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.SocialMediaResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ISocialMediaService
    {
        Task<CreatedSocialMediaResponse> AddAsync(CreateSocialMediaRequest createSocialMediaRequest);
        Task<UpdatedSocialMediaResponse> UpdateAsync(UpdateSocialMediaRequest updateSocialMediaRequest);
        Task<SocialMedia> DeleteAsync(int id);
        Task<IPaginate<GetListSocialMediaResponse>> GetAllAsync(PageRequest pageRequest);
        Task<CreatedSocialMediaResponse> GetById(int id);
    }
}
