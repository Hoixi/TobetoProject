using Business.Abstracts;
using Business.Dtos.Requests.UserRequests;
using Business.Rules;
using Business.ValidationRules.FluentValidation;

using Core.Entities.Concretes;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        private UserBusinessRules _userBusinessRules;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper, UserBusinessRules userBusinessRules)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _userBusinessRules = userBusinessRules;
        }

        public IDataResult<AccessToken> CreateAccessToken(UserBase user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "Oluşturuldu");
        }

        public IDataResult<UserBase> Login(UserForLoginRequest userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<UserBase>("Kullanıcı Yok");
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<UserBase>("E-Posta veya Şifre Hatalı");
            }

            return new SuccessDataResult<UserBase>(userToCheck, "Tamam");
        }

        
        public async Task<IDataResult<UserBase>> Register(UserForRegisterRequest userForRegisterDto, string password)
        {
            await _userBusinessRules.UserShouldNotExistsWithSameEmail(userForRegisterDto.Email);
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new UserBase
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
            };
            await _userService.AddAsync(user);
            return new SuccessDataResult<UserBase>(user, "Tamam");
        }

        public Core.Utilities.Results.IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult("Kullanıcı Zaten Mevcut");
            }
            return new SuccessResult();
        }
    }
}
