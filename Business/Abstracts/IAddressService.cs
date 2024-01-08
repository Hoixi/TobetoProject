using Business.Dtos.Requests.AddressRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.CategoryResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IAddressService
{
    Task<CreatedAddressResponse> AddAsync(CreateAddressRequest createAddressRequest);
    Task<UpdatedAddressResponse> UpdateAsync(UpdateAddressRequest updateAddressRequest);
    Task<Address> DeleteAsync(int id);
    Task<IPaginate<GetListAddressResponse>> GetAllAsync(PageRequest pageRequest);
    Task<CreatedAddressResponse> GetById(int id);
}