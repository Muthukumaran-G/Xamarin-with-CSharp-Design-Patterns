using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamDesignPattern
{
    public class DecoratorViewModel:BaseNotifyChanged
    {
        private int ticketPrice;
        private int ticketTax;
        private int totalCost;
        public int TicketPrice
        {
            get
            {
                return ticketPrice;
            }
            set
            {
                ticketPrice = value;
                NotifyPropertyChanged();
            }
        }

        public int TicketTax
        {
            get
            {
                return ticketTax;
            }
            set
            {
                ticketTax = value;
                NotifyPropertyChanged();
            }
        }

        public int TotalCost
        {
            get
            {
                return totalCost;
            }
            set
            {
                totalCost = value;
                NotifyPropertyChanged();
            }
        }

        public Command TicketCommand { get; set; }
        public Command SpecialTicketCommand { get; set; }
        public DecoratorViewModel()
        {
            TicketCommand = new Command(GetTicketPrice);
            SpecialTicketCommand = new Command(GetSpecialTicketPrice);
        }

        private void GetSpecialTicketPrice(object obj)
        {
            var specialTicket = new SpecialTicket();
            TicketPrice = specialTicket.Price;
            TicketTax = specialTicket.Tax;
            TotalCost = specialTicket.TotalCost;
        }

        private void GetTicketPrice(object obj)
        {
            var ticket = new Ticket();
            TicketPrice = ticket.Price;
            TicketTax = ticket.Tax;
            TotalCost = ticket.TotalCost;
        }
    }
}
