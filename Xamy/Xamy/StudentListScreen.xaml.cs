using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamy.DataLayer.Repository;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamy.DataLayer.Entities;

namespace Xamy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentListScreen : ContentPage
    {
        public StudentListScreen()
        {
            InitializeComponent();
            myStudentList.ItemsSource = Student.StudentList;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StudentFormPage());
        }

    }
}