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
        public BaseCommand<Type> LoadHomeWindow
        {
            get => new BaseCommand<Type>((type) =>
            {
                CurrentWindow = NavigationService.GetView<HomeWindowModel.HomeWindowModel<TDefaultViewModel,TColumnSeries>>(type);
            });
        }
        public BaseCommand<Type> LoadEstateWindow
        {
            get => new BaseCommand<Type>((type) =>
            {
                CurrentWindow = NavigationService.GetView<EstateWindowModel.EstateWindowModel>(type);
            });
        }
        public object CurrentWindow
        {
            get => GetProperty<object>();
            private set => SetProperty(value);
        }

        public MainWindowViewModel(Type tView, Type tSubView)
        {
            CurrentWindow = NavigationService.GetView<TDefaultViewModel>(tView, tSubView);
        }
    }
}
