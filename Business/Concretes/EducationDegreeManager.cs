using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.EducationDegreeRequests;
using Business.Dtos.Requests.RoleRequests;
using Business.Dtos.Responses.EducationDegreeResponses;
using Business.Dtos.Responses.RoleResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class EducationDegreeManager : IEducationDegreeService
    {
        IEducationDegreeDal _educationDegreeDal;
        IMapper _mapper;


        public EducationDegreeManager(IEducationDegreeDal educationDegreeDal, IMapper mapper)
        {
            _educationDegreeDal = educationDegreeDal;
            _mapper = mapper;
        }

       


        public async Task<CreatedEducationDegreeResponse> AddAsync(CreateEducationDegreeRequest createEducationDegreeRequest)
        {

            EducationDegree educationDegree = _mapper.Map<EducationDegree>(createEducationDegreeRequest);
            EducationDegree createdEducationDegree = await _educationDegreeDal.AddAsync(educationDegree);
            CreatedEducationDegreeResponse createdEducationDegreeResponse = _mapper.Map<CreatedEducationDegreeResponse>(createdEducationDegree);

            return createdEducationDegreeResponse;

        }

        public async Task<EducationDegree> DeleteAsync(int id)
        {
            var data = await _educationDegreeDal.GetAsync(i => i.Id == id);
            var result = await _educationDegreeDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListEducationDegreeResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _educationDegreeDal.GetListAsync(
           index: pageRequest.PageIndex,
           size: pageRequest.PageSize
           );
            var result = _mapper.Map<Paginate<GetListEducationDegreeResponse>>(data);
            return result;
        }

        public async Task<UpdatedEducationDegreeResponse> UpdateAsync(UpdateEducationDegreeRequest updateEducationDegreeRequest)
        {
            var data = await _educationDegreeDal.GetAsync(i => i.Id == updateEducationDegreeRequest.Id);
            _mapper.Map(updateEducationDegreeRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _educationDegreeDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedEducationDegreeResponse>(data);
            return result;

        }
    }
}
