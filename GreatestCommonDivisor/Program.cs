using System;

namespace GreatestCommonDivisor
{
class Program
{
    /// <summary>
    /// Computes the Greatest Common Divisor (GCD) using recursion
    /// </summary>
    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;

        return GCD(b, a % b);
    }

    static void Main()
    {
        int a = 48;
        int b = 18;

        int result = GCD(a, b);
        Console.WriteLine("GCD: " + result);
    }
}
}