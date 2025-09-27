using System.Globalization;

namespace HashSet_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>(); // Он нужен для вывода уникальных значений
            Random rn = new Random();

            for (int i = 0; i < 100; i++)
            {
                numbers.Add(rn.Next(1, 100));
            }

            Console.WriteLine(numbers.Count());
        }
    }
}
