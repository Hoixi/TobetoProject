using Business.Dtos.Requests.TownRequests;
using Business.Dtos.Responses.TownResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ITownService
    {
        Task<CreatedTownResponse> AddAsync(CreateTownRequest createTownRequest);
        Task<UpdatedTownResponse> UpdateAsync(UpdateTownRequest updateTownRequest);
        Task<Town> DeleteAsync(int id);
        Task<IPaginate<GetListTownResponse>> GetAllAsync(PageRequest pageRequest);
        Task<GetListTownResponse> GetById(int id);
        Task<IPaginate<GetListByCityIdResponse>> GetListByCityId(PageRequest pageRequest, int cityId);
    }
}
