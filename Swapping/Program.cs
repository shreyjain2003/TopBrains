using System;
using System.Security.AccessControl;

namespace Swapping
{
    /// <summary>
    /// Swapping two numbers using ref and out keywords
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Swaps two integers using ref keyword
        /// </summary>
        /// <param name="a">First integer to swap</param>
        /// <param name="b">Second integer to swap</param>
        public static void SwapUsingRef(ref int a, ref int b)
        {
            a=a+b;
            b=a-b;
            a=a-b;
        }
        /// <summary>
        /// Swaps two integers using out keyword
        /// </summary>
        /// <param name="a">First integer to swap</param>
        /// <param name="b">Second integer to swap</param>
        /// <param name="x">First input integer</param>
        /// <param name="y">Second input integer</param>
        public static void SwapUsingOut(out int a, out int b, int x,int y)
        {
            a=y;
            b=x;
        }
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter first Number: ");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int y=int.Parse(Console.ReadLine());

            Console.WriteLine($"Before ref Swap: x={x}, y={y}");
            SwapUsingRef(ref x,ref y);
            Console.WriteLine($"After ref Swap: x={x}, y={y}");
             int a,b;
             SwapUsingOut(out a, out b,x,y);
             Console.WriteLine($"After Out Swap: x={a}, y={b}");
        
        }
    }
}