using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVVMExpenses.DataBase;
using MVVMExpenses.DataModels;

namespace MVVMExpenses
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var db = new MyDbContext())
            {
                //var account = new Account { Name = "Han",Amount = 1,ID = 1 };
                //db.Accounts.Add(account);
                //db.SaveChanges();
            }
            Application.Run(new frmMain());
        }
    }
}
