using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> List();
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);

    }
}
