using System;
using System.Collections.Generic;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n % 100 / 10);
        }
    }
}