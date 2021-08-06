using Business.Abstract;
using Business.Constants;
using Business.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.successAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.successDeleted);
        }

        public IDataResult<List<Color>> List()
        {
            return new SuccessDataResult<List<Color>>(Messages.successListed);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.successUpdated);
        }
    }



}
