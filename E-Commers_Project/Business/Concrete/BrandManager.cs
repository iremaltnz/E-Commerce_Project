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
        public IResult BrandAdd(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.successAdded);
        }

        public IResult BrandDelete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.successDeleted);
        }

        public IDataResult<List<Brand>> BrandList()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.List(), Messages.successListed);
        }

        public IResult BrandUpdate(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.successUpdated);
        }
    }



}
