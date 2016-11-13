using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_1_BasicCollection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = new ArrayList() { "First", "Second", "Third", "Fourth" };

            foreach (var s in array)
                Console.WriteLine(s);

            array.Sort();

            foreach (var s in array)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
