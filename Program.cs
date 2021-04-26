using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList List = new LinkedList();

            //Console.WriteLine("Is it empty? - " + List.Empty);
            //Console.WriteLine("Count - " + List.Count);
            //Console.ReadLine();

            //List.Add(1);
            //List.Add(2);
            //List.Add(1, 3);
            //
            //List.Remove(1);
            //
            //List.Clear();

            List.Add("Hello");
            List.Add("Test1");
            List.Add("Test2");
            List.Add("Test3");

            bool contains = List.Contains("Test");
            int index = List.IndexOf("Hello");
            List.Contains("Hello");

            object test = List.Get(2);

            object test2 = List[1];
        }
    }
}
