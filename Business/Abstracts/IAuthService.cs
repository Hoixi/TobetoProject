using Business.Dtos.Requests.UserRequests;
using Core.Entities.Concretes;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;

namespace Business.Abstracts
{
    //UserForRegisterRequest,UserForRegisterRequest
    public interface IAuthService
    {
        Task<IDataResult<UserBase>> Register(UserForRegisterRequest userForRegisterDto, string password);
        IDataResult<UserBase> Login(UserForLoginRequest userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(UserBase user);
    }
}
