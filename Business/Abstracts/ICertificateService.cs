using Business.Dtos.Requests.CertificateRequests;
using Business.Dtos.Responses.CertificateResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ICertificateService
{
    Task<CreatedCertificateResponse> AddAsync(CreateCertificateRequest createCertificateRequest);
    Task<UpdatedCertificateResponse> UpdateAsync(UpdateCertificateRequest updateCertificateRequest);
    Task<Certificate> DeleteAsync(int id);
    Task<IPaginate<GetListCertificateResponse>> GetAllAsync(PageRequest pageRequest);
    Task<GetListCertificateResponse> GetById(int id);
}

