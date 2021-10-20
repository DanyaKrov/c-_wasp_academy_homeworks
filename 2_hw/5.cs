using System;
using System.Collections.Generic;

namespace app1
{
    class Program //улитка
    {
        static void Main(string[] args)
        {
            int h = Convert.ToInt32(Console.ReadLine()), a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine()), ans = 0;
            do
            {
                h += b - a; ans++;
            } while (h - a >= 0);
            Console.WriteLine(ans);
        }
    }
}