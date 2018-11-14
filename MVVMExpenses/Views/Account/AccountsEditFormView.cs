using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVVMExpenses.ViewModels.Account;

namespace MVVMExpenses.Views.Account
{
    [DevExpress.Utils.MVVM.UI.ViewType("AccountView")]
    public partial class AccountsEditFormView : UserControl
    {
        public AccountsEditFormView()
        {
            InitializeComponent();
            //Account Edit Form View 
            var fluent = mvvmContext1.OfType<AccountViewModel>();
            fluent.SetObjectDataSourceBinding(accountBindingSource, x => x.Entity, x => x.Update());
        }
    }
}
