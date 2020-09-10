using System;
using System.Globalization;

namespace Exercices
{
    public class TransformMoney
    {
        private static readonly float COTATION = 5.36f;
        private static void Main()
        {
            string dollar = Console.ReadLine();
            double converted = ConvertMoney(dollar);
            Console.WriteLine(converted.ToString("F"));
        }

        public static double ConvertMoney(string value)
        {
            float dollar = float.Parse(value, CultureInfo.InvariantCulture.NumberFormat);
            double real = Math.Round(dollar * COTATION, 2);
            return real;
        }
    }
}