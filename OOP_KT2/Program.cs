namespace OOP_KT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Lotto lottoGame = new Lotto();
                Console.WriteLine($"Game {i}");

                for (int j = 0; j < 50; j++)
                {
                    int number = lottoGame.GetNumber();
                    Console.WriteLine($"Game {i}, try {i + 1}: {number}");
                }
            }

            Console.WriteLine("Game 6 (110 tries)");
            Lotto lottoGame6 = new Lotto();
            for (int i = 0; i < 110; i++)
            {
                int number = lottoGame6.GetNumber();
                if (number == -1)
                {
                    Console.WriteLine($"Try {i + 1}: No numbers left!");
                }
                else
                {
                    Console.WriteLine($"Try {i + 1}: {number}");
                }
            }

            Console.WriteLine("Statistics");
            Lotto.PrintGamesStat();
        }
    }
}
