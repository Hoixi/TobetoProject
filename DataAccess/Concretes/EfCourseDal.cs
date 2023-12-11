using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfCourseDal : EfRepositoryBase<Course, int, TobetoContext>, ICourseDal
    {
        public EfCourseDal(TobetoContext context) : base(context)
        {

        }
    }
}
