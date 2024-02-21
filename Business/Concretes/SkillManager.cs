using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.SkillRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.SkillResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;
        IMapper _mapper;

        public SkillManager(ISkillDal skillDal, IMapper mapper)
        {
            _skillDal = skillDal;
            _mapper = mapper;
        }

        public async Task<CreatedSkillResponse> AddAsync(CreateSkillRequest createSkillRequest)
        {
            Skill skill = _mapper.Map<Skill>(createSkillRequest);
            Skill createdSkill= await _skillDal.AddAsync(skill);
            CreatedSkillResponse createdSkillResponse = _mapper.Map<CreatedSkillResponse>(createdSkill);
            return createdSkillResponse;
        }

        public async Task<Skill> DeleteAsync(int id)
        {
            var data = await _skillDal.GetAsync(i => i.Id == id);
            var result = await _skillDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListSkillResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _skillDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListSkillResponse>>(data);
            return result;
        }

        public async Task<GetListSkillResponse> GetById(int id)
        {
            var data = await _skillDal.GetAsync(c => c.Id == id);
            var result = _mapper.Map<GetListSkillResponse>(data);
            return result;
        }

        public async Task<UpdatedSkillResponse> UpdateAsync(UpdateSkillRequest updateSkillRequest)
        {
            var data = await _skillDal.GetAsync(i => i.Id == updateSkillRequest.Id);
            _mapper.Map(updateSkillRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _skillDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedSkillResponse>(data);
            return result;
        }
    }
}
