using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ClassroomRequests;
using Business.Dtos.Requests.RoleRequests;
using Business.Dtos.Responses.ClassroomResponses;
using Business.Dtos.Responses.RoleResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;


public class RoleManager : IClassroomService
    {
        IClassroomDal _classroomDal;
        IMapper _mapper;

        public RoleManager(IClassroomDal classroomDal, IMapper mapper)
        {
            _classroomDal = classroomDal;
            _mapper = mapper;
        }

        public async Task<CreatedClassroomResponse> AddAsync(CreateClassroomRequest createClassroomRequest)
        {
        Classroom classroom = _mapper.Map<Role>(createRoleRequest);
            Role createdRole = await _roleDal.AddAsync(role);
            CreatedRoleResponse createdRoleResponse = _mapper.Map<CreatedRoleResponse>(createdRole);
            return createdRoleResponse;
        }

        public async Task<Role> Delete(int Id, bool permanent)
        {
            var data = await _roleDal.GetAsync(i => i.Id == Id);
            var result = await _roleDal.DeleteAsync(data, permanent);
            return result;
        }

        public async Task<CreatedRoleResponse> GetRoleById(int id)
        {
            var data = await _roleDal.GetAsync(i => i.Id == id);
            var result = _mapper.Map<CreatedRoleResponse>(data);
            return result;
        }

        public async Task<IPaginate<GetListRoleResponse>> GetAll(PageRequest pageRequest)
        {
            var data = await _roleDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
                );
            var result = _mapper.Map<Paginate<GetListRoleResponse>>(data);
            return result;
        }

        public async Task<UpdatedRoleResponse> Update(UpdateRoleRequest updateRoleRequest)
        {
            var data = await _roleDal.GetAsync(i => i.Id == updateRoleRequest.Id);
            _mapper.Map(updateRoleRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _roleDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedRoleResponse>(data);
            return result;

        }
    }

