using Business.Dtos.Requests.UserRequests;
using Business.Dtos.Responses.UserResponses;
using Business.Messages;
using Core.Business.Rules;
using Core.CrossCutingConcerns.Types;
using DataAccess.Abstracts;
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

        public async Task IdentityNoMustBeSizeOfEleven(CreateUserRequest createUserRequest)
        {


            if (createUserRequest.NationalIdentity.Length != 11)
            {
                throw new BusinessException(BusinessMessages.NationalIdentityLenght);
            }
        }

        public void EmailMustIncludeAtSign(CreateUserRequest createUserRequest)
        {

            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$";

            if (!Regex.IsMatch(createUserRequest.Email, pattern))
            {
                throw new BusinessException(BusinessMessages.EmailIsInvalid);
            }


        }

        public void PasswordValidate(CreateUserRequest createUserRequest)
        {
            string pattern = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-_]).{8,15}$";

            if (!Regex.IsMatch(createUserRequest.Password, pattern))
            {
                throw new BusinessException(BusinessMessages.PasswordIsInvalid);

            }

        }

        public void PhoneNumberValidate(CreateUserRequest createUserRequest)
        {
            //string pattern = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

            //if (!Regex.IsMatch(createUserRequest.PhoneNumber, pattern))
            //{
            //    throw new BusinessException(BusinessMessages.PhoneNumberIsValid);

            //}


            if (createUserRequest.PhoneNumber.Length != 11)
            {
                throw new BusinessException(BusinessMessages.PhoneNumberIsValid);
            }

        }



    }
}
