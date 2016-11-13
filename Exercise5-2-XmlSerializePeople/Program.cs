using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise5_2_XmlSerializePeople
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
            using (var stream = File.Create("Person.xml"))
            {
                var formatter = new XmlSerializer(typeof(Person));
                formatter.Serialize(stream, person);
            }
        }

        public static Person Deserialize()
        {
            using (var stream = File.Open("Person.xml", FileMode.Open))
            {
                var formatter = new XmlSerializer(typeof(Person));
                return (Person)formatter.Deserialize(stream);
            }
        }
    }
}
