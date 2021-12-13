using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZCApi
{
    public class DataBaseHelper : DbContext
    {
        public DbSet<Station> Station { get; set; }
        public DbSet<Date> Date {get; set; }

        public DataBaseHelper(DbContextOptions<DataBaseHelper> options)
            : base(options)
        {

        }

        public DataBaseHelper()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Data Source='192.168.1.4, 666';Initial Catalog=Refill;Persist Security Info=True;User ID=sa;Password=sa");
    }
}
