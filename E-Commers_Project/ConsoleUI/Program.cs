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


            Brand brand = new Brand();
            Product product = new Product();
            Color color = new Color();
            Category category = new Category();
   

        }
        private static void CategoryUpdate(Category category)
        {
            CategoryManager categoryManager = new CategoryManager(new NSCategoryDal());
            categoryManager.Update(category);
        }
        private static void CategoryDelete(Category category)
        {
            CategoryManager categoryManager = new CategoryManager(new NSCategoryDal());
            categoryManager.Delete(category);
        }

        private static void CategoryAdd(Category category)
        {
            CategoryManager categoryManager = new CategoryManager(new NSCategoryDal());
            categoryManager.Add(category);
        }
        private static void ColorUpdatee(Color color)
        {
            ColorManager colorManager = new ColorManager(new NSColorDal());
            colorManager.Update(color);
        }
        private static void ColorDelete(Color color)
        {
            ColorManager colorManager = new ColorManager(new NSColorDal());
            colorManager.Delete(color);
        }

        private static void ColorAdd(Color color)
        {
            ColorManager colorManager = new ColorManager(new NSColorDal());
            colorManager.Add(color);
        }

        private static void ProductDelete(Product product)
        {
            ProductManager productManager = new ProductManager(new NSProductDal());

            productManager.Delete(product);
        }

        private static void ProductUpdate(Product product)
        {
            ProductManager productManager = new ProductManager(new NSProductDal());

            productManager.Update(product);
        }

        private static void ProductAdd(Product product)
        {
            ProductManager productManager = new ProductManager(new NSProductDal());

            productManager.Add(product);

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

       

 



    }

       

    
}
