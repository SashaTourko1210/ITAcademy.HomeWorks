using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Никогда не любите того кто относится к вам будто вы обычный";

            Delete(text);

            Change(text);

            Count();

            Sort(text);

            Console.ReadKey();
        }

        static void Delete(string text)
        {
            string[] str = text.Split(' ');
            string str2 = "";

            int max = str[0].Length;
            int temp = 0;

            for (int i = 0; i < str.Length; i++)
                if (max < str[i].Length)
                {
                    max = str[i].Length;
                    temp = i;
                }

            for (int i = 0; i < str.Length; i++)
                if (i != temp)
                    str2 += str[i] + " ";

            Console.WriteLine(str2);
        }

        static void Change(string text)
        {
            string[] str = text.Split(' ');

            int max = str[0].Length;
            int min = str[0].Length;
            int temp = 0;
            int tempo = 0;
            string str2 = "";

            for (int i = 0; i < str.Length; i++)
                if (max < str[i].Length)
                {
                    max = str[i].Length;
                    temp = i;
                }

            for (int j = 0; j < str.Length; j++)
                if (min > str[j].Length)
                {
                    min = str[j].Length;
                    tempo = j;
                }

            var mas = str[temp];
            str[temp] = str[tempo];
            str[tempo] = mas;

            for (int i = 0; i < str.Length; i++)
                str2 += str[i] + " ";

            Console.WriteLine(str2);
        }

        static void Count()
        {
            string text = "Никогда не любите того кто относится к вам будто вы обычный";
            int count = 0;
            string[] str = text.Split(' ');
            string newstr = String.Join("", str);
            char[] arr;
            arr = newstr.ToCharArray();

            while (count < arr.Length)
                count++;

            Console.WriteLine(count);
        }

        static void Sort(string text)
        {
            string[] mas = text.Split(' ');
            string temp;
            string str2 = "";

            for (int i = 0; i < mas.Length; i++)
                for (int j = mas.Length - 1; j > i; j--)
                    if (mas[j - 1].Length < mas[j].Length)
                    {
                        temp = mas[j - 1];
                        mas[j - 1] = mas[j];
                        mas[j] = temp;
                    }
            
            for (int i = 0; i < mas.Length; i++)
                str2 += mas[i] + " ";

            Console.WriteLine(str2);
        }
    }
}
