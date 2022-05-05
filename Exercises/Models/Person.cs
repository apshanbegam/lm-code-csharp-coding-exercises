using System;
namespace Exercises.Models
{
    public class Person
    {

        public Person(string firstName, string lastName, string place, int ageLimit)
        {
            FirstName = firstName;
            LastName = lastName;
            Place = place;
            AgeLimit = ageLimit;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Place { get; set; }

        public int AgeLimit { get; set; }


    }
}
