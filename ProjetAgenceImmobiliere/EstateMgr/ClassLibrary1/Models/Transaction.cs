using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstateMgrCore.Models
{
    public class Transaction : ViewModels.BaseNotifyPropertyChanged
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }
        public int EstateId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }
        public int OwnerId
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }
        public String Title
        {
            get { return GetProperty<String>(); }
            set { SetProperty(value); }
        }
        public String Description
        {
            get { return GetProperty<String>(); }
            set { SetProperty(value); }
        }
        public DateTime CreationDate
        {
            get { return GetProperty<DateTime>(); }
            set { SetProperty(value); }
        }
        public DateTime TransactionDate
        {
            get { return GetProperty<DateTime>(); }
            set { SetProperty(value); }
        }
        [ForeignKey(nameof(EstateId))]
        public Estate EstateTransaction { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public Estate OwnerTransaction { get; set; }

        [InverseProperty(nameof(SaleTransaction.TransactionId))]
        public ObservableCollection<SaleTransaction> Sale_Transactions
        {
            get { return GetProperty<ObservableCollection<SaleTransaction>>(); }
        }
        [InverseProperty(nameof(RentTransaction.RentTransactionId))]
        public ObservableCollection<RentTransaction> RentTransactions
        {
            get { return GetProperty<ObservableCollection<RentTransaction>>(); }
            protected set { SetProperty(value); }
        }
    }
}
