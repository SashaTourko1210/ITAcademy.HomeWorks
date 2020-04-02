using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar1 = new int[5];
            for (int i = 0; i < ar1.Length - 1; i++)
            {   
                ar1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", ar1));

            Console.WriteLine("Какое число вставляем элемент:");

            int pos = int.Parse(Console.ReadLine());

            Console.WriteLine("На какую позицию вставляем элемент:");

            int val = int.Parse(Console.ReadLine());

            for (int i = ar1.Length-1; i > pos ; i--)
            {
                ar1[i] = ar1[i - 1];
            }
           
           ar1[pos] = val;
   
            Console.WriteLine(string.Join(" ", ar1));
        }
    }
}
