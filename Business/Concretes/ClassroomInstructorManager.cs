using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ClassroomInstructorRequests;
using Business.Dtos.Responses.ClassroomInstructorResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class ClassroomInstructorManager : IClassroomInstructorService
{
    IClassroomInstructorDal _classroomInstructorDal;
    IMapper _mapper;

    public ClassroomInstructorManager(IClassroomInstructorDal classroomInstructorDal, IMapper mapper)
    {
        _classroomInstructorDal = classroomInstructorDal;
        _mapper = mapper;
    }

    public async Task<CreatedClassroomInstructorResponse> AddAsync(CreateClassroomInstructorRequest createClassroomInstructorRequest)
    {
        ClassroomInstructor classroomInstructor = _mapper.Map<ClassroomInstructor>(createClassroomInstructorRequest);
        ClassroomInstructor createdClassroomInstructor = await _classroomInstructorDal.AddAsync(classroomInstructor);
        CreatedClassroomInstructorResponse createdClassroomInstructorResponse = _mapper.Map<CreatedClassroomInstructorResponse>(createdClassroomInstructor);
        return createdClassroomInstructorResponse;
    }

    public async Task<ClassroomInstructor> DeleteAsync(int Id)
    {
        var data = await _classroomInstructorDal.GetAsync(i => i.Id == Id);
        var result = await _classroomInstructorDal.DeleteAsync(data);
        return result;
    }

    public async Task<IPaginate<GetListClassroomInstructorResponse>> GetAllAsync(PageRequest pageRequest)
    {
        var data = await _classroomInstructorDal.GetListAsync(
            include : ci => ci.Include(cl=>cl.Instructor).ThenInclude(u => u.User),
            index: pageRequest.PageIndex,
            size: pageRequest.PageSize
            );
        var result = _mapper.Map<Paginate<GetListClassroomInstructorResponse>>(data);
        return result;
    }

    public async Task<UpdatedClassroomInstructorResponse> UpdateAsync(UpdateClassroomInstructorRequest updateClassroomInstructorRequest)
    {
        var data = await _classroomInstructorDal.GetAsync(i => i.Id == updateClassroomInstructorRequest.Id);
        _mapper.Map(updateClassroomInstructorRequest, data);
        data.UpdatedDate = DateTime.Now;
        await _classroomInstructorDal.UpdateAsync(data);
        var result = _mapper.Map<UpdatedClassroomInstructorResponse>(data);
        return result;

    }


}

