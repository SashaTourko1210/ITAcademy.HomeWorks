using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar1 = new int[5];
            int[] ar2 = new int[5];
            int[] ar3 = new int[5];

            Random rnd = new Random();

            for (int i = 0; i < ar1.Length; i++)
            {
                ar1[i] = rnd.Next(101);
                ar2[i] = int.Parse(Console.ReadLine());
                ar3[i] = ar1[i] + ar2[i];
            }
            
            Console.WriteLine(string.Join(" ", ar1));
            Console.WriteLine(string.Join(" ", ar2));
            Console.WriteLine(string.Join(" ", ar3));
        }
    }
}
