using System;
using System.Collections.Generic;

namespace opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nummers = new List<int>() { 1, 2, 3, 4, 5 };
            var nummers2 = new List<int>() { 6, 7, 8 };

            nummers2.AddRange(nummers);

            foreach(var thing in nummers2)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
