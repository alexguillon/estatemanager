﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstateMgrCore.Models
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

        public int ReferentId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }
        public int TransactionId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        [ForeignKey(nameof(ReferentId))]
        public Person Referent { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public Person Owner { get; set; }

        [InverseProperty(nameof(Transaction.EstateTransaction))]
        public ObservableCollection<Transaction> Transactions
        {
            get { return GetProperty<ObservableCollection<Transaction>>(); }
            protected set { SetProperty(value); }
        }
     
        [ForeignKey(nameof(AddressId))]
        public Address AddressEstate { get; set; }

        
        [InverseProperty(nameof(Photos.EstatePhoto))]
        public ObservableCollection<Photos> Estate_photos
        {
            get { return GetProperty<ObservableCollection<Photos>>(); }
            protected set { SetProperty(value); }
        }
    }
}
