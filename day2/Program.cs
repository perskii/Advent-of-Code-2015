using System;
using System.IO;
using System.Linq;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Part1();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n#####################");
            Console.ForegroundColor = ConsoleColor.Green;  
            Part2();
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Part1()
        {
            Console.WriteLine(File.ReadAllLines(@"E:\adventofcode2015\day2\Day2\input.txt")
            .Select(_ => _.Split('x'))
            .Select(_ => _.Select(Int32.Parse))
            .Select(z => z.OrderBy(x => x).ToArray())
            .Select(z => 3 * z[0] * z[1] + 2 * z[0] * z[2] + 2 * z[1] * z[2])
            .Sum());
        }
        private static void Part2()
        {
            Console.WriteLine(File.ReadAllLines(@"E:\adventofcode2015\day2\Day2\input.txt")
                .Select(_ => _.Split('x'))
                .Select(_ => _.Select(Int32.Parse))
                .Select(x => x.OrderBy(x => x).ToArray())
                .Select(x => 2 * x[0] + 2 * x[1] + x[0] * x[1] * x[2])
                .Sum());
        }

    }
}
