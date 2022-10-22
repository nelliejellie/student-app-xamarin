using System;
using System.Collections.Generic;
using System.Text;
using Xamy.DataLayer.Entities;

namespace Xamy.DataLayer.Repository
{
    public static class StudentRepository
    {
        // in house static repository

        public static List<Student> Students()
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    Name = "Nelson Ewelike",
                    ImageUrl = "https://png.pngtree.com/png-vector/20191101/ourlarge/pngtree-male-avatar-simple-cartoon-design-png-image_1934458.jpg",
                    Course = "Computer Science"
                },
                new Student()
                {
                    Name = "Justin Ewelike",
                    ImageUrl = "https://thumbs.dreamstime.com/b/businessman-icon-image-male-avatar-profile-vector-glasses-beard-hairstyle-179728610.jpg",
                    Course = "Electrical Electronics"
                }
            };
            return students;
        }
    }
}
