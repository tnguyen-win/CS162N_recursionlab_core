/*
 * The teacher provided example algorithm: https://tutorialspoint.com/data_structures_algorithms/tower_of_hanoi.htm
 * The example algorithm I used instead: https://geeksforgeeks.org/c-program-for-tower-of-hanoi
 */

using System;

namespace TowerOfHanoi {
	class Program {

		static void Hanoi(int numDisks, string source, string dest, string aux) {
			if (numDisks == 0) return;

			Hanoi(numDisks - 1, source, aux, dest);

			Console.WriteLine($"Moved disk [{numDisks}] from tower [{source}] to tower [{dest}]");

			Hanoi(numDisks - 1, aux, dest, source);
		}

		static void Main() {
			int numDisks;

			Console.Write("Enter a positive number: ");

			try {
				numDisks = int.Parse(Console.ReadLine());

				Console.WriteLine("\n");

				if (numDisks == 0) Console.WriteLine("You did not enter a number above zero. Try again.");
				else if (numDisks < 0) Console.WriteLine("You did not enter a positive number. Try again.");
			}
			catch {
				Console.WriteLine("\n\nYou did not enter a positive number. Try again.\n");

				return;
			}

			if (numDisks >= 0) Hanoi(numDisks, "A", "C", "B");

			Console.WriteLine("");
		}
	}
}