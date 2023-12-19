using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserCertificateRequests;
using Business.Dtos.Responses.UserCertificateResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class UserCertificateManager : IUserCertificateService
    {
        IUserCertificateDal _userCertificateDal;
        IMapper _mapper;

        public UserCertificateManager(IUserCertificateDal userCertificateDal, IMapper mapper)
        {
            _userCertificateDal = userCertificateDal;
            _mapper = mapper;
        }

        public async Task<CreatedUserCertificateResponse> AddAsync(CreateUserCertificateRequest createUserCertificateRequest)
        {
            UserCertificate userCertificate = _mapper.Map<UserCertificate>(createUserCertificateRequest);
            UserCertificate createdUserCertificate = await _userCertificateDal.AddAsync(userCertificate);
            CreatedUserCertificateResponse createdUserCertificateResponse = _mapper.Map<CreatedUserCertificateResponse>(createdUserCertificate);
            return createdUserCertificateResponse;
        }

        public async Task<UserCertificate> DeleteAsync(int id)
        {
            var data = await _userCertificateDal.GetAsync(i => i.Id == id);
            var result = await _userCertificateDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListUserCertificateResponse>> GetAllAsync(PageRequest pageRequest)
        {
            var data = await _userCertificateDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListUserCertificateResponse>>(data);
            return result;
        }

        public async Task<UpdatedUserCertificateResponse> UpdateAsync(UpdateUserCertificateRequest updateUserCertificateRequest)
        {
            var data = await _userCertificateDal.GetAsync(i => i.Id == updateUserCertificateRequest.Id);
            _mapper.Map(updateUserCertificateRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _userCertificateDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedUserCertificateResponse>(data);
            return result;
        }
    }

}

