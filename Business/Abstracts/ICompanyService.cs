using Business.Dtos.Requests.CompanyRequests;
using Business.Dtos.Responses.ClassroomStudentResponses;
using Business.Dtos.Responses.CompanyResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ICompanyService
{
    Task<CreatedCompanyResponse> AddAsync(CreateCompanyRequest createCompanyRequest);
    Task<UpdatedCompanyResponse> UpdateAsync(UpdateCompanyRequest updateCompanyRequest);
    Task<Company> DeleteAsync(int id);
    Task<IPaginate<GetListCompanyResponse>> GetAllAsync(PageRequest pageRequest);
    Task<CreatedCompanyResponse> GetById(int id);

}
