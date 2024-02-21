using Business.Messages;
using Core.Business.Rules;
using Core.CrossCutingConcerns.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class UserSocialMediaBusinessRules :BaseBusinessRules
    {
        private readonly IUserSocialMediaDal _userSocialMediaDal;

        public UserSocialMediaBusinessRules(IUserSocialMediaDal userSocialMediaDal)
        {
            _userSocialMediaDal = userSocialMediaDal;
        }


        public async Task SocialMediaLimitThree(int UserId)
        {
            var result = await _userSocialMediaDal.GetListAsync(i => i.UserId== UserId);

            if (result.Count > 3)
            {
                throw new BusinessException(BusinessMessages.SocialMediaLimit);
            }
        }

    }
}
