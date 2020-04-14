using System;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder("1a!2.3!!.. 4.!.?6 7! ..?");
            int count = 0;

            int temp = text.ToString().IndexOf('?');
            int tempo = text.ToString().LastIndexOf('?');

            for (int i = temp + 1; i < tempo; i++)
            {
                if (char.IsWhiteSpace(text[i]))
                    text[i] = '_';
            }

            for (int i = 0; i < temp - count;)
            {
                if (text[i] == '!' || text[i] == '.')
                {
                    text.Remove(i, 1);
                    count++;
                }
                else
                    i++;
            }
            Console.WriteLine(text);
        }
    }
}
