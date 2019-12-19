using System;
using NTW.Models;

namespace NTW
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter an integer:");
            long userInput;
            bool success = Int64.TryParse(Console.ReadLine(), out userInput);
            if (success)
            {
                Console.WriteLine(Number.NumberToWord(userInput));
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}