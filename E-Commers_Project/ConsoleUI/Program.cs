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
            //BrandList();
            //ColorList();
            //ProductList();
            //CategoryList();
            //CategoryAdd();

            //  CategoryUpdate();
            //CategoryDelete();
        }

        private static void CategoryDelete()
        {
            CategoryManager categoryManager = new CategoryManager(new NSCategoryDal());
            Category category = new Category();
            category.CategoryId = 6;
            categoryManager.Delete(category);
        }

        private static void CategoryUpdate()
        {
            CategoryManager categoryManager = new CategoryManager(new NSCategoryDal());
            Category category = new Category();
            category.CategoryId = 6;
            category.CategoryName = "deneme";
            categoryManager.Add(category);
        }

        private static void CategoryAdd()
        {
            CategoryManager category = new CategoryManager(new NSCategoryDal());
            Category category1 = new Category();
            category1.CategoryName = "deneme22";
            category.Add(category1);
        }

        private static void BrandList()
        {
            BrandManager brandManager = new BrandManager(new NSBrandDal());
            List<Brand> brands = new List<Brand>();

            brands = brandManager.List();
            foreach (var b in brands)
            {
                Console.WriteLine(b.BrandName);
            }

            Console.WriteLine("-----------");

        }
        private static void CategoryList()
        {

            CategoryManager category = new CategoryManager(new NSCategoryDal());
            List<Category> categories = new List<Category>();

            categories = category.List();
            foreach (var c in categories)
            {
                Console.WriteLine(c.CategoryName);
            }

            Console.WriteLine("-----------");
    }
        private static void ColorList()
        {

            ColorManager colorManager = new ColorManager(new NSColorDal());
            List<Color> colors = new List<Color>();

            colors = colorManager.List();
            foreach (var c in colors)
            {
                Console.WriteLine(c.ColorName);
            }

            Console.WriteLine("-----------");
        }

        private static void ProductList()
        {

            ProductManager productManager = new ProductManager(new NSProductDal());
            List<Product> products = new List<Product>();

            products = productManager.List();
            foreach (var p in products)
            {
                Console.WriteLine(p.ProductName);
            }

            Console.WriteLine("-----------");
        }

            

        }

       

    
}
