using System;
using System.Runtime.Serialization;

namespace Exercise5_1_DeSerializePeople
{
    [Serializable]
    public class Person : IDeserializationCallback
    {
        public string Name;
        public DateTime DateOfBirth;
        [NonSerialized]
        public int Age;
        
        public Person() {}

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

        public void OnDeserialization(object sender)
        {
            CalculateAge();
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
