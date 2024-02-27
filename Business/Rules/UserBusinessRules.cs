using Business.Abstracts;
using Business.Dtos.Requests.UserRequests;
using Business.Dtos.Responses.UserResponses;
using Business.Messages;
using Core.Business.Rules;
using Core.CrossCutingConcerns.Types;
using Core.DataAccess.Paging;
using Core.Entities.Concretes;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class UserBusinessRules : BaseBusinessRules
    {
        IUserDal _userDal;

        public UserBusinessRules(IUserDal userDal)
        {
            _userDal = userDal;
        }





        public async Task UserShouldNotExistsWithSameEmail(String email)
        {
            User? user = await _userDal.GetAsync(i => i.Email == email);
            if (user != null)
                throw new BusinessException("Bu E-posta ile bir kullanıcı mevcut");
        }


        public void PhoneNumberValidate(CreateUserRequest createUserRequest)
        {

            if (createUserRequest.PhoneNumber.Length != 11)
            {
                throw new BusinessException(BusinessMessages.PhoneNumberIsValid);
            }

        }



    }
}
