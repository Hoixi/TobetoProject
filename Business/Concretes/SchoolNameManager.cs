using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.AddressRequests;
using Business.Dtos.Requests.SchoolNameRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.SchoolNameResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
    public class SchoolNameManager : ISchoolNameService
    {
        ISchoolNameDal _schoolNameDal;
        IMapper _mapper;

        public SchoolNameManager(ISchoolNameDal schoolNameDal, IMapper mapper)
        {
            _schoolNameDal = schoolNameDal;
            _mapper = mapper;
        }

        public async Task<CreatedSchoolNameResponse> Add(CreateSchoolNameRequest createSchoolNameRequest)
        {
            SchoolName schoolName = _mapper.Map<SchoolName>(createSchoolNameRequest);
            SchoolName createdSchoolName = await _schoolNameDal.AddAsync(schoolName);
            CreatedSchoolNameResponse createdSchoolNameResponse = _mapper.Map<CreatedSchoolNameResponse>(createdSchoolName);
            return createdSchoolNameResponse;

        }

        public async Task<SchoolName> Delete(int id)
        {
            var data = await _schoolNameDal.GetAsync(i => i.Id == id);
            var result = await _schoolNameDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListSchoolNameResponse>> GetAll(PageRequest pageRequest)
        {
            var data = await _schoolNameDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListSchoolNameResponse>>(data);
            return result;
        }

        public async Task<UpdatedSchoolNameResponse> Update(UpdateSchoolNameRequest updateSchoolNameRequest)
        {
            var data = await _schoolNameDal.GetAsync(i => i.Id == updateSchoolNameRequest.Id);
            _mapper.Map(updateSchoolNameRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _schoolNameDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedSchoolNameResponse>(data);
            return result;
        }
    }
}
