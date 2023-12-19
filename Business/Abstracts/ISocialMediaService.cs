using Business.Dtos.Requests.SocialMediaRequests;
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
        Task<CreatedSocialMediaResponse> Add(CreateSocialMediaRequest createSocialMediaRequest);
        Task<UpdatedSocialMediaResponse> Update(UpdateSocialMediaRequest updateSocialMediaRequest);
        Task<SocialMedia> Delete(int id);
        Task<IPaginate<GetListSocialMediaResponse>> GetAll(PageRequest pageRequest);
    }
}
