using System;

namespace FibonacciNumbers {
	class Program {
		static void Main() {
			for (int n = 0; n < 10; n++) Console.WriteLine($"[{n}] - {recursion(n)}");
		}

		static int recursion(int n) {
			if (n > 1) return recursion(n - 1) + recursion(n - 2);
			else return n;
		}
	}
}