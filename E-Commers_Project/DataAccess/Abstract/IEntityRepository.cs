using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IEntityRepository
    {
        DataSet List(string query);

        void Add(string query);
        void Delete(string query);
        void Update(string query);
    }
}
