using Business.Dtos.Requests.SchoolNameRequests;
using Business.Dtos.Responses.ProgrammingLanguageResponses;
using Business.Dtos.Responses.SchoolNameResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ISchoolNameService
    {
        Task<CreatedSchoolNameResponse> AddAsync(CreateSchoolNameRequest createSchoolNameRequest);
        Task<UpdatedSchoolNameResponse> UpdateAsync(UpdateSchoolNameRequest updateSchoolNameRequest);
        Task<SchoolName> DeleteAsync(int id);
        Task<IPaginate<GetListSchoolNameResponse>> GetAllAsync(PageRequest pageRequest);
        Task<CreatedSchoolNameResponse> GetById(int id);

    }
}
