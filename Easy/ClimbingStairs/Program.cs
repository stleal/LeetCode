using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");
		// Example: Uncomment to test
		Console.WriteLine(ClimbStairs(5)); // expected 8
	}

	public static int ClimbStairs(int n)
	{
		if (n <= 2) return n;
		int a = 1;
		int b = 2;
		for (int i = 3; i <= n; i++)
		{
			int next = a + b;
			a = b;
			b = next;
		}
		return b;
	}
}
