using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_3_CreateStruct
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var manager = new Manager("Tony", "Allen", 32, Person.Genders.Male, "+7(985)544-11-22", "Russia, Moscow, Verina st. 13-1-43");
            Console.WriteLine(manager.ToString());
            Console.ReadKey();
        }
    }
}
