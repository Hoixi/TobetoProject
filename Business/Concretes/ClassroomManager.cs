using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ClassroomRequests;
using Business.Dtos.Responses.ClasroomResponses;
using Business.Dtos.Responses.ClassroomResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;


public class ClassroomManager : IClassroomService
{
    IClassroomDal _classroomDal;
    IMapper _mapper;

    public ClassroomManager(IClassroomDal classroomDal, IMapper mapper)
    {
        _classroomDal = classroomDal;
        _mapper = mapper;
    }

    public async Task<CreatedClassroomResponse> Add(CreateClassroomRequest createClassroomRequest)
    {
        Classroom classroom = _mapper.Map<Classroom>(createClassroomRequest);
        Classroom createdClassroom = await _classroomDal.AddAsync(classroom);
        CreatedClassroomResponse createClassroomResponse = _mapper.Map<CreatedClassroomResponse>(createdClassroom);
        return createClassroomResponse;
    }

    public Task<CreatedClassroomResponse> Delete(Classroom classRoom)
    {
        throw new NotImplementedException();
    }

    public Task<IPaginate<GetClassroomListResponse>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<CreatedClassroomResponse> GetClassById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CreatedClassroomResponse> Update(Classroom classRoom)
    {
        throw new NotImplementedException();
    }
}

