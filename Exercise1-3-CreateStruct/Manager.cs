using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_3_CreateStruct
{
    public class Manager : Person
    {
        public string PhoneNumber;
        public string OfficeLocation;

        public Manager(string firstName, string lastName, int age, Genders gender,
            string phoneNumber, string officeLocation)
            : base(firstName, lastName, age, gender)
        {
            PhoneNumber = phoneNumber;
            OfficeLocation = officeLocation;
        }

        public override string ToString()
        {
            return $"{base.ToString()},{PhoneNumber},{OfficeLocation}";
        }
    }
}
