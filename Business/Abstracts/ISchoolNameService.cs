using Business.Dtos.Requests.SchoolNameRequests;
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
        Task<CreatedSchoolNameResponse> Add(CreateSchoolNameRequest createSchoolNameRequest);
        Task<UpdatedSchoolNameResponse> Update(UpdateSchoolNameRequest updateSchoolNameRequest);
        Task<SchoolName> Delete(int id);
        Task<IPaginate<GetListSchoolNameResponse>> GetAll(PageRequest pageRequest);
    }
}
