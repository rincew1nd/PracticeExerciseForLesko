using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_2_SortString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var strArray = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(strArray);
            Console.WriteLine(string.Join(", ", strArray));
            Console.ReadKey();
        }
    }
}
