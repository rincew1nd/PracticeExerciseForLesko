using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_3_DictionaryCollection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numToString = new Hashtable()
            {
                {"0", "Zero"},
                {"1", "One"},
                {"2", "Two"},
                {"3", "Three"},
                {"4", "Four"},
                {"5", "Five"},
                {"6", "Six"},
                {"7", "Seven"},
                {"8", "Eight"},
                {"9", "Nine"}
            };
            var numStr = "74956211558";

            foreach (var chr in numStr)
                if (numToString.ContainsKey(chr.ToString()))
                    Console.WriteLine(numToString[chr.ToString()]);

            Console.ReadKey();
        }
    }
}
