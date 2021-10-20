using System;

namespace its_just_start
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine()), y = Convert.ToInt32(Console.ReadLine());
            int dist1 = Convert.ToInt32(Console.ReadLine()), dist2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Min(Math.Min(x - dist1, dist1), Math.Min(y - dist2, dist2)));
        }
    }
}
