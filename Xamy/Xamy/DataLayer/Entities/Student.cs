using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SQLite;

namespace Xamy.DataLayer.Entities
{
    public class Student
    {
        public static ObservableCollection<Student> StudentList = new ObservableCollection<Student>()
        {
             new Student()
                {
                    Id = 90,    
                    Name = "Nelson Ewelike",
                    ImageUrl = "https://png.pngtree.com/png-vector/20191101/ourlarge/pngtree-male-avatar-simple-cartoon-design-png-image_1934458.jpg",
                    Course = "Computer Science"
                },
                new Student()
                {
                    Id= 789,
                    Name = "Justin Ewelike",
                    ImageUrl = "https://thumbs.dreamstime.com/b/businessman-icon-image-male-avatar-profile-vector-glasses-beard-hairstyle-179728610.jpg",
                    Course = "Electrical Electronics"
                }
        };
        public Student()
        {
            CreatedAt = DateTime.Now;
        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Course { get; set; }
        [MaxLength(30)]
        public DateTime CreatedAt { get; set; }
    }
}
