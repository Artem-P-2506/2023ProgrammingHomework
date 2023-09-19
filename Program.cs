using System;

namespace C__2023__КН_22_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t'()[]{}' Accordance V1");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Enter a string: ");
            int ErrorPosition = 0;
            bool result = BracketChecker.CheckAccordance(Console.ReadLine(), out ErrorPosition);
            if (result)
            {
                Console.WriteLine("The string is right!");
            }
            else
            {
                Console.Write("The string is wrong! ");
                if (ErrorPosition != 0)
                {
                    Console.WriteLine($"The eroor position is - {ErrorPosition}");
                }
            }
            Console.ReadLine();
        }
    }
}