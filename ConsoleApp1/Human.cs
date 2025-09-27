using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Human
    {
        public string Name;
        public int Age;
        public double Height;
        public double Weight;


        public void PrintAbout()
        {
            Console.WriteLine($"Человек с именем {Name} возраста {Age}");
        }

        public Human (string name, int age, double height, double weight)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }
    }
}
