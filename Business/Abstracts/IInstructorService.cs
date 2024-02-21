using Business.Dtos.Requests.CertificateRequests;
using Business.Dtos.Requests.InstructorRequests;
using Business.Dtos.Responses.CertificateResponses;
using Business.Dtos.Responses.ImageResponses;
using Business.Dtos.Responses.InstructorResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IInstructorService
{
    Task<CreatedInstructorResponse> AddAsync(CreateInstructorRequest createInstructorRequest);
    Task<UpdatedInstructorResponse> UpdateAsync(UpdateInstructorRequest updateInstructorRequest);
    Task<Instructor> DeleteAsync(int id);
    Task<IPaginate<GetListInstructorResponse>> GetAllAsync(PageRequest pageRequest);
    Task<GetListInstructorResponse> GetById(int id);

}

