using Business.Dtos.Requests.StudentRequests;
using Business.Dtos.Responses.AddressResponses;
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
        Task<CreatedStudentResponse> AddAsync(CreateStudentRequest createStudentRequest);
        Task<UpdatedStudentResponse> UpdateAsync(UpdateStudentRequest updateStudentRequest);
        Task<Student> DeleteAsync(int id);
        Task<IPaginate<GetListStudentResponse>> GetAllAsync(PageRequest pageRequest);
        Task<CreatedStudentResponse> GetById(int id);
    }
}
