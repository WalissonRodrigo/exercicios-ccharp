using FastFood;
using System;

namespace Exercices
{
    public class FastFoodTerminal
    {
        private static void Main(string[] args)
        {
            string RequestString = Console.ReadLine();
            Request Request = Request.TranslateRequest(RequestString);
            Console.WriteLine(Request.TotalRequest());
        }

        
    }
}
