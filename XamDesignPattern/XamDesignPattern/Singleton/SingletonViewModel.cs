using System;
using System.Collections.Generic;
using System.Text;

namespace XamDesignPattern
{
    public class SingletonViewModel
    {
        private static object lockObject = new Object(); //When you synchronize thread access to a shared resource, lock on a dedicated object instance

        private static SingletonViewModel instance;

        public static SingletonViewModel GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        instance = new SingletonViewModel();
                    }
                }

                return instance;
            }
        }

        public string User
        {
            get
            {
                return "Welcome!!!";
            }
        }

        // Make the constructor private so that no one can create an object of the singleton class
        private SingletonViewModel()
        {

        }
    }
}
