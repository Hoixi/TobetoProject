using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Requests.ImageRequests;
using Business.Dtos.Responses.CourseResponses;
using Business.Dtos.Responses.ImageResponse;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IImageService
    {
        Task<CreatedImageResponse> Add(CreateImageRequest createImageRequest);
        Task<UpdatedImageResponse> Update(UpdateImageRequest updateImageRequest);
        Task<Image> Delete(int Id, bool permanent);
        Task<IPaginate<GetImageListResponse>> GetAll();
        Task<CreatedImageResponse> GetImageById(int id);


    }
}
