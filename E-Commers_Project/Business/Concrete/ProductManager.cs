using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
             _productDal.Delete(product);
        }

        public List<Product> List()
        {
            
            return _productDal.List();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }

  

}
