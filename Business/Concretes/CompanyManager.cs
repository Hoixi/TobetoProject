using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CompanyRequests;
using Business.Dtos.Responses.CompanyResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CompanyManager : ICompanyService
{
    ICompanyDal _companyDal;
    IMapper _mapper;

    public CompanyManager(ICompanyDal companyDal, IMapper mapper)
    {
        _companyDal = companyDal;
        _mapper = mapper;
    }

    public async Task<CreatedCompanyResponse> AddAsync(CreateCompanyRequest createCompanyRequest)
    {
        Company company = _mapper.Map<Company>(createCompanyRequest);
        Company createdCompany = await _companyDal.AddAsync(company);
        CreatedCompanyResponse createdCompanyResponse = _mapper.Map<CreatedCompanyResponse>(createdCompany);
        return createdCompanyResponse;
    }

    public async Task<Company> DeleteAsync(int Id)
    {
        var data = await _companyDal.GetAsync(i => i.Id == Id);
        var result = await _companyDal.DeleteAsync(data);
        return result;
    }

    public async Task<IPaginate<GetListCompanyResponse>> GetAllAsync(PageRequest pageRequest)
    {
        var data = await _companyDal.GetListAsync(
            index: pageRequest.PageIndex,
            size: pageRequest.PageSize
            );
        var result = _mapper.Map<Paginate<GetListCompanyResponse>>(data);
        return result;
    }

    public async Task<UpdatedCompanyResponse> UpdateAsync(UpdateCompanyRequest updateCompanyRequest)
    {
        var data = await _companyDal.GetAsync(i => i.Id == updateCompanyRequest.Id);
        _mapper.Map(updateCompanyRequest, data);
        data.UpdatedDate = DateTime.Now;
        await _companyDal.UpdateAsync(data);
        var result = _mapper.Map<UpdatedCompanyResponse>(data);
        return result;

    }


}

