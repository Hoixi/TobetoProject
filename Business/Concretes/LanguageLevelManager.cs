using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.AddressRequests;
using Business.Dtos.Requests.LanguageLevelRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.InstructorResponses;
using Business.Dtos.Responses.LanguageLevelResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class LanguageLevelManager : ILanguageLevelService
    {
        ILanguageLevelDal _languageLevelDal;
        IMapper _mapper;

        public LanguageLevelManager(ILanguageLevelDal languageLevelDal, IMapper mapper)
        {
            _languageLevelDal = languageLevelDal;
            _mapper = mapper;
        }

        public async Task<CreatedLanguageLevelResponse> AddAsync(CreateLanguageLevelRequest createLanguageLevelRequest)
        {
            LanguageLevel languageLevel = _mapper.Map<LanguageLevel>(createLanguageLevelRequest);
            LanguageLevel createdLanguageLevel = await _languageLevelDal.AddAsync(languageLevel);
            CreatedLanguageLevelResponse createdLanguageLevelResponse = _mapper.Map<CreatedLanguageLevelResponse>(createdLanguageLevel);
            return createdLanguageLevelResponse;
        }

        public async Task<LanguageLevel> DeleteAsync(int id)
        {
            var data = await _languageLevelDal.GetAsync(i => i.Id == id);
            var result = await _languageLevelDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListLanguageLevelResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _languageLevelDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListLanguageLevelResponse>>(data);
            return result;
        }

        public async Task<GetListLanguageLevelResponse> GetById(int id)
        {
            var data = await _languageLevelDal.GetAsync(c => c.Id == id);
            var result = _mapper.Map<GetListLanguageLevelResponse>(data);
            return result;
        }

        public async Task<UpdatedLanguageLevelResponse> UpdateAsync(UpdateLanguageLevelRequest updateLanguageLevelRequest)
        {
            var data = await _languageLevelDal.GetAsync(i => i.Id == updateLanguageLevelRequest.Id);
            _mapper.Map(updateLanguageLevelRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _languageLevelDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedLanguageLevelResponse>(data);
            return result;
        }
    }
}
