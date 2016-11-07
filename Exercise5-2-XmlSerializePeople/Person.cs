using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Exercise5_2_XmlSerializePeople
{
    public class Person
    {
        public string Name;
        public DateTime DateOfBirth;
        public int Age;
        
        public Person() { }

        public Person(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            CalculateAge();
        }

        public override string ToString()
        {
            return $"{Name} was born on {DateOfBirth.ToShortDateString()} and is {Age} years old.";
        }

        private void CalculateAge()
        {
            Age = DateTime.Now.Year - DateOfBirth.Year;

            // If they haven't had their birthday this year, 
            // subtract a year from their age
            if (DateOfBirth.AddYears(DateTime.Now.Year - DateOfBirth.Year) > DateTime.Now)
                Age--;
        }
    }
}
