using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercices
{
    public class NumberSequence
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int maxSequence = FindValue(input);
            Console.WriteLine(maxSequence);
        }

        public static int FindValue(string number)
        {
            char[] arraySplit = number.ToArray();
            List<(int Number, int Count)> arrayNumbers = arraySplit.Select((n) => (Number: int.Parse(n.ToString()), Count: arraySplit.Where(x => n == x).Count())).ToList();
            int maxCount = arrayNumbers.Max(x => x.Count);
            (int Number, int Count) = arrayNumbers.Where(x => x.Count == maxCount).First();
            return Number;
        }
    }
}