namespace Breaking_Functions_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func(14, 16);
            Func(14.6, 15.4);
            Func(15, 15);

        }
         static void Func(int Num1, int Num2)
         {
             Console.WriteLine(Num1 + Num2);
         }
         static void Func(double Num1, double Num2)
         {
             Console.WriteLine(Num1 + Num2);
         }
         static void Func(float Num1, float Num2)
         {
             Console.WriteLine(Num1 + Num2); 
         }


        // Все что выше это перегрузка функции 
    }
}
