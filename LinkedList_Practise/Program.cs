namespace LinkedList_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>(); // Он нужен для того чтобы разгрузить память

            list.AddLast("Hola Amigo");
            list.AddLast("1");
            list.AddLast("2");
            list.AddLast("3");
            list.AddLast("3");
            list.AddLast("4");
            list.AddLast("5");
            list.AddFirst("666");

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            LinkedListNode<string> firstElement = list.First;

            Console.WriteLine(firstElement.Value);
            LinkedListNode<string> secondElement = firstElement.Next;
            Console.WriteLine(secondElement.Value);
            LinkedListNode<string> thirdElement = secondElement.Next;
            Console.WriteLine(thirdElement.Value);
            LinkedListNode<string> fourthElement = thirdElement.Next;
            Console.WriteLine(fourthElement.Value);
        }
    }
}
