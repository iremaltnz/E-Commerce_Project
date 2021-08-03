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
            //query = "insert into public.products(product_name,category_id,color_id,brand_id,product_price,description,stock_quantity) values ('" + product.ProductName + "'," +
            //    product.CategoryId +
            //    "," + product.ColorId +
            //    "," + product.BrandId +
            //    "," + product.ProductPrice +
            //    ",'" + product.Description +
            //    "'," + product.StockQuantity+")";
               
            //_productDal.Add(query);
        }

        public void Delete(Product product)
        {
            //query = @"delete from public.products where product_id=" +product.ProductId; 
            //_productDal.Delete(query);
        }

        public List<Product> List()
        {
            
            return _productDal.List();
        }

        public void Update(Product product)
        {
            //query = @"update public.products set description='" + product.Description + 
            //    "' , stock_quantity="+product.StockQuantity+
            // ",color_id="+ product.ColorId+ ", category_id=" + product.CategoryId +
            //    " , brand_id=" + product.BrandId +
            //    " , product_price=" + product.ProductPrice +
            //    " , product_name='" + product.ProductName +

            //    "' where product_id=" + product.ProductId; 
            //_productDal.Update(query);
        }
    }

  

}
