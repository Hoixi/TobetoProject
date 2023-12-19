using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.SkillRequests;
using Business.Dtos.Requests.SocialMediaRequests;
using Business.Dtos.Responses.SkillResponses;
using Business.Dtos.Responses.SocialMediaResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;
        IMapper _mapper;

        public SocialMediaManager(ISocialMediaDal socialMediDal, IMapper mapper)
        {
            _socialMediaDal = socialMediDal;
            _mapper = mapper;
        }

        public async Task<CreatedSocialMediaResponse> AddAsync(CreateSocialMediaRequest createSocialMediaRequest)
        {
            SocialMedia socialMedia = _mapper.Map<SocialMedia>(createSocialMediaRequest);
            SocialMedia createdSocialMedial = await _socialMediaDal.AddAsync(socialMedia);
            CreatedSocialMediaResponse createdSocialMediaResponse = _mapper.Map<CreatedSocialMediaResponse>(createdSocialMedial);
            return createdSocialMediaResponse;
        }

        public async Task<SocialMedia> DeleteAsync(int id)
        {
            var data = await _socialMediaDal.GetAsync(i => i.Id == id);
            var result = await _socialMediaDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListSocialMediaResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _socialMediaDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListSocialMediaResponse>>(data);
            return result;
        }

        public async Task<UpdatedSocialMediaResponse> UpdateAsync(UpdateSocialMediaRequest updateSocialMediaRequest)
        {
            var data = await _socialMediaDal.GetAsync(i => i.Id == updateSocialMediaRequest.Id);
            _mapper.Map(updateSocialMediaRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _socialMediaDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedSocialMediaResponse>(data);
            return result;
        }
    }
}
