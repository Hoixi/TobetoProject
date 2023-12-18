using Core.DataAccess.Repositories;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IUserSkillDal : IRepository<UserSkill, int>, IAsyncRepository<UserSkill, int>
    {

    }
}
