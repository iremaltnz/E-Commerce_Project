using Business.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> List();
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);

    }
}
