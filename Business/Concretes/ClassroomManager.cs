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

    public async Task<Classroom> Delete(Classroom classroom)
    {
        var data = await _classroomDal.GetAsync(c => c.Id == classroom.Id);
        var result=await _classroomDal.DeleteAsync(data,true);
        return result;

    }

    public async Task<IPaginate<GetClassroomListResponse>> GetAll()
    {
        var data= await _classroomDal.GetListAsync();
        var result = _mapper.Map<Paginate<GetClassroomListResponse>>(data);
        return result;
    }

    public async Task<CreatedClassroomResponse> GetClassroomById(int id)
    {
        var data = await _classroomDal.GetAsync(c=>c.Id==id);
        var result = _mapper.Map<CreatedClassroomResponse>(data);
        return result;
    }

    public async Task<UpdatedClassroomResponse> Update(UpdateClassroomRequest updateClassroomRequest)
    {
        var data=await _classroomDal.GetAsync(c=>c.Id == updateClassroomRequest.Id);
        _mapper.Map(updateClassroomRequest, data);
        data.UpdatedDate= DateTime.Now;
        await _classroomDal.UpdateAsync(data);
        var result= _mapper.Map<UpdatedClassroomResponse>(data);
        return result;


    }
}

