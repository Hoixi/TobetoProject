using Business.Dtos.Requests.SchoolNameRequests;
using Business.Dtos.Responses.SchoolNameResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ISchoolNameService
    {
        Task<CreatedSchoolNameResponse> AddAsync(CreateSchoolNameRequest createSchoolNameRequest);
        Task<UpdatedSchoolNameResponse> UpdateAsync(UpdateSchoolNameRequest updateSchoolNameRequest);
        Task<SchoolName> DeleteAsync(int id);
        Task<IPaginate<GetListSchoolNameResponse>> GetAllAsync(PageRequest pageRequest);
        Task<GetListSchoolNameResponse> GetById(int id);

    }
}
