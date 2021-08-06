using Business.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> List();
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);

    }
}
