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
            string[] mas = Console.ReadLine().Split(" ");
            int n = int.Parse(mas[0]), k = int.Parse(mas[1]);
            int[] ans = new int[n];
            for (int i = 0; i < k; i++)
            {
                string[] mas1 = Console.ReadLine().Split(" ");
                int x = int.Parse(mas1[0]), y = int.Parse(mas1[1]);
                while (x <= y)
                {
                    ans[x - 1] = 1;
                    x++;
                }
            }
            foreach(int j in ans)
            {
                if (j == 0)
                    Console.Write("I");
                else
                    Console.Write(".");
            }
        }
    }
}