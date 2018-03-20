using System;
using System.Collections.Generic;
using System.Text;
using EstateMgrCore.Commands;
using LiveCharts;
namespace EstateMgrCore.ViewModels
{
    public class MainWindowViewModel<TDefaultViewModel, TColumnSeries> : BaseNotifyPropertyChanged
        where TDefaultViewModel : BaseNotifyPropertyChanged
        where TColumnSeries : LiveCharts.Definitions.Series.ISeriesView, new()
    {
        public BaseCommand<Type> LoadYearGraph
        {
            get => new BaseCommand<Type>((type) =>
            {
                CurrentGraph = NavigationService.GetView<Graph1ViewModel<TColumnSeries>>(type);
            });
        }
        public BaseCommand<Type> LoadMonthGraph
        {
            get => new BaseCommand<Type>((type) =>
            {
                CurrentGraph = NavigationService.GetView<Graph2ViewModel<TColumnSeries>>(type);
            });
        }
        public object CurrentGraph
        {
            get => GetProperty<object>();
            private set => SetProperty(value);
        }

        public MainWindowViewModel(Type tView)
        {
            CurrentGraph = NavigationService.GetView<TDefaultViewModel>(tView);
        }
    }
}
