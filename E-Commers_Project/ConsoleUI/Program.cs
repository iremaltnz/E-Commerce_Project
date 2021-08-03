using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.NpgSql;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;

namespace ConsoleUI
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
        }

        private static void BrandDelete(Brand brand)
        {
            BrandManager brandManager = new BrandManager(new NSBrandDal());
            brandManager.Delete(brand);
        }

        private static void BrandUpdate(Brand brand)
        {
            BrandManager brandManager = new BrandManager(new NSBrandDal());
            brandManager.Update(brand);
        }

        private static void BrandAdd(Brand brand)
        {
            BrandManager brandManager = new BrandManager(new NSBrandDal());
            brandManager.Add(brand);
        }

        private static void CategoryList()
        {
            CategoryManager categoryManager = new CategoryManager(new NSCategoryDal());
            List<Category> categories = new List<Category>();
            categories = categoryManager.List();

            foreach (var c in categories)
            {
                Console.WriteLine(c.category_name);
            }
        }

        private static void BrandList()
        {
            BrandManager brandManager = new BrandManager(new NSBrandDal());
            List<Brand> brands = new List<Brand>();
            brands = brandManager.List();

            foreach (var b in brands)
            {
                Console.WriteLine(b.brand_name);
            }
        }

        private static void ColorList()
        {
            ColorManager colorManager = new ColorManager(new NSColorDal());
            List<Color> colors = new List<Color>();
            colors = colorManager.List();

            foreach (var c in colors)
            {
                Console.WriteLine(c.color_name);
            }
        }

        private static void ProductList()
        {
            ProductManager productManager = new ProductManager(new NSProductDal());
            List<Product> products = new List<Product>();
            products = productManager.List();

            foreach (var p in products)
            {
                Console.WriteLine(p.product_name);
            }
        }

        //    private static void BrandDelete()
        //    {
        //        BrandManager brandManager = new BrandManager(new NSBrandDal());
        //        Brand brand = new Brand();
        //        brand.BrandId = 10;
        //        brand.BrandName = "adidas";
        //        brandManager.Delete(brand);
        //    }

        //    private static void ColorDelete()
        //    {
        //        ColorManager colorManager = new ColorManager(new NSColorDal());
        //        Color color = new Color();
        //        color.ColorId = 4;
        //        color.ColorName = "mavi";
        //        colorManager.Delete(color);
        //    }

        //    private static void ColorUpdate()
        //    {
        //        ColorManager colorManager = new ColorManager(new NSColorDal());
        //        Color color = new Color();
        //        color.ColorId = 4;
        //        color.ColorName = "mavi";
        //        colorManager.Update(color);
        //    }

        //    private static void ProductDelete()
        //    {
        //        ProductManager productManager = new ProductManager(new NSProductDal());
        //        Product product = new Product();
        //        product.ProductId = 11;
        //        product.BrandId = 1;
        //        product.ColorId = 1;
        //        product.CategoryId = 1;
        //        product.ProductPrice = 10;
        //        product.StockQuantity = 2;
        //        product.Description = "deneme";
        //        product.ProductName = "denemee2";
        //        productManager.Delete(product);
        //    }

        //    private static void ProductAdd()
        //    {
        //        ProductManager productManager = new ProductManager(new NSProductDal());
        //        Product product = new Product(); 

        //        product.BrandId = 1;
        //        product.ColorId = 1;
        //        product.CategoryId = 1;
        //        product.ProductPrice = 10;
        //        product.StockQuantity = 2;
        //        product.Description = "deneme";
        //        product.ProductName = "denemee";
        //        productManager.Add(product);
        //    }

        //    private static void CategoryDelete()
        //    {
        //        CategoryManager categoryManager = new CategoryManager(new NSCategoryDal());
        //        Category category = new Category();
        //        category.CategoryId = 6;
        //        categoryManager.Delete(category);
        //    }

        //    private static void CategoryUpdate()
        //    {
        //        CategoryManager categoryManager = new CategoryManager(new NSCategoryDal());
        //        Category category = new Category();
        //        category.CategoryId = 6;
        //        category.CategoryName = "deneme";
        //        categoryManager.Add(category);
        //    }

        //    private static void CategoryAdd()
        //    {
        //        CategoryManager category = new CategoryManager(new NSCategoryDal());
        //        Category category1 = new Category();
        //        category1.CategoryName = "deneme22";
        //        category.Add(category1);
        //    }

 



    }

       

    
}
