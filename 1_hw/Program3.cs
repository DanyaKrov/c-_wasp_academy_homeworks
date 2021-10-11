using System;

namespace its_just_start
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine()); int y = Convert.ToInt32(Console.ReadLine());
            int dist1 = Convert.ToInt32(Console.ReadLine()); int dist2 = Convert.ToInt32(Console.ReadLine());
            int dist3 = x - dist1; int dist4 = y - dist2;
            if (dist1 <= dist2 || dist1 <= dist3 || dist1 <= dist4)
                Console.WriteLine(dist1);
            else if (dist2 <= dist1 || dist2 <= dist3 || dist2 <= dist4)
                Console.WriteLine(dist2);
            else if (dist3 <= dist1 || dist3 <= dist2 || dist3 <= dist4)
                Console.WriteLine(dist3);
            else
                Console.WriteLine(dist4);
        }
    }
}
