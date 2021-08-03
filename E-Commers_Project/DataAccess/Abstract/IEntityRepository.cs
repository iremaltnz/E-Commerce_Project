using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IEntityRepository<TEntity>
    {
        List<TEntity> List();

        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
