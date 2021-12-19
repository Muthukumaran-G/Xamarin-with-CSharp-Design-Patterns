using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace XamDesignPattern.Bridge
{
    public class BridgeViewModel:BaseNotifyChanged
    {
        private string sendValue;
        private bool isSMS;
        private bool isWebAPI;
        public ObservableCollection<string> Collection { get; set; }

        public string SendValue
        {
            get
            {
                return sendValue;
            }
            set
            {
                sendValue = value;
                NotifyPropertyChanged();
            }
        }

        public bool IsSMS
        {
            get
            {
                return isSMS;
            }
            set
            {
                isSMS = value;
                NotifyPropertyChanged();
            }
        }

        public bool IsWebAPI
        {
            get
            {
                return isWebAPI;
            }
            set
            {
                isWebAPI = value;
                NotifyPropertyChanged();
            }
        }

        public Command SendCommand { get; set; }

        public BridgeViewModel()
        {
            SendCommand = new Command(SendMessage);
        }

        private void SendMessage(object obj)
        {
            if (IsSMS && IsWebAPI)
            {
                var sms = new SendSMS();
                sms.bridge = new WebAPI();
                SendValue = sms.bridge.Send(sms.Send());
            }
            else if(IsSMS && !IsWebAPI)
            {
                var sms = new SendSMS();
                sms.bridge = new CustomAPI();
                SendValue = sms.bridge.Send(sms.Send());
            }
            else if(!IsSMS && IsWebAPI)
            {
                var sms = new SendEMAIL();
                sms.bridge = new WebAPI();
                SendValue = sms.bridge.Send(sms.Send());
            }
            else
            {
                var sms = new SendEMAIL();
                sms.bridge = new CustomAPI();
                SendValue = sms.bridge.Send(sms.Send());
            }
        }
    }

    public interface IBridge
    {
        string Send(string MessageType);
    }

    public abstract class SendData
    {
        public IBridge bridge;
        public abstract string Send();
    }

    public class SendSMS : SendData
    {
        public override string Send()
        {
            return "SMS";
        }
    }

    public class SendEMAIL : SendData
    {
        public override string Send()
        {
            return "EMAIL";
        }
    }

    public class WebAPI : IBridge
    {
        public string Send(string MessageType)
        {
            return "Sending " + MessageType + " using Web API";
        }
    }

    public class CustomAPI : IBridge
    {
        public string Send(string MessageType)
        {
            return "Sending " + MessageType + " using custom API";
        }
    }
}
