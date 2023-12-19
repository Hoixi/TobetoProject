using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CityRequests;
using Business.Dtos.Responses.CityResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;
        IMapper _mapper;

        public CityManager(ICityDal cityDal, IMapper mapper)
        {
            _cityDal = cityDal;
            _mapper = mapper;
        }

        public async Task<CreatedCityResponse> AddAsync(CreateCityRequest createCityRequest)
        {
            City city = _mapper.Map<City>(createCityRequest);
            City createdCity = await _cityDal.AddAsync(city);
            CreatedCityResponse createdCityResponse = _mapper.Map<CreatedCityResponse>(createdCity);
            return createdCityResponse;
        }

        public async Task<City> DeleteAsync(int id)
        {
            var data = await _cityDal.GetAsync(i => i.Id == id);
            var result = await _cityDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListCityResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _cityDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListCityResponse>>(data);
            return result;
        }

        public async Task<UpdatedCityResponse> UpdateAsync(UpdateCityRequest updateCityRequest)
        {
            var data = await _cityDal.GetAsync(i => i.Id == updateCityRequest.Id);
            _mapper.Map(updateCityRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _cityDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedCityResponse>(data);
            return result;
        }
    }
}
