using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ClassroomStudentRequests;
using Business.Dtos.Responses.ClassroomResponses;
using Business.Dtos.Responses.ClassroomStudentResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

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
            include: s => s
            .Include(cg=>cg.ClassroomGroup).ThenInclude(c=>c.Classroom)
            .Include(cg=>cg.ClassroomGroup).ThenInclude(c=>c.Group)
            
            .Include(s => s.Student)
            .ThenInclude(s => s.User),
            index: pageRequest.PageIndex,
            size: pageRequest.PageSize
            );
        var result = _mapper.Map<Paginate<GetListClassroomStudentResponse>>(data);
        return result;
    }

    public async Task<CreatedClassroomStudentResponse> GetById(int id)
    {
            var data = await _classroomStudentDal.GetAsync(c => c.Id == id);
            var result = _mapper.Map<CreatedClassroomStudentResponse>(data);
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

