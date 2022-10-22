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
            var students = await App.Database.GetAllStudents();
            var student = students.Where(x => x.Id == _Student.Id).FirstOrDefault();
            student.Name = name.Text;
            student.Course = Course.Text;

            await App.Database.UpdateStudent(student);
            
            await Navigation.PopAsync();
        }
    }
}