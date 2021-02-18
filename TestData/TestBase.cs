using Microsoft.EntityFrameworkCore;
using serviceslibrary.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleTodo.TestData
{
    public class TestBase
    {
        private bool usesqlite;

        public  AppDbContext GetDbContext()
        {

            var builder = new DbContextOptionsBuilder<AppDbContext>();
            if (usesqlite)
            {

                builder.UseSqlite("DataSource = App.db");
            }


            var dbContext = new  AppDbContext(builder.Options);

            if (usesqlite)
            {

                dbContext.Database.OpenConnection();
            }

            return dbContext;
        }

        public void UseSqlite()
        {
            usesqlite = true;
        }
    }
}
