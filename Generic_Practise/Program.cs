namespace Generic_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {


            SimpleList<int> list = new SimpleList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            Console.WriteLine("First call:" + list.Get(4));
            list.RemoveBy(2);
            Console.WriteLine("Second call:" + list.Get(4));


            for (int i = 0; i < list.Count(); i++)
            {
                //Console.WriteLine(list.Get(i));
                Console.WriteLine(list[i]);
            }



            /*
            MyName<int> myObj = new MyName<int>();
            myObj.MyProperty = 10;
            myObj.MyFunc();
            MyName<bool>mySecObj = new MyName<bool>();
            mySecObj.MyProperty = true;
            mySecObj.MyFunc();
            */


            //Print(15.6);
            //Print("Hello!");
            //Print(1 < 3);
            //Print(1+4);
            //Print(64325342534 + "Privet");
            //List<int> list = new List<int>();

            //for (int i = 0; i <= 10; i++)
            //{
            //    list.Add(i);

            //    Console.WriteLine(list[i]);
            //}
        }
        //public static void Print<T>(T value)
        //{
            //Console.WriteLine(value.ToString());
        //}

        
    }
}
  /*  public class MyName<T>
    {
        public T MyProperty; //Это свойство 
        public T MyFunc()  
        {
           Console.WriteLine(MyProperty);
            return MyProperty;  
        }

    }
  */
