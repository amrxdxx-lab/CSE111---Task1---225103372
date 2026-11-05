using System;

namespace Cse111Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentList list = new StudentList();

            list.AddFront(20);
            Console.Write("Step 1: ");
            list.Print();

            list.AddFront(10);
            Console.Write("Step 2: ");
            list.Print();

            list.AddEnd(30);
            Console.Write("Step 3: ");
            list.Print();

            list.AddEnd(40);
            Console.Write("Step 4: ");
            list.Print();

            list.Reverse();
            Console.Write("Step 5: ");
            list.Print();

            list.Remove(20);
            Console.Write("Step 6: ");
            list.Print();
        }
    }
}