using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamDesignPattern.Memento
{
    public class MementoViewModel:BaseNotifyChanged
    {
        private string name;
        private int age;
        MementoModel previousValue = null;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged();
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
                NotifyPropertyChanged();
            }
        }

        public Command UpdateCommand { set; get; } 
        public Command RevertCommand { set; get; } 
        public MementoViewModel()
        {
            Name = "Bruce";
            Age = 27;
            previousValue = new MementoModel(Name, Age);
            UpdateCommand = new Command(Update);
            RevertCommand = new Command(Revert);
        }

        private async void Update(object obj)
        {
            var result = await App.Current.MainPage.DisplayAlert("Are you sure?", "Do you want to update the values, once updated cannot be reverted?", "Yes", "No");
            if(!result)
            {
                Name = previousValue.Name;
                Age = previousValue.Age;
            }
            else
            {
                previousValue.Name = Name;
                previousValue.Age = Age;
            }
        }

        public void Revert()
        {
            Name = previousValue.Name;
            Age = previousValue.Age;
        }
    }
}
