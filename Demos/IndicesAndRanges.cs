using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Console.Writeline;

namespace CSharp8Features.Demos
{
    public static class IndicesAndRanges
    {
        private static string[] words =
        {
                        // Index start  // Index end
            "The",      // 0            ^9
            "quick",    // 1            ^8
            "brown",    // 2            ^7
            "fox",      // 3            ^6
            "jumped",   // 4            ^5
            "over",     // 5            ^4
            "the",      // 6            ^3
            "lazy",     // 7            ^2
            "dog"       // 8            ^1
        };

        public static void Demo1()
        {
            Console.WriteLine(words[^1]);
        }

        public static void Demo2()
        {
            var lazyDog = words[^2..^0];
            PrintWords(lazyDog);
        }

        public static void Demo3()
        {
            var allWords = words[..]; // contains "the" through "dog"
            var firstPhrase = words[..4]; // contains "the" through "fox"
            var lastPhrase = words[6..]; // contains "the", "lazy", "dog"

            PrintWords(allWords);
            PrintWords(firstPhrase);
            PrintWords(lastPhrase);
        }

        public static void Demo4()
        {
            Index the = ^3;
            Console.WriteLine(words[the]);

            Range phrase = 1..4;
            PrintWords(words[phrase]);
        }

        public static void Demo5()
        {
            var numbers = Enumerable.Range(0, 100).ToArray();
            int x = 12;
            int y = 25;
            int z = 36;

            Console.WriteLine("===================== ^0 is the same as Length.      =>");
            Console.WriteLine($"{numbers[^x]} is the same as {numbers[numbers.Length - x]}");
            Console.WriteLine($"{numbers[x..y].Length} is the same as {y - x}");
            Console.WriteLine();
        }

        //public static void Demo6() { }

        private static void PrintWords(string[] words)
        {
            foreach (var word in words) Console.Write($"< {word} >");

            Console.WriteLine();
        }

    }
}
