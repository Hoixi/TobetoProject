using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ClassroomGroupCourseRequests;
using Business.Dtos.Responses.CategoryResponses;
using Business.Dtos.Responses.ClassroomGroupCourseResponses;
using Business.Dtos.Responses.UserSurveyResponses;
using Core.Aspects.Autofac.Caching;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
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

    [CacheAspect]
    public async Task<IPaginate<GetListClassroomGroupCourseResponse>> GetAllAsync(PageRequest pageRequest)
    {
        var data = await _classroomGroupCourseDal.GetListAsync(

            include: cgc => cgc
            .Include(cgc => cgc.ClassroomGroups).ThenInclude(cgc => cgc.Classroom)
            .Include(cgc => cgc.ClassroomGroups).ThenInclude(cgc => cgc.Group)
            .Include(cgc => cgc.Courses),

            index: pageRequest.PageIndex,
            size: pageRequest.PageSize
            );
        var result = _mapper.Map<Paginate<GetListClassroomGroupCourseResponse>>(data);
        return result;
    }

    public async Task<GetListClassroomGroupCourseResponse> GetById(int id)
    {
        var data = await _classroomGroupCourseDal.GetAsync(
            c => c.Id == id,
            include: cgc => cgc
            .Include(cgc => cgc.ClassroomGroups).ThenInclude(cgc => cgc.Classroom)
            .Include(cgc => cgc.ClassroomGroups).ThenInclude(cgc => cgc.Group)
            .Include(cgc => cgc.Courses)
            );
        var result = _mapper.Map<GetListClassroomGroupCourseResponse>(data);
        return result;
    }

    public async Task<IPaginate<GetListClassroomGroupCourseResponse>> GetListByClassroomGroupId(int classroomGroupId, PageRequest pageRequest)
    {
        var data = await _classroomGroupCourseDal.GetListAsync(
                predicate: u => u.ClassroomGroupId == classroomGroupId,
                include: cgc => cgc
                .Include(cgc => cgc.ClassroomGroups).ThenInclude(cgc => cgc.Classroom)
                .Include(cgc => cgc.ClassroomGroups).ThenInclude(cgc => cgc.Group)
                .Include(cgc => cgc.Courses),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
        var result = _mapper.Map<Paginate<GetListClassroomGroupCourseResponse>>(data);
        return result;
    }

    public async Task<IPaginate<GetListClassroomGroupCourseResponse>> GetListByCourseId(int courseId, PageRequest pageRequest)
    {
        var data = await _classroomGroupCourseDal.GetListAsync(
                predicate: u => u.CourseId == courseId,
                include: cgc => cgc
                .Include(cgc => cgc.ClassroomGroups).ThenInclude(cgc => cgc.Classroom)
                .Include(cgc => cgc.ClassroomGroups).ThenInclude(cgc => cgc.Group)
                .Include(cgc => cgc.Courses),
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

