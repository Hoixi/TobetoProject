using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.AddressRequests;
using Business.Dtos.Requests.ProgrammingLanguageRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.LanguageResponses;
using Business.Dtos.Responses.ProgrammingLanguageResponses;
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
    public class ProgrammingLanguageManager : IProgrammingLanguageService
    {
        IProgrammingLanguageDal _programmingLanguageDal;
        IMapper _mapper;

        public ProgrammingLanguageManager(IProgrammingLanguageDal programmingLanguageDal, IMapper mapper)
        {
            _programmingLanguageDal = programmingLanguageDal;
            _mapper = mapper;
        }

        public async Task<CreatedProgrammingLanguageResponse> AddAsync(CreateProgrammingLanguageRequest createProgrammingLanguageRequest)
        {
            ProgrammingLanguage programmingLanguage = _mapper.Map<ProgrammingLanguage>(createProgrammingLanguageRequest);
            ProgrammingLanguage createdprogrammingLanguage = await _programmingLanguageDal.AddAsync(programmingLanguage);
            CreatedProgrammingLanguageResponse createdProgrammingLanguageResponse = _mapper.Map<CreatedProgrammingLanguageResponse>(createdprogrammingLanguage);
            return createdProgrammingLanguageResponse;
        }

        public async Task<ProgrammingLanguage> DeleteAsync(int id)
        {
            var data = await _programmingLanguageDal.GetAsync(i => i.Id == id);
            var result = await _programmingLanguageDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListProgrammingLanguageResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _programmingLanguageDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListProgrammingLanguageResponse>>(data);
            return result;
        }

        public async Task<CreatedProgrammingLanguageResponse> GetById(int id)
        {
            var data = await _programmingLanguageDal.GetAsync(c => c.Id == id);
            var result = _mapper.Map<CreatedProgrammingLanguageResponse>(data);
            return result;
        }

        public async Task<UpdatedProgrammingLanguageResponse> UpdateAsync(UpdateProgrammingLanguageRequest updateProgrammingLanguageRequest)
        {
            var data = await _programmingLanguageDal.GetAsync(i => i.Id == updateProgrammingLanguageRequest.Id);
            _mapper.Map(updateProgrammingLanguageRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _programmingLanguageDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedProgrammingLanguageResponse>(data);
            return result;
        }
    }
}
