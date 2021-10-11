using System;

public class Class1
{
	class Program1()
	{
		static void Main(string[] args)
	    {
		int x1 = Convert.ToInt32(Console.ReadLine());
		int x2 = Convert.ToInt32(Console.ReadLine());
		int y1 = Convert.ToInt32(Console.ReadLine());
		int y2 = Convert.ToInt32(Console.ReadLine());
		if (x1 == y1 || y2 == x2)
			Console.WriteLine("YES");
		else
			Console.WriteLine("NO");
	}
	}
}
