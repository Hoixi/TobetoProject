using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseCompanyRequests;
using Business.Dtos.Requests.EducationRequests;
using Business.Dtos.Responses.CourseCompanyResponses;
using Business.Dtos.Responses.EducationDegreeResponses;
using Business.Dtos.Responses.EducationResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;
        IMapper _mapper;

        public EducationManager(IEducationDal educationDal, IMapper mapper)
        {
            _educationDal = educationDal;
            _mapper = mapper;
        }

        public async Task<CreatedEducationResponse> AddAsync(CreateEducationRequest createEducationRequest)
        {
            Education education = _mapper.Map<Education>(createEducationRequest);
            Education createdEducation = await _educationDal.AddAsync(education);
            CreatedEducationResponse createdEducationResponse = _mapper.Map<CreatedEducationResponse>(createdEducation);
            return createdEducationResponse;
        }

        public async Task<Education> DeleteAsync(int id)
        {
            var data = await _educationDal.GetAsync(i => i.Id == id);
            var result = await _educationDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListEducationResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _educationDal.GetListAsync(include: p=>p
            .Include(p => p.SchoolName)
            .Include(p => p.EducationDegree),

                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListEducationResponse>>(data);
            return result;
        }

        public async  Task<CreatedEducationResponse> GetById(int id)
        {
            var data = await _educationDal.GetAsync(c => c.Id == id);
            var result = _mapper.Map<CreatedEducationResponse>(data);
            return result;
        }

        public async Task<UpdatedEducationResponse> UpdateAsync(UpdateEducationRequest updateEducationRequest)
        {
            var data = await _educationDal.GetAsync(i => i.Id == updateEducationRequest.Id);
            _mapper.Map(updateEducationRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _educationDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedEducationResponse>(data);
            return result;
        }
    }
}
