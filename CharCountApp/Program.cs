using System;

namespace CharCountApp
{
    public class Program
    {
        public static void CharCount(string input)
        {
            int count=0;
            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input string is null or empty!");
                return;
            }
            else
            {
                //string[] character=input.Split();
                
                for(int i=0;i<input.Length;i++)
                {
                    if(input[i].Equals(' '))
                    {
                        continue;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Character Count: "+count);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input=Console.ReadLine();
            CharCount(input);
        }
    }
}