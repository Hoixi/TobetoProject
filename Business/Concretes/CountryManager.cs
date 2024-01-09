using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CountryRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.CompanyResponses;
using Business.Dtos.Responses.CountryResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal;
        IMapper _mapper;

        public CountryManager(ICountryDal countryDal, IMapper mapper)
        {
            _countryDal = countryDal;
            _mapper = mapper;
        }

        public async Task<CreatedCountryResponse> AddAsync(CreateCountryRequest createCountryRequest)
        {
            Country country = _mapper.Map<Country>(createCountryRequest);
            Country createdCountry = await _countryDal.AddAsync(country);
            CreatedCountryResponse createdCountryResponse = _mapper.Map<CreatedCountryResponse>(createdCountry);
            return createdCountryResponse;
        }

        public async Task<Country> DeleteAsync(int id)
        {
            var data = await _countryDal.GetAsync(i => i.Id == id);
            var result = await _countryDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListCountryResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _countryDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListCountryResponse>>(data);
            return result;
        }

        public async Task<CreatedCountryResponse> GetById(int id)
        {
            var data = await _countryDal.GetAsync(c => c.Id == id);
            var result = _mapper.Map<CreatedCountryResponse>(data);
            return result;
        }

        public async Task<UpdatedCountryResponse> UpdateAsync(UpdateCountryRequest updateCountryRequest)
        {
            var data = await _countryDal.GetAsync(i => i.Id == updateCountryRequest.Id);
            _mapper.Map(updateCountryRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _countryDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedCountryResponse>(data);
            return result;
        }
    }
}
