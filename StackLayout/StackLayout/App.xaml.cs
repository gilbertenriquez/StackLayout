using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StackLayout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StackLayout2();
        //here just change the mainpage to stacklayout2 if you want to run the stacklayout2
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
