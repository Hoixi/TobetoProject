using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.SurveyRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.SurveyResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes;

public class SurveyManager : ISurveyService
{
    ISurveyDal _surveyDal;
    IMapper _mapper;

    public SurveyManager(ISurveyDal surveyDal, IMapper mapper)
    {
        _surveyDal = surveyDal;
        _mapper = mapper;
    }

    public async Task<CreatedSurveyResponse> AddAsync(CreateSurveyRequest createSurveyRequest)
    {
        Survey survey = _mapper.Map<Survey>(createSurveyRequest);
        Survey createdSurvey = await _surveyDal.AddAsync(survey);
        CreatedSurveyResponse createdSurveyResponse = _mapper.Map<CreatedSurveyResponse>(createdSurvey);
        return createdSurveyResponse;
    }

    public async Task<Survey> DeleteAsync(int Id)
    {
        var data = await _surveyDal.GetAsync(i => i.Id == Id);
        var result = await _surveyDal.DeleteAsync(data);
        return result;
    }

    public async Task<IPaginate<GetListSurveyResponse>> GetAllAsync(PageRequest pageRequest)
    {
        var data = await _surveyDal.GetListAsync(
            index: pageRequest.PageIndex,
            size: pageRequest.PageSize
            );
        var result = _mapper.Map<Paginate<GetListSurveyResponse>>(data);
        return result;
    }

    public async Task<GetListSurveyResponse> GetById(int id)
    {
        var data = await _surveyDal.GetAsync(c => c.Id == id);
        var result = _mapper.Map<GetListSurveyResponse>(data);
        return result;
    }

    public async Task<UpdatedSurveyResponse> UpdateAsync(UpdateSurveyRequest updateSurveyRequest)
    {
        var data = await _surveyDal.GetAsync(i => i.Id == updateSurveyRequest.Id);
        _mapper.Map(updateSurveyRequest, data);
        data.UpdatedDate = DateTime.Now;
        await _surveyDal.UpdateAsync(data);
        var result = _mapper.Map<UpdatedSurveyResponse>(data);
        return result;

    }


}


