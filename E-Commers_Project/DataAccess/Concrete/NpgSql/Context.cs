using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.NpgSql
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=chunee.db.elephantsql.com;Port=5432;User Id=lnimvljt;Password=YXkBhzMdvSpezCyfWKKcZyqOhKWy7-Iz;Database=lnimvljt");
        }

        public DbSet<Color> colors { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Brand> brands { get; set; }
    }
}
