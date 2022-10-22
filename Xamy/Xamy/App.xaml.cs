using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginScreen())
            {
                BarBackgroundColor = Color.LightYellow,
                BarTextColor = Color.Black,
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
