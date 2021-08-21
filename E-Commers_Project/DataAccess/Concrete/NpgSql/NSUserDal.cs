using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.NpgSql
{
    public class NSUserDal : NSRepositoryBase<User>, IUserDal
    {
    }
}
