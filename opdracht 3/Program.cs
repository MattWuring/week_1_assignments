using System;
using System.Collections.Generic;

namespace opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 3);

            var Numbers = new List<int>() { 3, 9, 2, 4 };
            Numbers.RemoveAt(random);
            Numbers.Sort();

            foreach(var thing in Numbers)
            {
                Console.WriteLine(thing);
            }

        }
    }
}
