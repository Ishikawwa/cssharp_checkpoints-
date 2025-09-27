namespace OOP_KT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", "Williams", "4.2", "11a");
            Student student2 = new Student("Victor", "Jefry", "3", "6a");
            Student student3 = new Student("Ryan", "Mikes", "5", "7a");
            Student student4 = new Student("Jonny", "Myles", "3.2", "4a");
            Student student5 = new Student("Alex", "Cake", "2.2", "6a");
            Student student6 = new Student("Donald", "Trump", "4.7", "9a");
            Student student7 = new Student("Joe", "Biden", "3.1", "10a");
            Student student8 = new Student("Dony", "Tape", "3.3", "11a");
            Student student9 = new Student("Bob", "Richards", "3.7", "3a");
            Student student10 = new Student("Kate", "Bide", "4.5", "8a");
            Student student11 = new Student("Alex", "Michaels", "4.9", "6a");

            
            School school = new School();

            school.EnrollStudent(student1);
            school.EnrollStudent(student2);
            school.EnrollStudent(student3);
            school.EnrollStudent(student4);
            school.EnrollStudent(student5);
            school.EnrollStudent(student6);
            school.EnrollStudent(student7);
            school.EnrollStudent(student8);
            school.EnrollStudent(student9);
            school.EnrollStudent(student10);
            school.EnrollStudent(student11);

            student1.PrintInfo();
            student2.PrintInfo();
            student3.PrintInfo();
            student4.PrintInfo();
            student5.PrintInfo();
            student6.PrintInfo();
            student7.PrintInfo();
            student8.PrintInfo();
            student9.PrintInfo();
            student10.PrintInfo();
            student11.PrintInfo();


        }
    }
}
