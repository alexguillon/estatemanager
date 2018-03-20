﻿using EstateMgrCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EstateMgr
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected async override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            await EstateMgrCore.DataAccess.AgencyDbContext.Initialize();
<<<<<<< HEAD
=======
            MainWindow = EstateMgrCore.NavigationService.GetView<MainWindow, MainWindowViewModel<Graph1ViewModel<LiveCharts.Wpf.ColumnSeries>, LiveCharts.Wpf.ColumnSeries>>(typeof(YearGraph));
            MainWindow.Show();
>>>>>>> 16281d0d1e6518460c2b232dbc5dc7a35bfe72bf
        }
    }
}
