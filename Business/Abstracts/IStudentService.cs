using Business.Dtos.Requests.StudentRequests;
using Business.Dtos.Responses.StudentResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IStudentService
    {
        Task<CreatedStudentResponse> AddAsync(CreateStudentRequest createStudentRequest);
        Task<UpdatedStudentResponse> UpdateAsync(UpdateStudentRequest updateStudentRequest);
        Task<Student> DeleteAsync(int id);
        Task<IPaginate<GetListStudentResponse>> GetAllAsync(PageRequest pageRequest);
        Task<GetListStudentResponse> GetById(int id);
        Task<GetListStudentResponse> GetByUserId(int id);
    }
}
