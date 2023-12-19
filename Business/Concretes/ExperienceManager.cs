using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ExperienceRequests;
using Business.Dtos.Requests.RoleRequests;
using Business.Dtos.Responses.ExperienceResponses;
using Business.Dtos.Responses.RoleResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class ExperienceManager : IExperienceService
{
    IExperienceDal _experienceDal;
    IMapper _mapper;


    public ExperienceManager(IExperienceDal experienceDal, IMapper mapper)
    {
        _experienceDal = experienceDal;
        _mapper = mapper;
    }

    

    public async Task<CreatedExperienceResponse> AddAsync(CreateExperienceRequest createExperienceRequest)
    {
        Experience experience = _mapper.Map<Experience>(createExperienceRequest);
        Experience createdExperience = await _experienceDal.AddAsync(experience);
        CreatedExperienceResponse createdExperienceResponse = _mapper.Map<CreatedExperienceResponse>(createdExperience);
        return createdExperienceResponse;
    }

    public async Task<Experience> DeleteAsync(int id)
    {
        var data = await _experienceDal.GetAsync(i => i.Id == id);
        var result = await _experienceDal.DeleteAsync(data);
        return result;
    }

    public async Task<IPaginate<GetListExperienceResponse>> GetAllAsync(PageRequest pageRequest)
    {
        var data = await _experienceDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
                );
        var result = _mapper.Map<Paginate<GetListExperienceResponse>>(data);
        return result;
    }

    public async Task<UpdatedExperienceResponse> UpdateAsync(UpdateExperienceRequest updateExperienceRequest)
    {
        var data = await _experienceDal.GetAsync(i => i.Id == updateExperienceRequest.Id);
        _mapper.Map(updateExperienceRequest, data);
        data.UpdatedDate = DateTime.Now;
        await _experienceDal.UpdateAsync(data);
        var result = _mapper.Map<UpdatedExperienceResponse>(data);
        return result;

    }
}
