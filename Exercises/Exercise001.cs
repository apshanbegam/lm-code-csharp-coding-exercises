using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            switch (word)
            {
                case null: throw new ArgumentNullException(nameof(word));
                case "": throw new ArgumentException("word cannot be empty");
                default: return word[0].ToString().ToUpper() + word.Substring(1);
            }
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            if (firstName != "" && lastName != "")
            {
                return String.Format("{0}.{1}",
                                  firstName[0], lastName[0]);
            }
            else
            {
                throw new ArgumentException("Name cannot be empty");
            }
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            return Math.Round(originalPrice + (originalPrice * vatRate / 100), 2);
        }

        public string Reverse(string sentence)
        {

            switch (sentence)
            {
                case null: throw new ArgumentNullException(nameof(sentence));
                case "": throw new ArgumentException("sentence cannot be empty");
                default:
                    {
                        char[] chars = sentence.ToCharArray();
                        Array.Reverse(chars);
                        return new String(chars);
                    }
            }
        }

        public int CountLinuxUsers(List<User> users)
        {
            int counter = 0;
            foreach (User user in users)
            {
                if(user.Type == "Linux") {
                    counter++;
                }
            }
            return counter;
        }
    }
}
