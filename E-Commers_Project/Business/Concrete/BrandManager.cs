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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
       

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.successAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.successDeleted);
        }

        public IDataResult<List<Brand>> List()
        {
            return new SuccessDataResult<List<Brand>>(Messages.successListed);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.successUpdated);
        }
    }



}
