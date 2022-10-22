using System;
using System.IO;
using System.Runtime.InteropServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamy.DataLayer.Entities;

namespace Xamy
{
    public partial class App : Application
    {
        private static Repository _database;

        public static Repository Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new Repository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyStore.db3"));
                }
                return _database;
            }
            
         }
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
 