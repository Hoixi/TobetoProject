using Business.Dtos.Requests.CertificateRequests;
using Business.Dtos.Requests.ImageRequests;
using Business.Dtos.Responses.CertificateResponses;
using Business.Dtos.Responses.GroupResponses;
using Business.Dtos.Responses.ImageResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IImageService
{
    Task<CreatedImageResponse> AddAsync(CreateImageRequest createImageRequest);
    Task<UpdatedImageResponse> UpdateAsync(UpdateImageRequest updateImageRequest);
    Task<Image> DeleteAsync(int id);
    Task<IPaginate<GetListImageResponse>> GetAllAsync(PageRequest pageRequest);
    Task<GetListImageResponse> GetById(int id);

}

