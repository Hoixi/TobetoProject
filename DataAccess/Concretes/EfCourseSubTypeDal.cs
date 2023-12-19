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
    public class EfCourseSubTypeDal : EfRepositoryBase<CourseSubType, int, TobetoContext>, ICourseSubTypeDal
    {
        public EfCourseSubTypeDal(TobetoContext context) : base(context)
        {

        }
    }
}
