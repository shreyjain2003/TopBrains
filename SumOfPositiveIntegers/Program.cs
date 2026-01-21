using System;

namespace SumOfPositiveIntegers
{
    public class Program
    {
        public static int SumNumbers(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    continue;
                }
                else if (arr[i] == 0)
                {
                    break;
                }
                else
                {
                    sum += arr[i];
                }
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter number of elements in the array: ");
            int numOfElements = int.Parse(Console.ReadLine());

            int[] arr = new int[numOfElements];

            for (int i = 0; i < numOfElements; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int result = SumNumbers(arr);
            Console.WriteLine("Sum of Positive Integers: " + result);
        }
    }
}