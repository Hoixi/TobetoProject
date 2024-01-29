using Business.Abstracts;
using Business.Dtos.Requests.UserRequests;
using Business.ValidationRules.FluentValidation;
using Core.Aspects;
using Core.CrossCutingConcerns.Validations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [ValidationAttribute(typeof(RegisterValidator))]
        [HttpPost("register")]
        public async Task<ActionResult> Register(UserForRegisterRequest userForRegisterDto)
        {
            //var userExists = _authService.UserExists(userForRegisterDto.Email);
            //if (!userExists.Success)
            //{
            //    return BadRequest(userExists);
            //}

            var registerResult = await _authService.Register(userForRegisterDto, userForRegisterDto.Password);        
            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        
        [HttpPost("login")]
        public ActionResult Login(UserForLoginRequest userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}
