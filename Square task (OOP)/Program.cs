using System.Drawing;

namespace Square_task__OOP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(17.5, 18.2);
            square1.WidthScaling();
            square1.HeightScaling();

            Console.WriteLine($"Rectangle width : {square1.Width}\nRectangle Height : {square1.Height}\nand Rectangle's area is : {square1.CountingArea()}");
        }
        /*
            Rectangle width : 17,5       -----> Эти значения были по дефолту до увеличения
            Rectangle Height : 18,2         -----> Эти значения были по дефолту до увеличения
            and Rectangle's area is : 318,5         -----> Эти значения были по дефолту до увеличения
        */
    }
}
