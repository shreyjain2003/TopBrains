using System;

namespace Multiplication_Table
{
    /// <summary>
    /// This program generates a multiplication table row for a given number up to a specified range.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Generates a multiplication table row for the given number up to the specified range.
        /// </summary>
        /// <param name="n">The number for which the multiplication table row is generated.</param>
        /// <param name="upto">The range up to which the multiplication table row is generated.</param>
        /// <returns>An array containing the multiplication table row for the given number.</returns>
        public static int[] GetMultiplicationRow(int n, int upto)
        {
            if(upto<=0)
            {
                return Array.Empty<int>();
            }

            int[] result=new int[upto];

            for(int i=1;i<=upto;i++)
            {
                result[i-1]=n*i;
            }
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number (n): ");
            int n=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the range (upto): ");
            int upto=int.Parse(Console.ReadLine());

            int[] tableRow=GetMultiplicationRow(n,upto);
            Console.WriteLine("Multiplication Table Row:");
            Console.WriteLine("["+string.Join(", ",tableRow)+"]");
        }
    }
}