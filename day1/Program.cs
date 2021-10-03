using System;
using System.IO;

namespace Day1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Day1part1();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n#####################");
            Console.ForegroundColor = ConsoleColor.Green;
            Day1part2();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Day1part1()
        {

            char[] text = File.ReadAllText(@"").ToCharArray();
            /*Console.WriteLine(text);*/


            int floor = 0;

            foreach (char item in text)
            {
                if (item == '(')
                    floor++;
                else if (item == ')')
                    floor--;
            }
            Console.Write("Santa is coming ... "+floor);
            
        }

        public static void Day1part2()
        {
            char[] text = File.ReadAllText(@"").ToCharArray();
            int stop=0;
            /*Console.WriteLine(text);*/

            int floor = 0;

            for (int i =0; i< text.Length; i++)
            {
                if (text[i] == '(')
                    floor++;
                else if (text[i] == ')')
                    floor--;
                if (floor == -1) { 
                    stop = i +1;
                    //1769 floor 0
                    //1770 floor -1
                    break;
                }
            }
            Console.Write("Back to the basement ... "+stop);

        }
    }
}
