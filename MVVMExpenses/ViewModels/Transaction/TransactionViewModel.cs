using DevExpress.Mvvm.DataModel;
using MVVMExpenses.Common;
using MVVMExpenses.DataModels;
using MVVMExpenses.MyDbContextDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMExpenses.ViewModels.Transaction
{
    public class TransactionViewModel : SingleObjectViewModel<MVVMExpenses.DataModels.Transaction, long, IMyDbContextUnitOfWork>
    {
        /// <summary>
        /// Initializes a new instance of the TransactionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TransactionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TransactionViewModel(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Transactions, x => x.Comment)
        {
        }
    }
}
