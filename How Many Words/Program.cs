using System;
using System.Text.RegularExpressions;

namespace How_Many_Words
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int howMany(string args)
        {

            var splitWords = args.Split(" ");
            Regex regex = new Regex("[a-zA-Z-!.,?]+");
            var counter = 0;
            foreach (var word in splitWords)
            {
                var match = regex.Match(word);
                if (match.Success&& match.Value==word )
                {
                    counter++;
                    Console.WriteLine($"value: {match.Value}");
                }
            }

            return counter;
        }
    }
}