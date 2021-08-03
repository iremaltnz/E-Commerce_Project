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
            CategoryManager categoryManager = new CategoryManager(new NSCategoryDal());
            BrandManager brandManager = new BrandManager(new NSBrandDal());
            ColorManager colorManager = new ColorManager(new NSColorDal());
            ProductManager productManager = new ProductManager(new NSProductDal());

            Brand brand = new Brand();
            Product product = new Product();
            Color color = new Color();
            Category category = new Category();

            color.color_id = 8;
            color.color_name = "deneme2";
            ColorDelete(color,colorManager);
        }
        private static void CategoryUpdate(Category category, CategoryManager categoryManager)
        { 
            categoryManager.Update(category);
        }
        private static void CategoryDelete(Category category, CategoryManager categoryManager)
        { 
            categoryManager.Delete(category);
        }

        private static void CategoryAdd(Category category, CategoryManager categoryManager)
        {  
            categoryManager.Add(category);
        }
        private static void ColorUpdate(Color color, ColorManager colorManager)
        {
           
            colorManager.Update(color);
        }
        private static void ColorDelete(Color color, ColorManager colorManager)
        {
            colorManager.Delete(color);
        }

        private static void ColorAdd(Color color, ColorManager colorManager)
        {
            colorManager.Add(color);
        }

        private static void ProductDelete(Product product, ProductManager productManager)
        {
            productManager.Delete(product);
        }

        private static void ProductUpdate(Product product, ProductManager productManager)
        {
            productManager.Update(product);
        }

        private static void ProductAdd(Product product, ProductManager productManager)
        {
            productManager.Add(product);

        }

        private static void BrandDelete(Brand brand, BrandManager brandManager)
        {
            brandManager.Delete(brand);
        }

        private static void BrandUpdate(Brand brand, BrandManager brandManager)
        {
            brandManager.Update(brand);
        }

        private static void BrandAdd(Brand brand, BrandManager brandManager)
        {
            brandManager.Add(brand);
        }

        private static void CategoryList(CategoryManager categoryManager)
        {
            List<Category> categories = new List<Category>();
            categories = categoryManager.List();

            foreach (var c in categories)
            {
                Console.WriteLine(c.category_name);
            }
        }

        private static void BrandList(BrandManager brandManager)
        {
            List<Brand> brands = new List<Brand>();
            brands = brandManager.List();

            foreach (var b in brands)
            {
                Console.WriteLine(b.brand_name);
            }
        }

        private static void ColorList(ColorManager colorManager)
        {
            List<Color> colors = new List<Color>();
            colors = colorManager.List();

            foreach (var c in colors)
            {
                Console.WriteLine(c.color_name);
            }
        }

        private static void ProductList(ProductManager productManager)
        {
            
            List<Product> products = new List<Product>();
            products = productManager.List();

            foreach (var p in products)
            {
                Console.WriteLine(p.product_name);
            }
        }

       

 



    }

       

    
}
