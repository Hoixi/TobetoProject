using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CertificateRequests;
using Business.Dtos.Responses.CertificateResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CertificateManager : ICertificateService
    {
        ICertificateDal _certificateDal;
        IMapper _mapper;

        public CertificateManager(ICertificateDal certificateDal, IMapper mapper)
        {
            _certificateDal = certificateDal;
            _mapper = mapper;
        }

        public async Task<CreatedCertificateResponse> AddAsync(CreateCertificateRequest createCertificateRequest)
        {
            Certificate certificate = _mapper.Map<Certificate>(createCertificateRequest);
            Certificate createdCertificate = await _certificateDal.AddAsync(certificate);
            CreatedCertificateResponse createdCertificateResponse = _mapper.Map<CreatedCertificateResponse>(createdCertificate);
            return createdCertificateResponse;
        }

        public async Task<Certificate> DeleteAsync(int id)
        {
            var data = await _certificateDal.GetAsync(i => i.Id == id);
            var result = await _certificateDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListCertificateResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _certificateDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListCertificateResponse>>(data);
            return result;
        }

        public async Task<UpdatedCertificateResponse> UpdateAsync(UpdateCertificateRequest updateCertificateRequest)
        {
            var data = await _certificateDal.GetAsync(i => i.Id == updateCertificateRequest.Id);
            _mapper.Map(updateCertificateRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _certificateDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedCertificateResponse>(data);
            return result;
        }
    }
}
