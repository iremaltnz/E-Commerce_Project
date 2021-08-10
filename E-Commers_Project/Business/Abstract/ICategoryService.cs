using Business.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> CategoryList();
        IResult CategoryAdd(Category category);
        IResult CategoryDelete(Category category);
        IResult CategoryUpdate(Category category);
    }
}
