using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamy.DataLayer.Entities;
using Xamy.DataLayer.Repository;

namespace Xamy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentFormPage : ContentPage
    {
        public StudentFormPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(Course.Text))
            {
                await DisplayAlert("Wrong Input", "fix empty input values", "Cool");
            }
            else
            {
                AddNewStudent();
            }

            
            await Navigation.PopAsync();
        }

        private async void AddNewStudent()
        {
            await App.Database.CreateStudent(new Student
            {
                Name = name.Text,
                Course = Course.Text,
                ImageUrl = "https://thumbs.dreamstime.com/b/businessman-icon-image-male-avatar-profile-vector-glasses-beard-hairstyle-179728610.jpg"
            });
        }
    }
}