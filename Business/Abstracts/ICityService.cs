using Business.Dtos.Requests.CityRequests;
using Business.Dtos.Responses.CityResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ICityService
{
    Task<CreatedCityResponse> AddAsync(CreateCityRequest createCityRequest);
    Task<UpdatedCityResponse> UpdateAsync(UpdateCityRequest updateCityRequest);
    Task<City> DeleteAsync(int id);
    Task<IPaginate<GetListCityResponse>> GetAllAsync(PageRequest pageRequest);
}
