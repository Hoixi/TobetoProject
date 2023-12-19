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
        Task<CreatedUserCertificateResponse> Add(CreateUserCertificateRequest createUserCertificateRequest);
        Task<UpdatedUserCertificateResponse> Update(UpdateUserCertificateRequest updateUserCertificateRequest);
        Task<UserCertificate> Delete(int id);
        Task<IPaginate<GetListUserCertificateResponse>> GetAll(PageRequest pageRequest);
    }
}
