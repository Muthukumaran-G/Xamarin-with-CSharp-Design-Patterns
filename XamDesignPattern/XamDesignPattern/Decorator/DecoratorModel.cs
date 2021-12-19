using System;
using System.Collections.Generic;
using System.Text;

namespace XamDesignPattern
{
    public class DecoratorModel
    {

    }

    public class Ticket : ITicket
    {
        public int Price => 125;

        public int Tax => 25;

        public int TotalCost => Price + Tax;
    }

    public class SpecialTicket : ITicket
    {
        public int Price => 250;

        public int Tax => 50;

        public int TotalCost => Price + Tax;
    }

    public interface ITicket
    {
        int Price { get; }
        int Tax { get; }
    }
}
