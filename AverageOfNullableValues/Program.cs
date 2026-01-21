using System;

namespace AverageOfNullableValues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double?[] values={10.125,null,20.555,30.1,null};
            double? result=ComputeAverage(values);
            Console.WriteLine(result.HasValue ? result.Value.ToString() : "null");
        }
        public static double? ComputeAverage(double?[] values)
        {
            if(values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            double sum=0.0;
            int count=0;

            foreach(double? value in values)
            {
                if(value.HasValue)
                {
                    sum+=value.Value;
                    count++;
                }            
            }
            if (count == 0)
            {
                return null;
            }
            double average=sum/count;
            return Math.Round(average,2,MidpointRounding.AwayFromZero);
        }
    }
}