using System;
using System.Collections.Generic;
using System.Text;

namespace EstateMgrCore.ViewModels
{
    public class CurrentEstateOnSaleViewModel : BaseNotifyPropertyChanged
    {

        public string nbreBienEnVente { get; set; }
        public CurrentEstateOnSaleViewModel()
        {
            nbreBienEnVente = "15";
        }

    }
}
