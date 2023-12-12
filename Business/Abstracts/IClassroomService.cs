using Business.Dtos.Requests.ClassroomRequests;
using Business.Dtos.Responses.ClasroomResponses;
using Business.Dtos.Responses.ClassroomResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

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
