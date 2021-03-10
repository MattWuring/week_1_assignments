using System;
using System.Collections.Generic;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {

            var Items = new List<string>() {"kaas", "banaan", "beenham", "ezel"};

            Console.WriteLine("enter an item down below");
            string choice = Console.ReadLine();

            Console.WriteLine("does this item exisct in the list? : " + Items.Contains(choice));

        }
    }
}
