using DataAccess.Concrete.NpgSql;
using System;
using System.Data;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           

            NSRepositoryBase nSRepositoryBase = new NSRepositoryBase();
            string query= "select*from colors";
            DataSet dataSet = new DataSet();
            dataSet=nSRepositoryBase.List(query);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Console.Write( dataSet.Tables[0].Rows[i]["color_id"].ToString());

                Console.Write(dataSet.Tables[0].Rows[i]["color_name"].ToString());
                Console.WriteLine();
            }

            string query2 = "insert into public.colors(color_name) values ('gold')";

            nSRepositoryBase.Add(query2);
        }
    }
}
