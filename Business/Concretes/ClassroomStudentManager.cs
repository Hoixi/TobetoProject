using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ClassroomStudentRequests;
using Business.Dtos.Responses.ClassroomStudentResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class ClassroomStudentManager : IClassroomStudentService
{
    IClassroomStudentDal _classroomStudentDal;
    IMapper _mapper;

    public ClassroomStudentManager(IClassroomStudentDal classroomStudentDal, IMapper mapper)
    {
        _classroomStudentDal = classroomStudentDal;
        _mapper = mapper;
    }

    public async Task<CreatedClassroomStudentResponse> AddAsync(CreateClassroomStudentRequest createClassroomStudentRequest)
    {
        ClassroomStudent classroomStudent = _mapper.Map<ClassroomStudent>(createClassroomStudentRequest);
        ClassroomStudent createdClassroomStudent = await _classroomStudentDal.AddAsync(classroomStudent);
        CreatedClassroomStudentResponse createdClassroomStudentResponse = _mapper.Map<CreatedClassroomStudentResponse>(createdClassroomStudent);
        return createdClassroomStudentResponse;
    }

    public async Task<ClassroomStudent> DeleteAsync(int Id)
    {
        var data = await _classroomStudentDal.GetAsync(i => i.Id == Id);
        var result = await _classroomStudentDal.DeleteAsync(data);
        return result;
    }

    public async Task<IPaginate<GetListClassroomStudentResponse>> GetAllAsync(PageRequest pageRequest)
    {
        var data = await _classroomStudentDal.GetListAsync(
            index: pageRequest.PageIndex,
            size: pageRequest.PageSize
            );
        var result = _mapper.Map<Paginate<GetListClassroomStudentResponse>>(data);
        return result;
    }

    public async Task<UpdatedClassroomStudentResponse> UpdateAsync(UpdateClassroomStudentRequest updateClassroomStudentRequest)
    {
        var data = await _classroomStudentDal.GetAsync(i => i.Id == updateClassroomStudentRequest.Id);
        _mapper.Map(updateClassroomStudentRequest, data);
        data.UpdatedDate = DateTime.Now;
        await _classroomStudentDal.UpdateAsync(data);
        var result = _mapper.Map<UpdatedClassroomStudentResponse>(data);
        return result;

    }


}

