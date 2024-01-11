using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Dtos.Responses.UserResponses;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCutingConcerns.Validations.FluentValidation;
using Core.DataAccess.Paging;
using Core.Entities.Concretes;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class UserManager : IUserService
{
    IUserDal _userDal;
    IMapper _mapper;
    UserBusinessRules _userBusinessRules;

    public UserManager(IUserDal userDal, IMapper mapper, UserBusinessRules userBusinessRules)
    {
        _userDal = userDal;
        _mapper = mapper;
        _userBusinessRules = userBusinessRules;
    }

    public UserManager(IUserDal userDal)
    {
        _userDal = userDal;
    }

    public List<OperationClaim> GetClaims(User user)
    {
        return _userDal.GetClaims(user);
    }

    

    public User GetByMail(string email)
    {
        return _userDal.Get(u => u.Email == email);
    }
    

    /*[ValidationAspect(typeof(UserValidate))]*/
    public async Task<UserBase> AddAsync(User user)
    {
        /*_userBusinessRules.EmailMustIncludeAtSign(createUserRequest);
        _userBusinessRules.PasswordValidate(createUserRequest);
        _userBusinessRules.PhoneNumberValidate(createUserRequest);*/ 
        
        User createdUser = await _userDal.AddAsync(user);
        CreatedUserResponse createdUserResponse = _mapper.Map<CreatedUserResponse>(createdUser);
        return createdUser;
    }

    public async Task<User> DeleteAsync(int id)
    {
        var data = await _userDal.GetAsync(i => i.Id == id);
        var result = await _userDal.DeleteAsync(data);
        return result;
    }

    public async Task<IPaginate<GetListUserResponse>> GetAllAsync(PageRequest pageRequest)
    {
        var data = await _userDal.GetListAsync(
            include: p => p
    
        .Include(p => p.UserAnnouncements)  
        .Include(p => p.Experiences).ThenInclude(ul=>ul.City)  
        .Include(p => p.Certificates)
        .Include(p => p.UserSocialMedias).ThenInclude(ul=>ul.SocialMedia)
        .Include(p => p.UserLanguages).ThenInclude(ul => ul.LanguageLevel)
        .Include(p => p.UserLanguages).ThenInclude(ul => ul.Language)
        .Include(p => p.UserSurveys)
        .Include(p => p.Addresses).ThenInclude(cl=> cl.Country)
        .Include(p => p.Addresses).ThenInclude(cl=> cl.City)
        .Include(p => p.Addresses).ThenInclude(cl=> cl.Town),

           index: pageRequest.PageIndex,
           size: pageRequest.PageSize
           ) ;
        var result = _mapper.Map<Paginate<GetListUserResponse>>(data);
        return result;
    }

    public async Task<UpdatedUserResponse> UpdateAsync(UpdateUserRequest updateUserRequest)
    {
        var data = await _userDal.GetAsync(i => i.Id == updateUserRequest.Id);
        _mapper.Map(updateUserRequest, data);
        data.UpdatedDate = DateTime.Now;
        await _userDal.UpdateAsync(data);
        var result = _mapper.Map<UpdatedUserResponse>(data);
        return result;
    }

    public async Task<CreatedUserResponse> GetById(int id)
    {
        var data = await _userDal.GetAsync(c => c.Id == id);
        var result = _mapper.Map<CreatedUserResponse>(data);
        return result;
    }
}

