using System;

namespace TriangularNumbers {
	class Program {
		static void Main() {
			for (int n = 1; n <= 10; n++) Console.WriteLine($"[{n}] - {recursion(n)}");
		}

		static int recursion(int n) {
			if (n == 1) return 1;
			else return n + recursion(n - 1);
		}
	}
}