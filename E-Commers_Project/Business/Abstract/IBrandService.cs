using Business.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> List();
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);

    }
}
