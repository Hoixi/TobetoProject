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
    public class UserLanguageBusinessRules : BaseBusinessRules
    {
        private readonly IUserLanguageDal _userLanguageDal;

        public UserLanguageBusinessRules(IUserLanguageDal userLanguageDal)
        {
            _userLanguageDal = userLanguageDal;
        }

        public async Task UserLanguageEnsureUnique(int UserId, int LanguageId)
        {
            var result = await _userLanguageDal.GetListAsync(i => i.UserId == UserId);

            foreach (var item in result.Items)
            {
                if(item.LanguageId == LanguageId)
                {
                    throw new BusinessException(BusinessMessages.LanguageUnique);
                }
            }

        }


    }
}
