using System;

namespace its_just_start
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            if (x != y && z != y)
                Console.WriteLine("0");
            else if (x == y && y == z)
                Console.WriteLine("3");
            else
                Console.WriteLine("2");
        }
    }
}
