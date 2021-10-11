using System;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
			int x = Convert.ToInt32(Console.ReadLine());
			int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x * y % 109);
		}
    }
}
