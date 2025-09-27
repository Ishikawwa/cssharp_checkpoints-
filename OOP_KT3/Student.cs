using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KT3
{
    internal class Student
    {
        private readonly string _name;
        private readonly string _lastName;
        private readonly string _averageGrade;
        public string Class;

        public Student (string name, string lastName, string averageGrade, string @class)
        {
            _name = name;
            _lastName = lastName;
            _averageGrade = averageGrade;
            Class = @class;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student {_name} {_lastName} of a class {Class} has {_averageGrade} grade");
        }
    }
}
