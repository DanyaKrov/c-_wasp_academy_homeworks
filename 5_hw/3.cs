using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace its_just_start
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), m = int.Parse(Console.ReadLine());
            int number = n;
            do
            {
                n *= number;
            } while (n < m);
            if (n == m)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
