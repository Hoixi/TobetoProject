using Business.Dtos.Requests.InstructorRequests;
using Business.Dtos.Requests.StudentRequests;
using Business.Dtos.Responses.InstructorResponse;
using Business.Dtos.Responses.StudentResponse;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IStudentService
{
    Task<CreatedStudentResponse> Add(CreateStudentRequest createStudentRequest);
    Task<UpdatedStudentResponse> Update(UpdateStudentRequest updateStudentRequest);
    Task<Student> Delete(int Id, bool permanent);

    Task<CreatedStudentResponse> GetStudentById(int id);

    Task<IPaginate<GetStudentListResponse>> GetListAsync(PageRequest pageRequest);
}
