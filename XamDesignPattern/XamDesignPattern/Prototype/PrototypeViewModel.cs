using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace XamDesignPattern
{
    public class PrototypeViewModel
    {
        public ObservableCollection<PrototypeModel> RecipientList { get; set; }
        String[] nameList = { "Anderson", "Clerk", "Bruce", "Nicole", "Jane" };
        PrototypeModel[] modelList = new PrototypeModel[5];

        public PrototypeViewModel()
        {
            // Here our first object has created
            var model = new PrototypeModel();
            model.Recipient = "Anderson";
            model.Sender = "Michelle";
            model.Content = "Invite for scrum meeting";
            model.Time = DateTime.Now;

            for (int i=0; i< nameList.Length; i++)
            {
                // Copying the values from defined objects to new object.
                modelList[i] = model.CloneMe(model);
                modelList[i].Recipient = nameList[i];
                i++;
            }
            RecipientList = new ObservableCollection<PrototypeModel>(modelList);
        }
    }
}
