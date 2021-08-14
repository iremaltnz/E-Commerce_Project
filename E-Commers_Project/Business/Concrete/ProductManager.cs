using Business.Abstract;
using Business.Constants;
using Business.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        DataSet dataSet;
        string query;
     

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult ProductAdd(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.successAdded);
        }

        public IResult ProductDelete(Product product)
        {
             _productDal.Delete(product);
            return new SuccessResult(Messages.successDeleted);
        }

        public IDataResult<List<Product>> ProductList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.List(), Messages.successListed);
        }

        public IResult ProductUpdate(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.successUpdated);
        }

        public IDataResult<productDto> GetProductDetailsById(int productId)
        {
            return new SuccessDataResult<productDto>(_productDal.GetProductDetail(productId),Messages.successListed);
        }
    }

  

}
