using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.POCO;
using MVVMExpenses.Common;
using MVVMExpenses.DataModels;
using MVVMExpenses.MyDbContextDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVVMExpenses.ViewModels.Account
{
    /// <summary>
    /// Represents the single Account object view model.
    /// </summary>
    public partial class AccountViewModel : SingleObjectViewModel<MVVMExpenses.DataModels.Account, long, IMyDbContextUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of AccountViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AccountViewModel Create(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new AccountViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AccountViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AccountViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AccountViewModel(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Accounts, x => x.Name)
        {
        }

        //public CollectionViewModel<Transaction, long, IMyDbContextUnitOfWork> AccountTransactionDetails
        //{
        //    get { return GetDetailsCollectionViewModel((AccountViewModel x) => x.AccountTransactionDetails, x => x.Transactions, x => x.AccountID, (x, key) => x.AccountID = key); }
        //}
    }
}
