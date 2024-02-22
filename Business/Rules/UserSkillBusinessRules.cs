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
    public class UserSkillBusinessRules:BaseBusinessRules
    {
        IUserSkillDal _userSkillDal;

        public UserSkillBusinessRules(IUserSkillDal userSkillDal)
        {
            _userSkillDal = userSkillDal;
        }

        public async Task UserSkillShouldNotExistsWithSameSkill(int skillId, int userId)
        {
            var user = await _userSkillDal.GetListAsync(u => u.UserId == userId);
            foreach (var item in user.Items)
            {
                if(item.SkillId == skillId)
                {
                    throw new BusinessException(BusinessMessages.SameSkill);
                }
            }
        }
    }
}
