using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ClassroomGroupCourseRequests;
using Business.Dtos.Responses.ClassroomGroupCourseResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class ClassroomGroupCourseManager : IClassroomGroupCourseService
{
    IClassroomGroupCourseDal _classroomGroupCourseDal;
    IMapper _mapper;

    public ClassroomGroupCourseManager(IClassroomGroupCourseDal classroomGroupCourseDal, IMapper mapper)
    {
        _classroomGroupCourseDal = classroomGroupCourseDal;
        _mapper = mapper;
    }

    public async Task<CreatedClassroomGroupCourseResponse> AddAsync(CreateClassroomGroupCourseRequest createClassroomGroupCourseRequest)
    {
        ClassroomGroupCourse classroomGroupCourse = _mapper.Map<ClassroomGroupCourse>(createClassroomGroupCourseRequest);
        ClassroomGroupCourse createdClassroomGroupCourse = await _classroomGroupCourseDal.AddAsync(classroomGroupCourse);
        CreatedClassroomGroupCourseResponse createdClassroomGroupCourseResponse = _mapper.Map<CreatedClassroomGroupCourseResponse>(createdClassroomGroupCourse);
        return createdClassroomGroupCourseResponse;
    }

    public async Task<ClassroomGroupCourse> DeleteAsync(int Id)
    {
        var data = await _classroomGroupCourseDal.GetAsync(i => i.Id == Id);
        var result = await _classroomGroupCourseDal.DeleteAsync(data);
        return result;
    }

    public async Task<IPaginate<GetListClassroomGroupCourseResponse>> GetAllAsync(PageRequest pageRequest)
    {
        var data = await _classroomGroupCourseDal.GetListAsync(

            include: cgc=>cgc
            .Include(cgc=>cgc.ClassroomGroups).ThenInclude(cgc => cgc.Classroom)
            .Include(cgc=>cgc.Courses),

            index: pageRequest.PageIndex,
            size: pageRequest.PageSize
            );
        var result = _mapper.Map<Paginate<GetListClassroomGroupCourseResponse>>(data);
        return result;
    }

    public async Task<UpdatedClassroomGroupCourseResponse> UpdateAsync(UpdateClassroomGroupCourseRequest updateClassroomGroupCourseRequest)
    {
        var data = await _classroomGroupCourseDal.GetAsync(i => i.Id == updateClassroomGroupCourseRequest.Id);
        _mapper.Map(updateClassroomGroupCourseRequest, data);
        data.UpdatedDate = DateTime.Now;
        await _classroomGroupCourseDal.UpdateAsync(data);
        var result = _mapper.Map<UpdatedClassroomGroupCourseResponse>(data);
        return result;

    }

}

