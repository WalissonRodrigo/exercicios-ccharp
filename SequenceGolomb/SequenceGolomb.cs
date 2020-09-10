using System;

namespace Exercices
{
    public class SequenceGolomb
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintGolomb(n);
        }
        // Return the nth element  
        // of Golomb sequence 
        private static int FindGolomb(int n)
        {
            // base case 
            if (n == 1)
                return 1;

            // Recursive Step 
            return 1 + FindGolomb(n - FindGolomb(FindGolomb(n - 1)));
        }

        // Print the first n term  of Golomb Sequence 
        static void PrintGolomb(int n)
        {
            Console.Write(GenerateGolomb(n));
        }

        public static string GenerateGolomb(int n)
        {
            string sequence = "";
            // Finding first n terms of  
            // Golomb Sequence. 
            for (int i = 1; i <= n; i++)
                sequence += FindGolomb(i) + (i < n ? ", " : "");
            return sequence;
        }
    }
}
