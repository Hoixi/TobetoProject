using Business.Dtos.Requests.UserRequests;
using Core.Entities.Concretes;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    //UserForRegisterRequest,UserForRegisterRequest
    public interface IAuthService
    {
        IDataResult<UserBase> Register(UserForRegisterRequest userForRegisterDto, string password);
        IDataResult<UserBase> Login(UserForLoginRequest userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(UserBase user);
    }
}
