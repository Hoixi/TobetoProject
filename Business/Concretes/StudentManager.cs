using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.InstructorRequests;
using Business.Dtos.Requests.StudentRequests;
using Business.Dtos.Responses.InstructorResponse;
using Business.Dtos.Responses.StudentResponse;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class StudentManager : IStudentService
{
    IStudentDal _studentDal;
    IMapper _mapper;

    public StudentManager(IStudentDal studentDal, IMapper mapper)
    {
        _studentDal = studentDal;
        _mapper = mapper;
    }

    public async Task<CreatedStudentResponse> Add(CreateStudentRequest createStudentRequest)
    {
        Student student = _mapper.Map<Student>(createStudentRequest);
        Student createdStudent = await _studentDal.AddAsync(student);
        CreatedStudentResponse createdInstructorResponse = _mapper.Map<CreatedStudentResponse>(createdStudent);
        return createdInstructorResponse;
    }

    public async Task<Student> Delete(int Id, bool permanent)
    {
        var data = await _studentDal.GetAsync(i => i.Id == Id);
        var result = await _studentDal.DeleteAsync(data, permanent);
        return result;
    }

    public async Task<CreatedStudentResponse> GetStudentById(int id)
    {
        var data = await _studentDal.GetAsync(i => i.Id == id);
        var result = _mapper.Map<CreatedStudentResponse>(data);
        return result;
    }

    public async Task<IPaginate<GetStudentListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var data = await _studentDal.GetListAsync(
                include: p => p
                .Include(p => p.Classroom)
                .Include(p => p.User),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
                );

        var result = _mapper.Map<Paginate<GetStudentListResponse>>(data);
        return result;
    }

    public async Task<UpdatedStudentResponse> Update(UpdateStudentRequest updateStudentRequest)
    {
        var data = await _studentDal.GetAsync(i => i.Id == updateStudentRequest.Id);
        _mapper.Map(updateStudentRequest, data);
        data.UpdatedDate = DateTime.Now;
        await _studentDal.UpdateAsync(data);
        var result = _mapper.Map<UpdatedStudentResponse>(data);
        return result;
    }
}
