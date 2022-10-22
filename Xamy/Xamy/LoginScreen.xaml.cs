using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginScreen : ContentPage
    {
        public LoginScreen()
        {
            InitializeComponent();
            string UriImage = "https://www.loginradius.com/blog/static/a9dad0fc4bf1af95243aa5e2d017bc22/a8669/google_cover.jpg";
            GoogleImage.Source = new UriImageSource
            {
                Uri = new Uri(UriImage),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(3, 0, 0, 0),
            };
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            // DisplayAlert("Google Login", "Login with google", "OK");
            await Navigation.PushAsync(new StudentListScreen());
        }
    }
}