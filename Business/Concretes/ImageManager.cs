using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Requests.ImageRequests;
using Business.Dtos.Responses.CourseResponses;
using Business.Dtos.Responses.ImageResponse;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;
        IMapper _mapper;

        public ImageManager(IImageDal imageDal, IMapper mapper)
        {
            _imageDal = imageDal;
            _mapper = mapper;
        }

        public async Task<CreatedImageResponse> Add(CreateImageRequest createImageRequest)
        {
            Image image = _mapper.Map<Image>(createImageRequest);
            Image createdImage = await _imageDal.AddAsync(image);
            CreatedImageResponse createdImageResponse = _mapper.Map<CreatedImageResponse>(createdImage);
            return createdImageResponse;
        }

        public async Task<Image> Delete(int Id, bool permanent)
        {
            var data = await _imageDal.GetAsync(i => i.Id == Id);
            var result = await _imageDal.DeleteAsync(data, permanent);
            return result;
        }

        public async Task<IPaginate<GetImageListResponse>> GetAll(PageRequest pageRequest)
        {
            var data = await _imageDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
                );
            var result = _mapper.Map<Paginate<GetImageListResponse>>(data);
            return result;
        }

        public async Task<CreatedImageResponse> GetImageById(int id)
        {
            var data = await _imageDal.GetAsync(i => i.Id == id);
            var result = _mapper.Map<CreatedImageResponse>(data);
            return result;
        }

        public async Task<UpdatedImageResponse> Update(UpdateImageRequest updateImageRequest)
        {
            var data = await _imageDal.GetAsync(i => i.Id == updateImageRequest.Id);
            _mapper.Map(updateImageRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _imageDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedImageResponse>(data);
            return result;
        }
    }
}
