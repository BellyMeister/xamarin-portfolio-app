using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#DB162F"),
                BarTextColor = Color.FromHex("#F6E8EA"),
            };
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
