using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVMExpenses.Views.Category
{
    [DevExpress.Utils.MVVM.UI.ViewType("CategoryCollectionView")]
    public partial class CategoriesView : UserControl
    {
        public CategoriesView()
        {
            InitializeComponent();
        }
    }
}
