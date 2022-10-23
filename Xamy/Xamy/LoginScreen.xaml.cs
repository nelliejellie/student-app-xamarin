using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamy.DataLayer.Entities;

namespace Xamy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginScreen : ContentPage
    {
        private readonly IGoogleManager _googleManager;

        GoogleUser GoogleUser = new GoogleUser();
        public bool IsLoggedIn { get; set; }
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
            _googleManager = DependencyService.Get<IGoogleManager>();
            //CheckUserLoggedIn();
            
        }

         void Button_Clicked(object sender, EventArgs e)
        {
            _googleManager.Login(OnLoginComplete);
            
                
        }

        private void CheckUserLoggedIn()
        {
            _googleManager.Login(OnLoginComplete);
        }

        private async void OnLoginComplete(GoogleUser googleUser, string message)
        {
            //if (IsLoggedIn)
            //{
            //    await Navigation.PushAsync(new StudentListScreen());
            //}
            
            if (googleUser != null)
            {
                GoogleUser = googleUser;
                IsLoggedIn = true;
                var nextScreen = new StudentListScreen();
                nextScreen.BindingContext = googleUser;
                
                await Navigation.PushAsync(new StudentListScreen());
            }
            else
            {
                DisplayAlert("Message", message, "OK");
                await Navigation.PushAsync(new LoginScreen());
            }
        }

        public void GoogleLogOut()
        {
            _googleManager?.Logout();
            IsLoggedIn = false;
        }


    }
}