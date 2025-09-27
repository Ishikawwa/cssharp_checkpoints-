namespace Dictionary_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> stat = new SortedDictionary<int, int>(); 

            Console.WriteLine("Enter your number/numbers. To end the task please enter [-1]");
            while (true)
            {
                int userInput = int.Parse(Console.ReadLine());

                if (userInput == -1)
                {
                    Console.WriteLine("Cya");
                    break;
                }


                if (stat.ContainsKey(userInput))
                {
                    stat[userInput]++;
                }
                else
                {
                    stat.Add(userInput, 1);
                }
            }

            foreach (KeyValuePair<int, int> statValue in stat) //<int, int> потому что сам Dictionary <int, int>
            {
                Console.WriteLine($"Number {statValue.Key} was writen {statValue.Value} times");
            }
                
        }
    }
}
