using System;
using System.Data.Common;
using System.Globalization;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Kata
    {
        public static string ToCamelCase(string str)
        {
            string[] words = str.Split(new Char[] { '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
            string first = words[0];
            words = words.Skip(1)
                .Select(word => char.ToUpper(word[0]) + word.Substring(1))
                .ToArray();
            return first + string.Join("", words);
        }
    }
}
