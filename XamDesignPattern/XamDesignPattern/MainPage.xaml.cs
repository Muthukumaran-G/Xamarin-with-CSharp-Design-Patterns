using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamDesignPattern
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new AdaptorPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new BridgePage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new CompositePage());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new DecoratorPage());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new FactoryPage());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new MementoPage());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ObserverPage());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new PrototypePage());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new SingletonPage());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new StrategyPage());
        }
    }

    public class BaseNotifyChanged : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        internal void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
