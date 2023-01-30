using System;
using System.IO;
using System.Linq;

namespace Longest_word_in_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "(insert file pathway here)";
            var words = File.ReadAllText(path).Split(" ");
            string longest = words.OrderByDescending(s => s.Length).First();
            Console.WriteLine(longest);
        }
    }
}
