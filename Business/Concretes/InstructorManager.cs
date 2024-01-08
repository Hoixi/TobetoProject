using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.GroupRequests;
using Business.Dtos.Requests.InstructorRequests;
using Business.Dtos.Responses.GroupResponses;
using Business.Dtos.Responses.ImageResponses;
using Business.Dtos.Responses.InstructorResponses;
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

public class InstructorManager : IInstructorService
{
    IInstructorDal _instructorDal;
    IMapper _mapper;
    public InstructorManager(IInstructorDal instructorDal, IMapper mapper)
    {
        _instructorDal = instructorDal;
        _mapper = mapper;
    }

    

    public async Task<CreatedInstructorResponse> AddAsync(CreateInstructorRequest createInstructorRequest)
    {
        Instructor instructor = _mapper.Map<Instructor>(createInstructorRequest);
        Instructor createdInstructor = await _instructorDal.AddAsync(instructor);
        CreatedInstructorResponse createdInstructorResponse = _mapper.Map<CreatedInstructorResponse>(createdInstructor);
        return createdInstructorResponse;
    }

    public async Task<Instructor> DeleteAsync(int id)
    {
        var data = await _instructorDal.GetAsync(i => i.Id == id);
        var result = await _instructorDal.DeleteAsync(data);
        return result;
    }

    public async Task<IPaginate<GetListInstructorResponse>> GetAllAsync(PageRequest pageRequest)
    {
        var data = await _instructorDal.GetListAsync(
            include: p => p
            .Include(p => p.User),
               index: pageRequest.PageIndex,
               size: pageRequest.PageSize
               );
        var result = _mapper.Map<Paginate<GetListInstructorResponse>>(data);
        return result;
    }

    public async  Task<CreatedInstructorResponse> GetById(int id)
    {
        var data = await _instructorDal.GetAsync(c => c.Id == id);
        var result = _mapper.Map<CreatedInstructorResponse>(data);
        return result;
    }

    public  async Task<UpdatedInstructorResponse> UpdateAsync(UpdateInstructorRequest updateInstructorRequest)
    {
        var data = await _instructorDal.GetAsync(i => i.Id == updateInstructorRequest.Id);
        _mapper.Map(updateInstructorRequest, data);
        data.UpdatedDate = DateTime.Now;
        await _instructorDal.UpdateAsync(data);
        var result = _mapper.Map<UpdatedInstructorResponse>(data);
        return result;
    }
}
