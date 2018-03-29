using EstateMgrCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateMgrCore.ViewModels.AddDeleteWindowModel
{
    public class AddWindowModel : BaseNotifyPropertyChanged
    {
        public AddWindowModel()
        {
            Array list = DataAccess.AgencyDbContext.Current.Person.Where(a => a.Mail == "l.jude@gmail.com").ToArray();
            String NbPers = "Il y a " + list.Length + " personnes";
            Console.WriteLine(NbPers);
            Person p = DataAccess.AgencyDbContext.Current.Person.Find(1);
        }
    }
}
