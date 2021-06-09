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
            //MyList.Add("John");
            //MyList.Add("Jacob");

            foreach (string jostar in MyList)
            {
                Console.WriteLine(jostar);
            }

            Console.WriteLine("The count: " + MyList.Count);
            Console.WriteLine("Capacity thingy (for MyList!): " + MyList.Capacity);

            Console.WriteLine("Trimming...");
            MyList.TrimExcess();
            Console.WriteLine("The count: " + MyList.Count);
            Console.WriteLine("Capacity thingy (for MyList!): " + MyList.Capacity);
            Console.WriteLine();


        }
    }
}
