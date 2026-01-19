using System;

namespace Programming
{
    /// <summary>
    /// This class contains methods to find and count "Lucky Numbers" within a given range.
    /// </summary>
    class Programming
    {
        /// <summary>
        /// Calculates the sum of the digits of a given number.
        /// </summary>
        /// <param name="num">The number whose digits will be summed.</param>
        /// <returns>The sum of the digits of the given number.</returns>
        public static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        /// <summary>
        /// Determines if a number is prime.
        /// </summary>
        /// <param name="num">The number to check for primality.</param>
        /// <returns>True if the number is prime; otherwise, false.</returns>
        public static bool isPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the starting number (m):");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the ending number (n):");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = m; i <= n; i++)
            {
                if (isPrime(i))
                    continue;

                int s1 = SumOfDigits(i);
                int s2 = SumOfDigits(i * i);

                if (s2 == s1 * s1)
                {
                    Console.WriteLine(i+" ");
                    count++;
                }
            }
            Console.WriteLine("Total Lucky Numbers = " + count);
        }
    }
}
