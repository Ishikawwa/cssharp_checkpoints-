namespace OOP_KT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver driver1 = new Driver(100, 3560);

            driver1.Drive(100);
            driver1.PrintLocation();
            driver1.PrintCarTechnicalState();


        }
    }
}
