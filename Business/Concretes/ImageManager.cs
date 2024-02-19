using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.GroupRequests;
using Business.Dtos.Requests.ImageRequests;
using Business.Dtos.Responses.GroupResponses;
using Business.Dtos.Responses.ImageResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class ImageManager : IImageService
{
    IImageDal _imageDal;
    IMapper _mapper;


    public ImageManager(IImageDal imageDal, IMapper mapper)
    {
        _imageDal = imageDal;
        _mapper = mapper;
    }
       

    public async Task<CreatedImageResponse> AddAsync(CreateImageRequest createImageRequest)
    {
        Image image = _mapper.Map<Image>(createImageRequest);
        Image createdImage = await _imageDal.AddAsync(image);
        CreatedImageResponse createdImageResponse = _mapper.Map<CreatedImageResponse>(createdImage);
        return createdImageResponse;
    }

    public async Task<Image> DeleteAsync(int id)
    {
        var data = await _imageDal.GetAsync(i => i.Id == id);
        var result = await _imageDal.DeleteAsync(data);
        return result;
    }

    public async Task<IPaginate<GetListImageResponse>> GetAllAsync(PageRequest pageRequest)
    {
        var data = await _imageDal.GetListAsync(
             index: pageRequest.PageIndex,
             size: pageRequest.PageSize
             );
        var result = _mapper.Map<Paginate<GetListImageResponse>>(data);
        return result;
    }

    public async Task<GetListImageResponse> GetById(int id)
    {
        var data = await _imageDal.GetAsync(c => c.Id == id);
        var result = _mapper.Map<GetListImageResponse>(data);
        return result;
    }

    public async Task<UpdatedImageResponse> UpdateAsync(UpdateImageRequest updateImageRequest)
    {
        var data = await _imageDal.GetAsync(i => i.Id == updateImageRequest.Id);
        _mapper.Map(updateImageRequest, data);
        data.UpdatedDate = DateTime.Now;
        await _imageDal.UpdateAsync(data);
        var result = _mapper.Map<UpdatedImageResponse>(data);
        return result;
    }
}
