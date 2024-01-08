using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ClassroomRequests;
using Business.Dtos.Responses.ClassroomGroupResponses;
using Business.Dtos.Responses.ClassroomResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes;


public class ClassroomManager : IClassroomService
    {
        IClassroomDal _classroomDal;
        IMapper _mapper;

        public ClassroomManager(IClassroomDal classroomDal, IMapper mapper)
        {
            _classroomDal = classroomDal;
            _mapper = mapper;
        }

        public async Task<CreatedClassroomResponse> AddAsync(CreateClassroomRequest createClassroomRequest)
        {
        Classroom classroom = _mapper.Map<Classroom>(createClassroomRequest);
        Classroom createdClassroom = await _classroomDal.AddAsync(classroom);
        CreatedClassroomResponse createdClassroomResponse = _mapper.Map<CreatedClassroomResponse>(createdClassroom);
            return createdClassroomResponse;
        }

        public async Task<Classroom> DeleteAsync(int Id)
        {
            var data = await _classroomDal.GetAsync(i => i.Id == Id);
            var result = await _classroomDal.DeleteAsync(data);
            return result;
        }
   
        public async Task<IPaginate<GetListClassroomResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _classroomDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
                );
            var result = _mapper.Map<Paginate<GetListClassroomResponse>>(data);
            return result;
    }

    public async Task<CreatedClassroomResponse> GetById(int id)
    {
        var data = await _classroomDal.GetAsync(c => c.Id == id);
        var result = _mapper.Map<CreatedClassroomResponse>(data);
        return result;
    }

    public async Task<UpdatedClassroomResponse> UpdateAsync(UpdateClassroomRequest updateClassroomRequest)
        {
            var data = await _classroomDal.GetAsync(i => i.Id == updateClassroomRequest.Id);
            _mapper.Map(updateClassroomRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _classroomDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedClassroomResponse>(data);
            return result;

        }

  
}

