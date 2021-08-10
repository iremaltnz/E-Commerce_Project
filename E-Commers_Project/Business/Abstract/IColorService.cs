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
        IDataResult<List<Color>> ColorList();
        IResult ColorAdd(Color color);
        IResult ColorDelete(Color color);
        IResult ColorUpdate(Color color);

    }
}
