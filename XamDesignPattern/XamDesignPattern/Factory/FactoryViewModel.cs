using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace XamDesignPattern
{
    public class FactoryViewModel:BaseNotifyChanged
    {
        private int age;
        private string salary;
        private string name;
        private string experience;

        private EmployeeDetails employee;

        public EmployeeDetails Employee
        {
            get => employee; set
            {
                employee = value;
                NotifyPropertyChanged();
            }
        }

        public int Age
        {
            get => age; set
            {
                age = value;
                NotifyPropertyChanged();
            }
        }

        public string Salary
        {
            get => salary; set
            {
                salary = value;
                NotifyPropertyChanged();
            }
        }

        public string Name
        {
            get => name; set
            {
                name = value;
                NotifyPropertyChanged();
            }
        }
        public string Experience
        {
            get => experience; set
            {
                experience = value;
                NotifyPropertyChanged();
            }
        }

        public Command ButtonCommand { get; set; }

        public FactoryViewModel()
        {
            ButtonCommand = new Command(GetEmployeeDetails);
        }

        private void GetEmployeeDetails(object obj)
        {
            var buttonText = (obj as Button).Text;
            switch(buttonText)
            {
                case "Andrew":
                    this.Employee = new Andrew("Engineer");
                    break;
                case "Mathew":
                    this.Employee = new Mathew("Team Lead");
                    break;
                case "Clerk":
                    this.Employee = new Clerk("Senior Engineer");
                    break;
                default:
                    this.employee = null;
                    break;
            }
            
        }
    }

    public class Andrew : EmployeeDetails
    {
        private string level;
        public override string Name => "Andrew";

        public override int Age => 25;
        public override string Salary => "$25,000";
        public override string Level { get=> level; set => level = value; }

        public Andrew(string _experience)
        {
            level = _experience;
        }
    }

    public class Mathew : EmployeeDetails
    {
        private string level;
        public override string Name => "Mathew";

        public override int Age => 35;
        public override string Salary => "$35,000";
        public override string Level { get => level; set => level = value; }

        public Mathew(string _experience)
        {
            level = _experience;
        }
    }

    public class Clerk : EmployeeDetails
    {
        private string level;
        public override string Name => "Clerk";

        public override int Age => 29;
        public override string Salary => "$29,000";
        public override string Level { get => level; set => level = value; }

        public Clerk(string _experience)
        {
            level = _experience;
        }
    }

    public abstract class EmployeeDetails
    {
        public abstract string Name { get; }
        public abstract int Age { get; }
        public abstract string Salary { get; }
        public abstract string Level { get; set; }
    }
}
