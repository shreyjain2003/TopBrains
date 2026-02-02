using System;

namespace ConversionApp
{
    public class Program
    {
        public static void FeetToCentimeters(int feet)
        {
            double centimeter=feet * 30.48;
            Console.WriteLine("In cm: "+Math.Round(centimeter,2, MidpointRounding.AwayFromZero)+ " cm");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter length in feet: ");
            int feet=int.Parse(Console.ReadLine());
            FeetToCentimeters(feet);
        }
    }
}