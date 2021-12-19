using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamDesignPattern
{
    public class StrategyViewModel : BaseNotifyChanged
    {
        public double basicPay;
        public double allowance;
        public double totalPay;
        public double BasicPay
        {
            get
            {
                return basicPay;
            }
            set
            {
                basicPay = value;
                NotifyPropertyChanged();
            }
        }

        public double Allowance
        {
            get
            {
                return allowance;
            }
            set
            {
                allowance = value;
                NotifyPropertyChanged();
            }
        }

        public double TotalPay
        {
            get
            {
                return totalPay;
            }
            set
            {
                totalPay = value;
                NotifyPropertyChanged();
            }
        }

        public Command WithTaxCommand { get; set; }
        public Command WithoutTaxCommand { get; set; }

        public StrategyViewModel()
        {
            WithTaxCommand = new Command(CalculateWithTax);
            WithoutTaxCommand = new Command(CalculateWithoutTax);
        }

        private void CalculateWithoutTax(object obj)
        {
            PayStrategy pay = new PayStrategy();
            pay.basicPay = this.BasicPay;
            pay.allowance = this.Allowance;
            pay.setStatergy(new WithoutTax());
            TotalPay = pay.Show();
        }

        private void CalculateWithTax(object obj)
        {
            PayStrategy pay = new PayStrategy();
            pay.basicPay = this.BasicPay;
            pay.allowance = this.Allowance;
            pay.setStatergy(new WithTax());
            TotalPay = pay.Show();
        }
    }

    public abstract class IPay
    {
        public abstract double Display(double BasicPay, double Allowance);
    }

    public class WithTax : IPay
    {
        public override double Display(double BasicPay, double Allowance)
        {
            return (BasicPay + Allowance) * 0.92;
        }
    }

    public class WithoutTax : IPay
    {
        public override double Display(double BasicPay, double Allowance)
        {
            return BasicPay + Allowance;
        }
    }

    public class PayStrategy
    {
        public double basicPay;
        public double allowance;
        private IPay payStrategy;
        public void setStatergy(IPay obj)
        {
            payStrategy = obj;
        }
        public double Show()
        {
            return payStrategy.Display(basicPay, allowance);
        }
    }
}
