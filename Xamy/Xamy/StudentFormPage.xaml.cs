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
            Student student = new Student()
            {
                Name = name.Text,
                Course = Course.Text,
                ImageUrl = "https://thumbs.dreamstime.com/b/businessman-icon-image-male-avatar-profile-vector-glasses-beard-hairstyle-179728610.jpg"
            };
            Student.StudentList.Add(student);
            await Navigation.PopAsync();
        }
    }
}