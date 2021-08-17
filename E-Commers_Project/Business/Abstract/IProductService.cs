using Business.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> ProductList();
        IResult ProductAdd(Product product);
        IResult ProductDelete(Product product);
        IResult ProductUpdate(Product product);
        IDataResult<productDto> GetProductDetailsById(int productId);
        IDataResult<List<productDto>> GetByCategory(int categoryId);
        IDataResult<List<productDto>> GetByBrand(int brandId);
        IDataResult<List<productDto>> GetByColor(int colorId);
    }
}
