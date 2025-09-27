namespace С__ItHub_practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 (Программа с оценками студентов)
            Console.WriteLine("Enter student grades from 0 to 100 inclusive. When you need to stop, enter -1");
            int GradeCounter = 0;
            int TotalGrades = 0;
            int BadGradeCounter = 0;
            int NormalGradeCounter = 0;
            int GoodGradeCounter = 0;
            int GreatGradeCounter = 0;
            int MinGrade = 100;
            int MaxGrade = 0;

            while (true)
            {
                int UsersGrade = int.Parse(Console.ReadLine());


                if (UsersGrade > 100 || UsersGrade < -1)
                {
                    Console.WriteLine("Attention! Incorrect rating entered, please enter grades from 0 - 100");
                    continue;   
                }
                else if (UsersGrade == -1)
                {
                    double AverageGrade = (double)TotalGrades / GradeCounter;
                    Console.WriteLine("Conclusion:");
                    Console.WriteLine($"Number of grades entered: {GradeCounter}");
                    Console.WriteLine($"Bad grades: {BadGradeCounter}"); // Можно добавить ({(double)BadGradeCounter/GradeCounter:P1}) - спросиол у гпт, будет вывод количества плохих оценок и в скобочках количество процентов
                    Console.WriteLine($"Normal grades: {NormalGradeCounter}");
                    Console.WriteLine($"Good grades: {GoodGradeCounter}");
                    Console.WriteLine($"Great grades: {GreatGradeCounter}");
                    Console.WriteLine($"Average grades:{AverageGrade:F2}"); // :F2 - спросил у гпт, это значит что вывод после запятой будет только 2 символа
                    Console.WriteLine($"Max grade: {MaxGrade}"); 
                    Console.WriteLine($"Min grade {MinGrade}");

                    break;
                }


                if (GradeCounter == 0)
                {
                    MaxGrade = UsersGrade;
                    MinGrade = UsersGrade;
                }
                else if (UsersGrade > MaxGrade) 
                {
                    MaxGrade = UsersGrade;
                }
                else if (UsersGrade < MinGrade)
                {
                    MinGrade = UsersGrade;
                }


                




                if (UsersGrade < 50)
                {
                    TotalGrades += UsersGrade;
                    BadGradeCounter++;
                    GradeCounter++;
                }
                else if (UsersGrade >= 50 && UsersGrade <= 69)
                {
                    TotalGrades += UsersGrade;
                    NormalGradeCounter++;
                    GradeCounter++;
                }
                else if (UsersGrade >= 70 && UsersGrade <= 89)
                {
                    TotalGrades += UsersGrade;
                    GoodGradeCounter++;
                    GradeCounter++;
                }
                else if (UsersGrade >= 90)
                {
                    TotalGrades += UsersGrade;
                    GreatGradeCounter++;
                    GradeCounter++;
                }
            }

        }
    }
}
