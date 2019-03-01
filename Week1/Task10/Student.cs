using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Student : Person
    {
        public int StudentID { get; set; }

        public Student(string _name, int _age, int _stdid)
        {
            Name = _name;
            Age = _age;
            StudentID = _stdid;
        }

        public string GetStudentDeets()
        {
            return $"First Name: {Name}\n Age: {Age}\n Student ID: {StudentID}\n";
        }
    }
}
