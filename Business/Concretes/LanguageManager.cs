using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.LanguageRequests;
using Business.Dtos.Responses.LanguageResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class LanguageManager : ILanguageService
{
    ILanguageDal _languageDal;
    IMapper _mapper;
    public LanguageManager(ILanguageDal languageDal, IMapper mapper)
    {
        _languageDal = languageDal;
        _mapper = mapper;
    }

    public async Task<CreatedLanguageResponse> AddAsync(CreateLanguageRequest createLanguageRequest)
    {
        Language language = _mapper.Map<Language>(createLanguageRequest);
        Language createdLanguage = await _languageDal.AddAsync(language);
        CreatedLanguageResponse createdLanguageResponse = _mapper.Map<CreatedLanguageResponse>(createdLanguage);
        return createdLanguageResponse;
    }

    public async Task<Language> DeleteAsync(int id)
    {
        var data = await _languageDal.GetAsync(i => i.Id == id);
        var result = await _languageDal.DeleteAsync(data);
        return result;
    }

    public async Task<IPaginate<GetListLanguageResponse>> GetAllAsync(PageRequest pageRequest)
    {
        var data = await _languageDal.GetListAsync(
               index: pageRequest.PageIndex,
               size: pageRequest.PageSize
               );
        var result = _mapper.Map<Paginate<GetListLanguageResponse>>(data);
        return result;
    }

    public async Task<GetListLanguageResponse> GetById(int id)
    {
        var data = await _languageDal.GetAsync(c => c.Id == id);
        var result = _mapper.Map<GetListLanguageResponse>(data);
        return result;
    }

    public async Task<UpdatedLanguageResponse> UpdateAsync(UpdateLanguageRequest updateLanguageRequest)
    {
        var data = await _languageDal.GetAsync(i => i.Id == updateLanguageRequest.Id);
        _mapper.Map(updateLanguageRequest, data);
        data.UpdatedDate = DateTime.Now;
        await _languageDal.UpdateAsync(data);
        var result = _mapper.Map<UpdatedLanguageResponse>(data);
        return result;
    }
}
