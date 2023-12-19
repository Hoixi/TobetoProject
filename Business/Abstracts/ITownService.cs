using Business.Dtos.Requests.TownRequests;
using Business.Dtos.Responses.TownResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ITownService
    {
        Task<CreatedTownResponse> Add(CreateTownRequest createTownRequest);
        Task<UpdatedTownResponse> Update(UpdateTownRequest updateTownRequest);
        Task<Town> Delete(int id);
        Task<IPaginate<GetListTownResponse>> GetAll(PageRequest pageRequest);
    }
}
