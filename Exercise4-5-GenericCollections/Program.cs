using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_5_GenericCollections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dic = new Dictionary<int, string>()
            {
                { 7, "Kazakhstan" },
                { 32, "Belgium" },
                { 43, "Austria" },
                { 46, "Sweden" },
                { 49, "Germany" },
                { 56, "Chile" },
                { 86, "China" },
            };
            dic.Add(260, "Zambia");
            //dic.Add("66", "Thailand");

            Console.WriteLine(dic[49]);
            foreach (var pair in dic)
                Console.WriteLine($"Phone code {pair.Key} : Country {pair.Value}");

            Console.ReadKey();
        }
    }
}
