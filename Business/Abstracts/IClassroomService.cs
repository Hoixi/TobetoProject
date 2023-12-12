using Business.Dtos.Requests.ClassroomRequests;
using Business.Dtos.Responses.ClasroomResponses;
using Business.Dtos.Responses.ClassroomResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IClassroomService
    {
        Task<CreatedClassroomResponse> Add(CreateClassroomRequest createClassroomRequest);
        Task<CreatedClassroomResponse> Update(Classroom classRoom);
        Task<CreatedClassroomResponse> Delete(Classroom classRoom);

        Task<IPaginate<GetClassroomListResponse>> GetAll();
        Task<CreatedClassroomResponse> GetClassById(int id);
    }
}
