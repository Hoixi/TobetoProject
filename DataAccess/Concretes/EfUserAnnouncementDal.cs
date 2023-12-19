using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfUserAnnouncementDal : EfRepositoryBase<UserAnnouncement, int, TobetoContext>, IUserAnnouncementDal
    {
        public EfUserAnnouncementDal(TobetoContext context) : base(context)
        {

        }
    }
}
