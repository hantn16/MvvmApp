using MVVMExpenses.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVMExpenses
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //this.Opacity = 0;
            if (!DesignMode)
                InitializeNavigation();
        }
        //public virtual TModule DefaultModule { get { return Modules.ElementAt(2)}; }
        void InitializeNavigation()
        {
            var fluentAPI = mvvmContext1.OfType<MyDbContextViewModel>();
            fluentAPI.BindCommand(biAccounts, (context, module) => context.Show(module), (context) => context.Modules[0]);
            fluentAPI.BindCommand(biCategories, (context, module) => context.Show(module), (context) => context.Modules[1]);
            fluentAPI.BindCommand(biTransactions, (context, module) => context.Show(module), (context) => context.Modules[2]);
            fluentAPI.WithEvent<EventArgs>(this, "Load").EventToCommand(context => context.OnLoaded(null), context => context.DefaultModule);
            //Sets the third module, 'Transactions', as the default module 


        }
    }
}
