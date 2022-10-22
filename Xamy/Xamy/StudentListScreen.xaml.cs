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
        public Student SelectedStudent { get; set; }
        public StudentListScreen()
        {
            InitializeComponent();
            DisplayAlert("Hints", "press each item to choose between deleting and editing", "Ok");
            myStudentList.ItemsSource = Student.StudentList;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StudentFormPage());
        }

        public void Delete_Student(object sender, EventArgs e)
        {
            DisplayAlert("yeah", "yeah", "yae");
            
            
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var student = menuItem.CommandParameter as Student;
            Student.StudentList.Remove(student);
        }

        private async void Edit_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var student = menuItem.CommandParameter as Student;
            await Navigation.PushAsync(new EditStudentScreen(student));
        }

        public void StudentList_Referesh(object sender, EventArgs e)
        {
            myStudentList.ItemsSource = null;
            myStudentList.ItemsSource = Student.StudentList;
            myStudentList.EndRefresh();
        }
    }
}