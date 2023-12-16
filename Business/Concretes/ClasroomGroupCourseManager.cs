using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ClassroomGroupCourseRequest;
using Business.Dtos.Requests.ClassroomGroupCourseRequests;
using Business.Dtos.Requests.ClassroomRequests;
using Business.Dtos.Responses.ClasroomResponses;
using Business.Dtos.Responses.ClassroomGroupCourseResponses;
using Business.Dtos.Responses.GroupResponse;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class ClasroomGroupCourseManager : IClassroomGroupCourseService
{
    IClassroomGroupCourseDal _classroomGroupCourseDal;
    IMapper _mapper;

    public ClasroomGroupCourseManager(IClassroomGroupCourseDal classroomGroupCourseDal,IMapper mapper)
    {
        _classroomGroupCourseDal = classroomGroupCourseDal;
        _mapper = mapper;
    }

    public async Task<CreatedClassroomGroupCourseResponse> Add(CreateClassroomGroupCourseRequest createClassroomGroupCourseRequest)
    {
        ClassroomGroupCourse classroomGroupCourse = _mapper.Map<ClassroomGroupCourse>(createClassroomGroupCourseRequest);
        ClassroomGroupCourse createdClassroomGroupCourse = await _classroomGroupCourseDal.AddAsync(classroomGroupCourse);
        CreatedClassroomGroupCourseResponse createdClassroomGroupCourseResponse = _mapper.Map<CreatedClassroomGroupCourseResponse>(createdClassroomGroupCourse);
        return createdClassroomGroupCourseResponse;
    }

    public async Task<ClassroomGroupCourse> Delete(int Id, bool permanent)
    {
        var data = await _classroomGroupCourseDal.GetAsync(i => i.Id == Id);
        var result = await _classroomGroupCourseDal.DeleteAsync(data, permanent);
        return result;

    }

    public async Task<IPaginate<GetClassroomGroupCourseListResponse>> GetAll(PageRequest pageRequest)
    {
        var data = await _classroomGroupCourseDal.GetListAsync(
            index: pageRequest.PageIndex,
            size: pageRequest.PageSize
            );
        var result = _mapper.Map<Paginate<GetClassroomGroupCourseListResponse>>(data);
        return result;

    }

    public async Task<CreatedClassroomGroupCourseResponse> GetClassroomGroupCourseById(int id)
    {
        var data = await _classroomGroupCourseDal.GetAsync(i=>i.Id == id);
        var result = _mapper.Map<CreatedClassroomGroupCourseResponse>(data);
        return result;
    }


    public async Task<UpdatedClassroomGroupCourseResponse> Update(UpdateClassroomGroupCourseRequest updateClassroomGroupCourseRequest)
    {
        var data = await _classroomGroupCourseDal.GetAsync(i => i.Id == updateClassroomGroupCourseRequest.Id);
        _mapper.Map(updateClassroomGroupCourseRequest, data);
        data.UpdatedDate = DateTime.Now;
        await _classroomGroupCourseDal.UpdateAsync(data);
        var result = _mapper.Map<UpdatedClassroomGroupCourseResponse>(data);
        return result;


    }
}
