using Business.Dtos.Requests.AddressRequests;
using Business.Dtos.Responses.AddressResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IAddressService
{
    Task<CreatedAddressResponse> AddAsync(CreateAddressRequest createCustomerRequest);
    Task<UpdatedAddressResponse> UpdateAsync(UpdateAddressRequest updateCustomerRequest);
    Task<Address> DeleteAsync(int id);
    Task<IPaginate<GetListAddressResponse>> GetAllAsync(PageRequest pageRequest);
}