using MVVMExpenses.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMExpenses.DataBase
{
    public class MyDbContext : DbContext
    {
        static MyDbContext()
        {
            Database.SetInitializer<MyDbContext>(null);
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
