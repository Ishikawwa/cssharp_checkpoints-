namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Addition(45, 7));
            Console.WriteLine(Subtraction(78, 3));
            Console.WriteLine(Multiplication(3, 5));
            Console.WriteLine(Division(24, 5));
        }

        static int Addition (int First, int Second)
        {
            return First + Second;
        }

        static int Subtraction (int First, int Second) 
        {
            return First - Second;
        }

        static int Multiplication (int First, int Second)
        {
            return First * Second;
        }

        static double Division (double First, double Second)
        {
            return First/Second;
        }

    }
}
