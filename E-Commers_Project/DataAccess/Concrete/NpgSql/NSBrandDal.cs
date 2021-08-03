using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.NpgSql
{
    public class NSBrandDal : NSRepositoryBase<Brand>, IBrandDal
    {
    }
}
