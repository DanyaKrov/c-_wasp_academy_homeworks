using System;

namespace app1
{
    class Program
    {
        static void Main(string[] args) //мкад
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
                Console.WriteLine(x * y % 109);
            else
                Console.WriteLine(Math.Abs((109 - x * -1 * y) % 109));
        }
    }
}
