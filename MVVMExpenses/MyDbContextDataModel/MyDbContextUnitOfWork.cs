using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using MVVMExpenses.DataBase;
using MVVMExpenses.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVVMExpenses.MyDbContextDataModel {

    /// <summary>
    /// A MyDbContextUnitOfWork instance that represents the run-time implementation of the IMyDbContextUnitOfWork interface.
    /// </summary>
    public class MyDbContextUnitOfWork : DbUnitOfWork<MyDbContext>, IMyDbContextUnitOfWork {

        public MyDbContextUnitOfWork(Func<MyDbContext> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Account, long> IMyDbContextUnitOfWork.Accounts {
            get { return GetRepository(x => x.Set<Account>(), (Account x) => x.ID); }
        }

        IRepository<Transaction, long> IMyDbContextUnitOfWork.Transactions {
            get { return GetRepository(x => x.Set<Transaction>(), (Transaction x) => x.ID); }
        }

        IRepository<Category, long> IMyDbContextUnitOfWork.Categories {
            get { return GetRepository(x => x.Set<Category>(), (Category x) => x.ID); }
        }
    }
}
