﻿using DataAccess.Concrete.NpgSql;
using System;
using System.Data;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDalTest();
            CategoryDalTest();

        }

        private static void CategoryDalTest()
        {
            NSPCategoryDal nSPCategoryDal = new NSPCategoryDal();
            string query = "select*from categories";
            DataSet dataSet = new DataSet();
            dataSet = nSPCategoryDal.List(query);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Console.Write(dataSet.Tables[0].Rows[i]["category_id"].ToString());

                Console.Write(dataSet.Tables[0].Rows[i]["category_name"].ToString());
                Console.WriteLine();

            }
        }

        private static void ProductDalTest()
        {
            NSProductDal nSProductDal = new NSProductDal();
            string query = "select*from products";
            DataSet dataSet = new DataSet();
            dataSet = nSProductDal.List(query);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Console.Write(dataSet.Tables[0].Rows[i]["product_id"].ToString());

                Console.Write(dataSet.Tables[0].Rows[i]["product_name"].ToString());
                Console.WriteLine();

            }
        }
    }
}
