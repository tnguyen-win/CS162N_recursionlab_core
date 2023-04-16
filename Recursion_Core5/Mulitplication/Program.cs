using System;

namespace Mulitplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiply");
            for (int n = 1; n <= 10; n++)
                Console.WriteLine(String.Format("5 * {0,2} is {1,2}", n, multiply(5, n)));
            Console.WriteLine();

            Console.WriteLine("Now for some real fun!");
            Console.WriteLine(String.Format("5 * {0,2} is {1,2}", 0, multiply(5, 0)));

        }

        // 3 * 1 = 3
        // 3 * 2 = 3 + 3
        // 3 * 3 = 3 + (3 + 3) or 3 + 3 *2
        static int multiply(int x, int y)
        {
            // every recursive function has a base case - the condition that causes it to stop
            if (y == 1)
                return x;
            // when it's not the base case the function calls itself with a parameter value that approaches the base case
            else
                return x + multiply(x, y - 1);
        }
    }
}
