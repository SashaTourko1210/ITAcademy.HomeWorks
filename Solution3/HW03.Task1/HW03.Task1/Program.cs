using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1234.7;//явн
            int a;
            a = (int)x;

            short s = 45;//явн
            byte b = (byte)s;

            int y = 4;//явн
            int r = 6;
            byte c = (byte)(y + r);

            int num = 2147483647; //неяв
            long bigNum = num;

            byte aa = 15;//неявн
            byte bb = 120;
            int cc = aa + bb;

            byte bit = 5;//неявн
            short sht = bit;
            int ist = bit;
            long lit = bit;
            double dit = lit;

            int i = 123;
            object obj = i;
            ushort ch = (ushort)(int)obj;

            bool check = true;
            object h = check;
            bool ch2 = (bool)h;
            byte ch3 = Convert.ToByte(ch2);

            char m = 'm';
            object mn = m;
            int mn1 = (int)(char)mn;

        }
    }
}
