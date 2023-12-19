using Business.Dtos.Requests.CountryRequests;
using Business.Dtos.Responses.CountryResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ICountryService
{
    Task<CreatedCountryResponse> AddAsync(CreateCountryRequest createCountryRequest);
    Task<UpdatedCountryResponse> UpdateAsync(UpdateCountryRequest updateCountryRequest);
    Task<Country> DeleteAsync(int id);
    Task<IPaginate<GetListCountryResponse>> GetAllAsync(PageRequest pageRequest);
}