using Business.Messages;
using Core.Business.Rules;
using Core.CrossCutingConcerns.Types;
using DataAccess.Abstracts;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class UserLanguageBusinessRules:BaseBusinessRules
    {
        private readonly IUserLanguageDal _userLanguageDal;

        public UserLanguageBusinessRules(IUserLanguageDal userLanguageDal)
        {
            _userLanguageDal = userLanguageDal;
        }

        public async Task UserLanguageEnsureUnique(int UserId)
        {
            var result = await _userLanguageDal.GetAsync(i => i.UserId == UserId);

            if (result != null)
            {
                throw new BusinessException(BusinessMessages.LanguageUnique);
            }

        }


    }
}
