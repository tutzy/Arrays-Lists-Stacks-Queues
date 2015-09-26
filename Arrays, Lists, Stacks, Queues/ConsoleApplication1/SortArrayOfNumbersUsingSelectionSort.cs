namespace ConsoleApplication1
{
    using System;
    using System.Linq;

    internal class SortArrayOfNumbersUsingSelectionSort
    {
        private static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int[] arrToInt = arr.Select(int.Parse).ToArray();
            for (int i = 0; i < arrToInt.Length; i++)
            {
                for (int j = 0; j < arrToInt.Length - 1; j++)
                {
                    if (arrToInt[j] > arrToInt[j + 1])
                    {
                        var num = arrToInt[j];
                        arrToInt[j] = arrToInt[j + 1];
                        arrToInt[j + 1] = num;
                    }
                }
            }
            Console.Write(string.Join(" ", arrToInt));
            Console.WriteLine();
        }
    }
}
