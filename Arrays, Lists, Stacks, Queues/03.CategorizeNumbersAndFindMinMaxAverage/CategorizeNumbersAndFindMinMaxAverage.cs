namespace _03.CategorizeNumbersAndFindMinMaxAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class CategorizeNumbersAndFindMinMaxAverage
    {
        private static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            double[] array = arr.Select(double.Parse).ToArray();
            List<double> intNums = new List<double>();
            List<double> doubleNums = new List<double>();
            foreach (double item in array)
            {
                if (item % 1 == 0)
                {
                    intNums.Add(item);
                }
                else
                {
                    doubleNums.Add(item);
                }
            }
            intNums.ForEach(a => Console.Write(a + ", "));
            Console.WriteLine();
            Console.WriteLine("min: {0}", intNums.Min());
            Console.WriteLine("max: {0}", intNums.Max());
            Console.WriteLine("sum: {0}", intNums.Sum());
            Console.WriteLine("avg: {0:0.00}", intNums.Average());
            doubleNums.ForEach(a => Console.Write(a + ", "));
            Console.WriteLine();
            Console.WriteLine("min: {0}", doubleNums.Min());
            Console.WriteLine("max: {0}", doubleNums.Max());
            Console.WriteLine("sum: {0}", doubleNums.Sum());
            Console.WriteLine("avg: {0:0.00}", doubleNums.Average());
        }
    }
}

