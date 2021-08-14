using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
namespace DataAccess.Concrete.NpgSql
{
    public class NSProductDal : NSRepositoryBase<Product>, IProductDal
    {
        public productDto GetProductDetail(int productId)
        {
            using (var context = new Context())
            {
                var result = from product in context.products
                             join brand in context.brands
                             on product.brand_id equals brand.brand_id
                             join color in context.colors
                             on product.color_id equals color.color_id

                             select new productDto
                             {
                                 ProductId = product.product_id,
                                 ProductName = product.product_name,
                                 BrandName = brand.brand_name,
                                 ColorName = color.color_name,
                                 ProductPrice = product.product_price,
                                 Description = product.description,
                                 StockQuantity = product.stock_quantity
                             };
                return result.SingleOrDefault(p => p.ProductId == productId);
            }
        }
    }
}
