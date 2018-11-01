using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVVMExpenses.DataModels;
using DevExpress.XtraEditors;

namespace MVVMExpenses.Views.Account
{
    [DevExpress.Utils.MVVM.UI.ViewType("AccountCollectionView")]
    public partial class AccountsView : UserControl
    {
        
        public AccountsView()
        {
            InitializeComponent();
        }
    }
}
