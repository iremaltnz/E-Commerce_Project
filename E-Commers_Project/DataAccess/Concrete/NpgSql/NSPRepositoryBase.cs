using DataAccess.Abstract;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccess.Concrete.NpgSql
{
    public class NSPRepositoryBase : IEntityRepository
    {
        NpgsqlConnection npgsql= new NpgsqlConnection(@"Server=chunee.db.elephantsql.com;Port=5432;User Id=lnimvljt;Password=YXkBhzMdvSpezCyfWKKcZyqOhKWy7-Iz;Database=lnimvljt");
        public void Add(string query)
        {
           
            NpgsqlCommand cmd = new NpgsqlCommand(query, npgsql);
            npgsql.Open();
           int x= cmd.ExecuteNonQuery();
            npgsql.Close();
        }

        public void Delete(string query)
        {
            throw new NotImplementedException();
        }

        public DataSet List(string query)
        {
            npgsql.Open();

            DataSet dataSet = new DataSet();

            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(query, npgsql);
            npgsqlDataAdapter.Fill(dataSet);

            npgsql.Close();
            return dataSet;
        }

        public void Update(string query)
        {
            throw new NotImplementedException();
        }
    }
}
