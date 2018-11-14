﻿using System;
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
using MVVMExpenses.ViewModels;
using DevExpress.XtraGrid.Views.Base;
using System.Data.Entity;

namespace MVVMExpenses.Views.Account
{
    [DevExpress.Utils.MVVM.UI.ViewType("AccountCollectionView")]
    public partial class AccountsView : DevExpress.XtraEditors.XtraUserControl
    {

        public AccountsView()
        {
            InitializeComponent();
            var fluentAPI = mvvmContext1.OfType<AccountCollectionViewModel>();
            fluentAPI.SetBinding(gridView1, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            fluentAPI.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Entities);
            fluentAPI.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
            .SetBinding(x => x.SelectedEntity, args => args.Row as DataModels.Account,
            (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            MVVMExpenses.DataBase.MyDbContext dbContext = new MVVMExpenses.DataBase.MyDbContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Accounts.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    accountsBindingSource.DataSource = dbContext.Accounts.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
