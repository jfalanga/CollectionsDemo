using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> MyList = new List<string>();
            MyList.Add("John");
            MyList.Add("Jacob");
            MyList.Add("Jingle");
            MyList.Add("Himer");
            MyList.Add("Schmitt");
            MyList.Add("John");

            ForList(MyList);
            DisplayList(MyList);

            Console.WriteLine("Trimming...");
            MyList.TrimExcess();
            DisplayList(MyList);
            Console.WriteLine();

            Console.WriteLine("Removing entry 2 or 3...");
            MyList.RemoveAt(2);
            ForList(MyList);
            Console.WriteLine();

            Console.WriteLine("Removing all John entries...");
            MyList.Remove("John");
            ForList(MyList);
        }

        private static void DisplayList(List<string> MyList)
        {
            Console.WriteLine("The count: " + MyList.Count);
            Console.WriteLine("Capacity thingy (for MyList!): " + MyList.Capacity);
        }

        private static void ForList(List<string> MyList)
        {
            foreach (string jostar in MyList)
            {
                Console.WriteLine(jostar);
            }
        }
    }
}
