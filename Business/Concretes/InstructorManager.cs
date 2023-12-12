using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Business.Abstracts;
using Business.Dtos.Requests.InstructorRequests;
using Business.Dtos.Responses.InstructorResponse;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Responses.CourseResponses;
using DataAccess.Concretes;

namespace Business.Concretes
{   
    
    public class InstructorManager : IInstructorService
    {

        IInstructorDal _instructorDal;
        IMapper _mapper;

        public InstructorManager(IInstructorDal instructorDal, IMapper mapper)
        {
            _instructorDal = instructorDal;
            _mapper = mapper;
        }

        public async Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest)
        {
            Instructor instructor = _mapper.Map<Instructor>(createInstructorRequest);
            Instructor createdInstructor = await _instructorDal.AddAsync(instructor);
            CreatedInstructorResponse createdInstructorResponse = _mapper.Map<CreatedInstructorResponse>(createdInstructor);
            return createdInstructorResponse;
        }

        public async Task<Instructor> Delete(int Id, bool permanent)
        {
            var data = await _instructorDal.GetAsync(i => i.Id == Id);
            var result = await _instructorDal.DeleteAsync(data, permanent);
            return result;
        }

        public async Task<CreatedInstructorResponse> GetInstructorById(int id)
        {
            var data = await _instructorDal.GetAsync(i => i.Id == id);
            var result = _mapper.Map<CreatedInstructorResponse>(data);
            return result;
        }

        public async Task<IPaginate<GetInstructorListResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _instructorDal.GetListAsync(
                include: p => p.Include(p => p.User),               
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize

                );

            var result = _mapper.Map<Paginate<GetInstructorListResponse>>(data);
            return result;
        }

        public async Task<UpdatedInstructorResponse> Update(UpdateInstructorRequest updateInstructorRequest)
        {
            var data = await _instructorDal.GetAsync(i => i.Id == updateInstructorRequest.Id);
            _mapper.Map(updateInstructorRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _instructorDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedInstructorResponse>(data);
            return result;
        }
    }
}
