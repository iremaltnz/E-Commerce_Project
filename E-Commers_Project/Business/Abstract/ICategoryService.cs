using Business.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> List();
        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);
    }
}
