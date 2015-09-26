namespace _04.SequencesOfEqualStrings
{
    using System;
    using System.Linq;

    internal class SequencesOfEqualStrings
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var groups = input.GroupBy(name => name);
            foreach (var word in groups)
            {
                Console.WriteLine(string.Join(" ", word));
            }
            Console.WriteLine();
        }
    }
}

