using DevExpress.Mvvm.DataModel;
using MVVMExpenses.DataBase;
using MVVMExpenses.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVVMExpenses.MyDbContextDataModel {

    /// <summary>
    /// IMyDbContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IMyDbContextUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Account entities repository.
        /// </summary>
		IRepository<Account, long> Accounts { get; }
        
        /// <summary>
        /// The Transaction entities repository.
        /// </summary>
		IRepository<Transaction, long> Transactions { get; }
        
        /// <summary>
        /// The Category entities repository.
        /// </summary>
		IRepository<Category, long> Categories { get; }
    }
}
