using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_1
{
    public struct Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Genders Gender;

        public Person(string firstName, string lastName, int age, Genders gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}({Gender}),{Age}";
        }

        public enum Genders
        {
            Male,
            Famale
        }
    }
}
