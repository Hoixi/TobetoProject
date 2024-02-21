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

        public async Task UserSkillShouldNotExistsWithSameSkill(int skillId)
        {
            var result = await _userSkillDal.GetAsync(i => i.SkillId == skillId);
            if (result != null)
                throw new BusinessException(BusinessMessages.SameSkill);
        }
    }
}
