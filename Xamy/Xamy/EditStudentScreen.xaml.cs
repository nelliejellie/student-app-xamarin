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
    public partial class EditStudentScreen : ContentPage
    {
        public Student _Student { get; set; }
        public EditStudentScreen(Student student)
        {
            InitializeComponent();
            _Student = student;
            name.Text = _Student.Name;
            Course.Text = _Student.Course;
        }

        public async void Button_Clicked(object sender, EventArgs e)
        {
            var student = Student.StudentList.Where(x => x.Name == _Student.Name).SingleOrDefault();
            student.Name = name.Text;
            student.Course = Course.Text;
            
            await Navigation.PopAsync();
        }
    }
}