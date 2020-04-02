using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string verse = Convert.ToString(Console.ReadLine());

            string[] versemas = verse.Split(';');

            for (int i = 0; i < versemas.Length; i++)
                Console.WriteLine(versemas[i].Replace("а", "о").Replace("А", "О"));
            Console.WriteLine();
        }
    }
}
