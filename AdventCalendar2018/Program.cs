using System;

namespace AdventCalendar2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day one Challenge one");
            Console.WriteLine($"Result: {DayOne.ExecuteChallengeOne()}");
            Console.WriteLine();

            Console.WriteLine("Day one Challenge two");
            Console.WriteLine($"Result: {DayOne.ExecuteChallengeTwo()}");
            Console.WriteLine();

            Console.WriteLine("Day two Challenge one");
            Console.WriteLine($"Result: {DayTwo.ExecuteChallengeOne()}");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
