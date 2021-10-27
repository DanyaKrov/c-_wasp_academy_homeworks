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
            int number = int.Parse(Console.ReadLine()), kol;
            string str = Console.ReadLine();
            string[] mas = str.Split(" ");
            for (int i = 0; i < number; i++)
            {
                kol = 0;
                for (int j = 0; j < number; j++)
                {
                    if (mas[i] == mas[j])
                        kol++;
                }
                if (kol == 1)
                    Console.Write($"{mas[i]} ");
            }
        }
    }
}