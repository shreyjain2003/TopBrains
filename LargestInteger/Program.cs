using System;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LargestInteger
{
    /// <summary>
    /// This program finds the largest of three integers.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Finds the largest of three integers.
        /// </summary>
        /// <param name="a">The first integer.</param>
        /// <param name="b">The second integer.</param>
        /// <param name="c">The third integer.</param>
        /// <returns>The largest of the three integers.</returns>
        public static int Largest(int a, int b, int c)
        {
            if(a>= b && a>=c)
            {
                return a;
            }
            else if(b>=a && b>=c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("Enter Three Integers: ");
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            c=int.Parse(Console.ReadLine());
            int largest=Largest(a,b,c);
            Console.WriteLine("The Largest Interger is: "+largest);
            
        }

    }
}