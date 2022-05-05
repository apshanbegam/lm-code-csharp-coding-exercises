using System;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person)
        {
            
            if (person.Place == "Manchester")
                return true;
            else
                return false;
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            if (person.AgeLimit >= ageLimit)
                return true;
            else
                return false;
        }
    }
}
