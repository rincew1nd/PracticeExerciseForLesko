using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise3_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = new []{ "(555)555-1212", "(555) 555-1212", "555-555-1212", "5555551212", "01111", "01111-1111", "47", "111-11-1111" };
            foreach (var s in input)
            {
                if (IsPhone(s))
                    Console.WriteLine($"{ReformatPhone(s)} is a phone number");
                else if (IsZip(s))
                    Console.WriteLine($"{s} is a zip code");
                else
                    Console.WriteLine($"{s} is unknown");
            }
            Console.ReadKey();
        }

        public static bool IsPhone(string s)
        {
            var regex = new Regex(@"^\(?\d{3}[\) -]{0,2}?\d{3}-?\d{4}$");
            return regex.IsMatch(s);
        }

        public static bool IsZip(string s)
        {
            var regex = new Regex(@"^\d{5}(-\d{4})?$");
            return regex.IsMatch(s);
        }

        public static string ReformatPhone(string s)
        {
            var m = Regex.Match(s, @"^\(?(\d{3})[\) -]{0,2}?(\d{3})-?(\d{4})$");
            return $"({m.Groups[1]}) {m.Groups[2]}-{m.Groups[3]}";
        }
    }
}
