namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Vasya", 15, 160.5, 66.6);

            human1.Name = "Vasya";
            human1.Age = 15;
            human1.Height = 150.5;
            human1.Weight = 60.5;

            //PrintHumanData(human1 --> function writen here
            human1.PrintAbout();  // --> function in Human.cs
        }

        public static void PrintHumanData (Human human)
        {
            Console.WriteLine($"Человек с именем {human.Name} возраста {human.Age}");

        }
    }
}
