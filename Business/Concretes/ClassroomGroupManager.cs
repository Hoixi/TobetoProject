using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ClassroomGroupRequests;
using Business.Dtos.Responses.ClassroomGroupResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class ClassroomGroupManager : IClassroomGroupService
{
    IClassroomGroupDal _classroomGroupDal;
    IMapper _mapper;

    public ClassroomGroupManager(IClassroomGroupDal classroomGroupDal, IMapper mapper)
    {
        _classroomGroupDal = classroomGroupDal;
        _mapper = mapper;
    }

    public async Task<CreatedClassroomGroupResponse> AddAsync(CreateClassroomGroupRequest createClassroomGroupRequest)
    {
        ClassroomGroup classroomGroup = _mapper.Map<ClassroomGroup>(createClassroomGroupRequest);
        ClassroomGroup createdClassroomGroup = await _classroomGroupDal.AddAsync(classroomGroup);
        CreatedClassroomGroupResponse createdClassroomGroupResponse = _mapper.Map<CreatedClassroomGroupResponse>(createdClassroomGroup);
        return createdClassroomGroupResponse;
    }

    public async Task<ClassroomGroup> DeleteAsync(int Id)
    {
        var data = await _classroomGroupDal.GetAsync(i => i.Id == Id);
        var result = await _classroomGroupDal.DeleteAsync(data);
        return result;
    }

    public async Task<IPaginate<GetListClassroomGroupResponse>> GetAllAsync(PageRequest pageRequest)
    {
        var data = await _classroomGroupDal.GetListAsync(
            include:
            cg=>cg
            .Include(cg=>cg.Group)
            .Include(cg=>cg.Classroom)
            .Include(cg=>cg.ClassroomStudents)
                .ThenInclude(cg => cg.Student)
                .ThenInclude(cg => cg.User),


            index: pageRequest.PageIndex,
            size: pageRequest.PageSize
            );
        var result = _mapper.Map<Paginate<GetListClassroomGroupResponse>>(data);
        return result;
    }

    public async Task<UpdatedClassroomGroupResponse> UpdateAsync(UpdateClassroomGroupRequest updateClassroomGroupRequest)
    {
        var data = await _classroomGroupDal.GetAsync(i => i.Id == updateClassroomGroupRequest.Id);
        _mapper.Map(updateClassroomGroupRequest, data);
        data.UpdatedDate = DateTime.Now;
        await _classroomGroupDal.UpdateAsync(data);
        var result = _mapper.Map<UpdatedClassroomGroupResponse>(data);
        return result;

    }
 
}

