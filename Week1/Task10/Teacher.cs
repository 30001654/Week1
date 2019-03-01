using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Teacher : Person
    {
        public string StaffLogin { get; set; }

        public Teacher(string _name, int _age, string _staffLogin)
        {
            Name = _name;
            Age = _age;
            StaffLogin = _staffLogin;
        }

        public string GetStudentDeets()
        {
            return $"First Name: {Name}\n Age: {Age}\n Staff Login Name: {StaffLogin}\n";
        }
    }
}
