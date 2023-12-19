using Business.Dtos.Requests.UserCertificateRequests;
using Business.Dtos.Responses.UserCertificateResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserCertificateService
    {
        Task<CreatedUserCertificateResponse> AddAsync(CreateUserCertificateRequest createUserCertificateRequest);
        Task<UpdatedUserCertificateResponse> UpdateAsync(UpdateUserCertificateRequest updateUserCertificateRequest);
        Task<UserCertificate> DeleteAsync(int id);
        Task<IPaginate<GetListUserCertificateResponse>> GetAllAsync(PageRequest pageRequest);
    }
}
