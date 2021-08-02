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
            query = "insert into public.products(product_name,category_id,color_id,brand_id,product_price,description,stock_quantity) values ('" + product.ProductName + "," +
                product.CategoryId +
                "," + product.ColorId +
                "," + product.BrandId +
                "," + product.ProductPrice +
                ",'" + product.Description +
                "'," + product.StockQuantity;
               
            _productDal.Add(query);
        }

        public void Delete(Product product)
        {
            query = @"delete from public.products where product_id=" +product.ProductId; 
            _productDal.Delete(query);
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
            query = @"update public.products set product_name='" + product.ProductName+ "' and category_id="+product.CategoryId+
                "and color_id="+product.ColorId+
                "and brand_id="+product.BrandId+
                "and stock_quantity="+product.StockQuantity+
                "and product_price="+product.ProductPrice+
                "and description='"+product.Description+
                "'where product_id=" + product.ProductId;
            _productDal.Update(query);
        }
    }

    
    
}
