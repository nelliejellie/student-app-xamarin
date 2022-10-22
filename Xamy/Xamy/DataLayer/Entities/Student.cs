using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Xamy.DataLayer.Entities
{
    public class Student
    {
        public static ObservableCollection<Student> StudentList = new ObservableCollection<Student>();
        public Student()
        {
            CreatedAt = DateTime.Now;
        }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Course { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
