using System;
using System.Collections.Generic;
using System.Text;

namespace XamDesignPattern
{
    public class MementoModel:BaseNotifyChanged
    {
        private string name;
        private int age;

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

        public MementoModel(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
