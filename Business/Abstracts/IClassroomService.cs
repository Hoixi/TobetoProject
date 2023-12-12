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
        Task<UpdatedClassroomResponse> Update(UpdateClassroomRequest updateClassroomRequest);
        Task<Classroom> Delete(Classroom classroom);
        Task<IPaginate<GetClassroomListResponse>> GetAll();
        Task<CreatedClassroomResponse> GetClassroomById(int id);
    }
}
