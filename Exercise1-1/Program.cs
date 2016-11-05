using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person("Tony", "Allen", 32, Person.Genders.Male);
            Console.WriteLine(person);
            Console.ReadKey();
        }
    }
}
