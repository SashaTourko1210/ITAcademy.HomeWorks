using System;
using System.Diagnostics;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] ar1 = new long[100000000];

            Random rnd = new Random();

            for (int i = 0; i < ar1.Length; i++)
            {
                ar1[i] = rnd.Next(101);
            }

           // Console.WriteLine(string.Join(" ", ar1));

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0, j = ar1.Length - 1; i < j; i++, j--)
            {
                long t = ar1[i];
                ar1[i] = ar1[j];
                ar1[j] = t;
            }
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine(ts);
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            Array.Reverse(ar1);
            sw2.Stop();
            long ts2 = sw2.ElapsedMilliseconds;
            Console.WriteLine(ts2);
           // Console.WriteLine(string.Join(" ", ar1));

        }
    }
}