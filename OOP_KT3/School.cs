using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KT3
{
    internal class School
    {
        private readonly Dictionary<string, List<Student>> _schoolStructure = new Dictionary<string, List<Student>>();
        
        public void EnrollStudent(Student student)
        {
            if (!_schoolStructure.ContainsKey(student.Class))
            {
                _schoolStructure[student.Class] = new List<Student>();

                _schoolStructure[student.Class].Add(student);
            }
        }

        public void PrintClassInfo(string @class)
        {
            foreach (Student student in _schoolStructure[@class])
            {
                student.PrintInfo();
            }
        }


    }
}
