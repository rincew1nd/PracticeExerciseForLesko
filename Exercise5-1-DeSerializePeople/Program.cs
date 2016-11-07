using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_1_DeSerializePeople
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person("Иван", DateTime.Today.AddYears(-14).AddDays(-43));
            Serialize(person);
            var deserializePerson = Deserialize();
            Console.WriteLine(deserializePerson.ToString());
            Console.ReadKey();
        }

        public static void Serialize(Person person)
        {
            using (var stream = File.Create("Person.dat"))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, person);
            }
        }

        public static Person Deserialize()
        {
            using (var stream = File.Open("Person.dat", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                return (Person)formatter.Deserialize(stream);
            }
        }
    }
}
