using DataAccess.Concrete.NpgSql;
using System;
using System.Data;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandDalTest();
            //ColorDalTest();
        }

        private static void BrandDalTest()
        {
            NSBrandDal nSBrandDal = new NSBrandDal();
            string query = "select*from brands";
            DataSet dataSet = new DataSet();
            dataSet = nSBrandDal.List(query);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Console.Write(dataSet.Tables[0].Rows[i]["brand_id"].ToString());

                Console.Write(dataSet.Tables[0].Rows[i]["brand_name"].ToString());
                Console.WriteLine();

            }
        }
        private static void ColorDalTest()
        {
            NSColorDal nSColorDal = new NSColorDal();
            string query = "select*from colors";
            DataSet dataSet = new DataSet();
            dataSet = nSColorDal.List(query);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Console.Write(dataSet.Tables[0].Rows[i]["color_id"].ToString());

                Console.Write(dataSet.Tables[0].Rows[i]["color_name"].ToString());
                Console.WriteLine();

            }
        }
    }
}
