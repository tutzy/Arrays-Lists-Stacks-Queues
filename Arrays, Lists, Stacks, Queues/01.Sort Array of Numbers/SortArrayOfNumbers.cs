namespace _01.Sort_Array_of_Numbers
{
    using System;
    using System.Linq;

    internal class SortArrayOfNumbers
    {
        private static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int[] stringToInt = numbers.Select(int.Parse).ToArray();
            Array.Sort(stringToInt);
            Console.WriteLine(string.Join(" ", stringToInt));
        }
    }
}
