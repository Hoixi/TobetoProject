using Business.Dtos.Requests.StudentRequests;
using Business.Dtos.Responses.StudentResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IStudentService
    {
        Task<CreatedStudentResponse> Add(CreateStudentRequest createStudentRequest);
        Task<UpdatedStudentResponse> Update(UpdateStudentRequest updateStudentRequest);
        Task<Student> Delete(int id);
        Task<IPaginate<GetListStudentResponse>> GetAll(PageRequest pageRequest);
    }
}
