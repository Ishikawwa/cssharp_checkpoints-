namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 4 (Задача с лимитом факториалов и их суммой)

            Console.WriteLine("Type maximum amount of numbers from 1 - 10");
            long UserMaximum = long.Parse(Console.ReadLine());
            long Summ = 0;

            for (long i = 1; i <= UserMaximum; i++)
            {
                long Factorial = myFact(i);

                Console.WriteLine(Factorial);
                Summ = Factorial + Summ;
            }
                Console.WriteLine(Summ);
        }

        //public static long Fact(long n) => n == 0 ? 1 : n * Fact(n - 1); --> лямбда функция (написана преподавателем)

        public static long myFact(long n)
        {
            int number = 1; // От 1 ибо низя делать умножение на 0
            for (int i = 1; i <= n; i++)  // Шаг от 1 до n 
            {
                number *= i; // Умножаем предыдущее
            }
            return number; // Возвращаем значением number
        }

    }
}
