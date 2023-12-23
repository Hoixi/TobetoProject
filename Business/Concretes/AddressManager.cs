using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.AddressRequests;
using Business.Dtos.Responses.AddressResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;
        IMapper _mapper;

        public AddressManager(IAddressDal addressDal, IMapper mapper)
        {
            _addressDal = addressDal;
            _mapper = mapper;

        }
        public async Task<CreatedAddressResponse> AddAsync(CreateAddressRequest createAddressRequest)
        {
            Address address = _mapper.Map<Address>(createAddressRequest);
            Address createdAddress = await _addressDal.AddAsync(address);
            CreatedAddressResponse createdAddressResponse = _mapper.Map<CreatedAddressResponse>(createdAddress);
            return createdAddressResponse;
        }

        public async Task<Address> DeleteAsync(int id)
        {
            var data = await _addressDal.GetAsync(i => i.Id == id);
            var result = await _addressDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListAddressResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _addressDal.GetListAsync(
                include: p => p
                .Include(p => p.Town)
                .Include(c => c.Country)
                .Include(ct => ct.City),    
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListAddressResponse>>(data);
            return result;
        }

        public async Task<UpdatedAddressResponse> UpdateAsync(UpdateAddressRequest updateAddressRequest)
        {
            var data = await _addressDal.GetAsync(i => i.Id == updateAddressRequest.Id);
            _mapper.Map(updateAddressRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _addressDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedAddressResponse>(data);
            return result;
        }
    }
}
