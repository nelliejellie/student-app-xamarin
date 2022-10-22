using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Xamy.DataLayer.Entities
{
    public class Repository
    {
        private readonly SQLiteAsyncConnection _database;

        public Repository(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Student>(); 
        }

        public Task<int> CreateStudent(Student student)
        {
            return _database.InsertAsync(student);
        }

        public Task<List<Student>> GetAllStudents()
        {
            return _database.Table<Student>().ToListAsync();
        }

        public Task<int> UpdateStudent(Student student)
        {
            return _database.UpdateAsync(student);
        }

        public Task<int> DeleteStudent(Student student)
        {
            return _database.DeleteAsync(student);
        }
    }
}
