namespace Static_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сам по себе статик это как метод который вызывать не надо
            // Статик это типо как код к которому мы можем обратиться не думая об ООП
            //MyClass myCl = new MyClass(); // По идее мы можем не создавать объект и тогда вызывать наприямую функцию ппутем Static

            //myCl.PrintHelloWorld(); // Работает без Static
            //MyClass.PrintHelloWorld(); // Работает со Static
            //MyMath.MathPow(5, 5);




            //int result1 = MyMath.MathAbs(-5);
            //int result2 = MyMath.MathAbs(-44);
            //int result3 = MyMath.MathAbs(-77);
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //int resultPow1 = MyMath.MathPow(2, 3);
            //Console.WriteLine(resultPow1);

            //Example.PrintCounter();
            //Example.PrintCounter();
            //Example.PrintCounter();
            //Example.PrintCounter();
            //Example.PrintCounter();
            //Example.PrintCounter();


            CarFactory renaultFactory = new CarFactory("Renault");
            CarFactory kiaFactory = new CarFactory("Kia");


            Car redRenault = renaultFactory.ProduceCar("Red Renault");
            Car blueRenault = renaultFactory.ProduceCar("Blue Renault");
            Car greenRenault = renaultFactory.ProduceCar("Green Renault");
            Car yellowRenault = renaultFactory.ProduceCar("Yellow Renault");

            Car redKia = kiaFactory.ProduceCar("Red Kia");
            Car blueKia = kiaFactory.ProduceCar("Blue Kia");
            Car greenKia = kiaFactory.ProduceCar("Green Kia");

            renaultFactory.PrintFactoryStat();
            kiaFactory.PrintFactoryStat();
            CarFactory.PrintFactoriesStat();

        }

        // Пример:
        public class MyClass
        {
            // Допустим класс имеет метод :
            //public void PrintHelloWorld() // Работает без Static
            //{
            //    Console.WriteLine("Hello World!");
            //}
            //public static void PrintHelloWorld() // Работает со Static
            //{
            //    Console.WriteLine("Hello World!");
            //}
        }

        public class MyMath
        {
            public static int MathAbs(int userInput)
            {
                if (userInput < 0)
                {
                    return userInput = -userInput;
                }
                else
                {
                    return userInput;
                }
            }

            public static int MathPow(int number, int multiplier)
            {
                int answer = 1;
                for (int i = 0; i < multiplier; i++)
                {
                    answer *= number;
                }
                return answer;
            }

        }
            public static class Example
            {
                private static int _myCounter = 0; //Всегда когда работаем со Static все поля АБСОЛЮТНО ВСЕ должно быть также STATIC
                public static void PrintCounter()
                {
                    _myCounter++;

                    Console.WriteLine(_myCounter);
                }
            }


        public class Car
        {
            public string Color;

            public string NameTag;
            public Car(string color, string nameTag)
            {
                Color = color;
                NameTag = nameTag;
            }
        }
        public class CarFactory
        {
            private readonly string _nameTag;
            private int produceCount = 0; // Сколько произвела конкретная фабрика
            private static int allFactoryProduceCount = 0; // Сколько ВСЕГО (со всех фабрик)

            //static CarFactory() // Также существует статический конструктор, и каждый раз при вызове какой либо ф-ии сначала вызывется конструктор статический
            //{
            //    Console.WriteLine("STATIC CONSTRUCTOR");
            //}

            public CarFactory(string nameTag)
            {
                _nameTag = nameTag;
            }
            public Car ProduceCar(string color)
            {
                Car car = new Car(color, _nameTag);
                produceCount++;
                allFactoryProduceCount++;
                return car;
            }

            public void PrintFactoryStat()
            {
                Console.WriteLine($"Car {_nameTag} made {produceCount}");
            }

            public static void PrintFactoriesStat()
            {
                Console.WriteLine($"Made from all factories {allFactoryProduceCount} cars");
            }
        }                                                                                                                 
    }
}
