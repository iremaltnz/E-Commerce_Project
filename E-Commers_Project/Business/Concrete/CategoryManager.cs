using Business.Abstract;
using Business.Aspects.Perfomance;
using Business.Constants;
using Business.Utilities.Results;
using DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        
        public IResult CategoryAdd(Category category)
        {
            if (category.category_name == "deneme")
            {
                return new ErrorResult(Messages.errorAdded);
            }
            _categoryDal.Add(category);
            return new SuccessResult(Messages.successAdded);
        }

        public IResult CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.successDeleted);
        }


        [TimeLoggerAspect]
        public IDataResult<List<Category>> List()

        {

            return new SuccessDataResult<List<Category>>(_categoryDal.List(), Messages.successListed);
        }

        public IResult CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.successUpdated);
        }
    }
}
