using System;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
			int x1 = Convert.ToInt32(Console.ReadLine());
			int x2 = Convert.ToInt32(Console.ReadLine());
			int y1 = Convert.ToInt32(Console.ReadLine());
			int y2 = Convert.ToInt32(Console.ReadLine());
			if (x1 - y1 == -1 && x2 == y2)
				Console.WriteLine("YES");
			else if (x1 - y1 == 1 && x2 == y2)
				Console.WriteLine("YES");
			else if (x2 - y2 == -1 && x1 == y1)
				Console.WriteLine("YES");
			else if (x2 - y2 == 1 && x1 == y1)
				Console.WriteLine("YES");
			else if ((x1 - y1) * (x2 - y2) == 1)
				Console.WriteLine("YES");
			else if ((x1 - y1) * (x2 - y2) == -1)
				Console.WriteLine("YES");
			else
				Console.WriteLine("NO");
		}
    }
}
