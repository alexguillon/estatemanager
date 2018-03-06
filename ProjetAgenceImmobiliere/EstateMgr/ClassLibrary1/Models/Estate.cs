using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstateMgrCore.ViewModels
{
    public class Estate : ViewModels.BaseNotifyPropertyChanged
    {
      public enum type { house, flat, field, garage, commercial};

      [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int Id
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

       public float Surface
        {
            get { return GetProperty<float>(); }
            set { SetProperty(value); }
        }

        public int OwnerId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public int AddressId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public int PropertyTax
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public type Type
        {
            get { return GetProperty<type>(); }
            set { SetProperty(value); }
        }

        public int RoomsCount
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public int FloorNumber
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public int FloorsCount
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public int RepresentId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        //[ForeignKey(nameof(RepresentId))]
        //public Person Person { get; set; }
    }
}
