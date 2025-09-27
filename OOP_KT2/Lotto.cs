using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KT2
{
    internal class Lotto
    {
        private readonly List<int> _numberStorage = new List<int>();

        private static List<int> _allNumbers = new List<int>();

        public int GetNumber()
        {
            int currentNumber = 0;

            Random randomNumbers = new Random();

            while (true)
            {
                currentNumber = randomNumbers.Next(1, 101);

                if (_numberStorage.Count >= 100)
                {
                    Console.WriteLine("No more numbers left!");
                    return -1;
                }
                else if (!_numberStorage.Contains(currentNumber))
                {
                    _numberStorage.Add(currentNumber);
                    _allNumbers.Add(currentNumber);

                    return currentNumber;
                }
            }
        }

        static public void PrintGamesStat()
        {
            for (int i = 1; i <= 100; i++)
            {
                int counter = 0;
                
                for (int j = 0; j < _allNumbers.Count; j++) 
                {
                    if (_allNumbers[j] == i)
                    {
                        counter++;
                    }
                }
                if (counter > 0)
                {
                    Console.WriteLine($"Number {i} came up {counter} times");
                }
            }
        }
    }
}
