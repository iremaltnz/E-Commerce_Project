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
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> List()
        {
            query = "select* from public.products";
            dataSet=_productDal.List(query);
            Product product = new Product();
            List<Product> products = new List<Product>();
          

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                product = new Product();
                product.ProductId = Convert.ToInt32(dataSet.Tables[0].Rows[i]["product_id"]);
                product.ColorId = Convert.ToInt32(dataSet.Tables[0].Rows[i]["color_id"]);
                product.BrandId = Convert.ToInt32(dataSet.Tables[0].Rows[i]["brand_id"]);
                product.CategoryId = Convert.ToInt32(dataSet.Tables[0].Rows[i]["category_id"]);
                product.ProductPrice = Convert.ToInt32(dataSet.Tables[0].Rows[i]["product_price"]);
                product.StockQuantity = Convert.ToInt32(dataSet.Tables[0].Rows[i]["stock_quantity"]);

                product.ProductName = dataSet.Tables[0].Rows[i]["product_name"].ToString();
                product.Description = dataSet.Tables[0].Rows[i]["description"].ToString();

                products.Add(product);
            }

            return products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }

    
    
}
