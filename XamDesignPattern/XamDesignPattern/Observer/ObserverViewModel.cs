using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamDesignPattern.Observer
{
    public class ObserverViewModel
    {
        public ObservableCollection<string> Collection { get; set; }

        public ObserverViewModel()
        {
            INotify obj1 = new MailNotify();
            INotify obj2 = new SMSNotify();
            Notifier notifier = new Notifier();
            notifier.AddService(obj1);
            notifier.AddService(obj2);
            notifier.ExecuteNotifier();
            Collection = new ObservableCollection<string>(notifier.NotifyMessageList);
        }
    }

    public interface INotify
    {
        string Notify();
    }

    public class MailNotify : INotify
    {
        public string Notify()
        {
            return "Notify through Mail";
        }
    }

    public class EventNotify : INotify
    {
        public string Notify()
        {
            return "Notify through Event";
        }
    }

    public class SMSNotify : INotify
    {
        public string Notify()
        {
            return "Notify through SMS";
        }
    }

    class Notifier
    {
        public ArrayList NotifyObserverList = new ArrayList();
        public string[] NotifyMessageList;
        public void AddService(INotify obj)
        {
            NotifyObserverList.Add(obj);
        }
         
        public void RemoveService(INotify obj)
        {
            NotifyObserverList.Remove(obj);
        }

        public void ExecuteNotifier()
        {
            NotifyMessageList = new string[NotifyObserverList.Count];
            for (int i = 0; i < NotifyObserverList.Count; i++)
            {
                NotifyMessageList[i] = (NotifyObserverList[i] as INotify).Notify();
            }
        }
    }
}
