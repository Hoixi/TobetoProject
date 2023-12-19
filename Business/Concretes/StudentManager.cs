using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.SkillRequests;
using Business.Dtos.Requests.StudentRequests;
using Business.Dtos.Responses.SkillResponses;
using Business.Dtos.Responses.StudentResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;
        IMapper _mapper;

        public StudentManager(IStudentDal studentDal, IMapper mapper)
        {
            _studentDal = studentDal;
            _mapper = mapper;
        }

        public async Task<CreatedStudentResponse> AddAsync(CreateStudentRequest createStudentRequest)
        {
            Student student = _mapper.Map<Student>(createStudentRequest);
            Student createdStudent = await _studentDal.AddAsync(student);
            CreatedStudentResponse createdStudentResponse = _mapper.Map<CreatedStudentResponse>(createdStudent);
            return createdStudentResponse;
        }

        public async Task<Student> DeleteAsync(int id)
        {
            var data = await _studentDal.GetAsync(i => i.Id == id);
            var result = await _studentDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListStudentResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _studentDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListStudentResponse>>(data);
            return result;
        }

        public async Task<UpdatedStudentResponse> UpdateAsync(UpdateStudentRequest updateStudentRequest)
        {
            var data = await _studentDal.GetAsync(i => i.Id == updateStudentRequest.Id);
            _mapper.Map(updateStudentRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _studentDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedStudentResponse>(data);
            return result;
        }
    }
}
