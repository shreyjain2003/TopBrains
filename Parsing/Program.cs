using System;

namespace Parsing
{
    public class Program
    {
        public static int ParseInput(string[] input)
        {
            int sum=0;
            for(int i=0;i<input.Length;i++)
            {
                if(int.TryParse(input[i], out int result))
                {
                    //Console.WriteLine("Parsed Integer: "+result);
                    sum+=result;
                }
                else
                {
                    continue;
                }
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number of inputs: ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the inputs (one per line): ");
            string[] inputs=new string[n];
            for(int i=0;i<n;i++)
            {
                inputs[i]=Console.ReadLine();
            }
            int result=ParseInput(inputs);
            Console.WriteLine("Total sum: "+result);
        }
    }
}