﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstateMgrCore.Models
{
    public class SaleTransaction : ViewModels.BaseNotifyPropertyChanged
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }
        [ForeignKey(nameof(TransactionId))]
        public int TransactionId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }
        public double Price
        {
            get { return GetProperty<double>(); }
            set { SetProperty(value); }
        }
    }
}