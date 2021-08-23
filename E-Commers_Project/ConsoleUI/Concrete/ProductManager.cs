using Business.Abstract;
using Business.Constants;
using Business.Utilities.Results;
using DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        IColorDal _colorDal;
        IBrandDal _brandDal;
        ICategoryDal _categoryDal;

        public ProductManager(IProductDal productDal, IColorDal colorDal,
        IBrandDal brandDal,
        ICategoryDal categoryDal
)
        {
            _productDal = productDal;
            _categoryDal = categoryDal;
            _colorDal = colorDal;
            _brandDal = brandDal;
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

        public IDataResult<List<productDto>> ProductList()
        {
            return new SuccessDataResult<List<productDto>>(_productDal.GetProductDetails(null), Messages.successListed);
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

        public IDataResult<List<productDto>> GetByCategory(int categoryId)
        {
            return new SuccessDataResult<List<productDto>>(_productDal.GetProductDetails().
                Where(p => p.CategoryName == _categoryDal.GetById(c => c.category_id == categoryId).category_name).ToList(),Messages.successListed);
        }

        public IDataResult<List<productDto>> GetByBrand(int brandId)
        {
            return new SuccessDataResult<List<productDto>>(_productDal.GetProductDetails().
                Where(p => p.BrandName == _brandDal.GetById(b=> b.brand_id == brandId).brand_name).ToList(), Messages.successListed);
        }

        public IDataResult<List<productDto>> GetByColor(int colorId)
        {
            return new SuccessDataResult<List<productDto>>(_productDal.GetProductDetails().
                Where(p => p.ColorName == _colorDal.GetById(c => c.color_id == colorId).color_name).ToList(), Messages.successListed);
        }
    }

  

}
