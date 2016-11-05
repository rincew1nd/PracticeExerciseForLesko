namespace Exercise1_3_CreateStruct
{
    public class Person
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
