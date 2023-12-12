using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Requests.InstructorRequests;
using Business.Dtos.Responses.CourseResponses;
using Business.Dtos.Responses.InstructorResponse;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest);
        Task<UpdatedInstructorResponse> Update(UpdateInstructorRequest updateInstructorRequest);
        Task<Instructor> Delete(int Id, bool permanent);
        
        Task<CreatedInstructorResponse> GetInstructorById(int id);

        Task<IPaginate<GetInstructorListResponse>> GetListAsync(PageRequest pageRequest);

    }
}
