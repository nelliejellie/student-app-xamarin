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

        private readonly IGoogleManager _googleManager;
        public StudentListScreen()
        {
            InitializeComponent();
            DisplayAlert("Hints", "press each item to choose between deleting and editing", "Ok");
            myStudentList.ItemsSource = Student.StudentList;
            _googleManager = DependencyService.Get<IGoogleManager>();
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                myStudentList.ItemsSource = await App.Database.GetAllStudents();
            }
            catch { }
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StudentFormPage());
        }

       

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var student = menuItem.CommandParameter as Student;
            await App.Database.DeleteStudent(student);
        }

        private async void Edit_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var student = menuItem.CommandParameter as Student;
            await Navigation.PushAsync(new EditStudentScreen(student));
        }

        public async void StudentList_Referesh(object sender, EventArgs e)
        {
            myStudentList.ItemsSource = null;
            myStudentList.ItemsSource = await App.Database.GetAllStudents();
            myStudentList.EndRefresh();
        }

        public async void Button_Logout(object sender, EventArgs e)
        {
            _googleManager.Logout();
            await Navigation.PopAsync();
        }
    }
}