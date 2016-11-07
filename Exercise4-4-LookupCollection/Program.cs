using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_4_LookupCollection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dic = new ListDictionary()
            {
                {"Estados Unidos", "United States of America"},
                {"Canada", "Canada"},
                {"Espana", "Spain"},
            };

            // Case-sensitive keys
            Console.WriteLine(dic["Espana"]);
            Console.WriteLine(dic["Canada"]);

            Console.ReadKey();
        }
    }
}
