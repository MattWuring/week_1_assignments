﻿using System;
using System.Collections.Generic;

namespace opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            for (int i = 4; i < numbers.Count;)
            {
                numbers.RemoveAt(i);
            }

            numbers.Sort();
            numbers.Reverse();

            foreach(var thing in numbers)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
