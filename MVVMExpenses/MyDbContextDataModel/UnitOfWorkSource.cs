using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using MVVMExpenses.DataBase;
using System;
using System.Collections;
using System.Linq;

namespace MVVMExpenses.MyDbContextDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IMyDbContextUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IMyDbContextUnitOfWork>(() => new MyDbContextUnitOfWork(() => new MyDbContext()));
        }
    }
}