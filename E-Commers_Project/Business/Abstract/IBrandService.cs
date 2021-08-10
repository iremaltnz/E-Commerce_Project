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
        IDataResult<List<Brand>> BrandList();
        IResult BrandAdd(Brand brand);
        IResult BrandDelete(Brand brand);
        IResult BrandUpdate(Brand brand);

    }
}
