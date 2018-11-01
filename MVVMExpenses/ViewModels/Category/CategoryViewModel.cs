using DevExpress.Mvvm.DataModel;
using MVVMExpenses.Common;
using MVVMExpenses.DataModels;
using MVVMExpenses.MyDbContextDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMExpenses.ViewModels.Category
{
    public class CategoryViewModel : SingleObjectViewModel<MVVMExpenses.DataModels.Category, long, IMyDbContextUnitOfWork>
    {
        /// <summary>
        /// Initializes a new instance of the CategoryViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CategoryViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CategoryViewModel(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Categories, x => x.Name)
        {
        }
    }
}
