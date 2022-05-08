using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();

            string alphabets = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;
            String loweredinput = input.ToLower();
            foreach (char chr in alphabets)
            {
                foreach (char letter in loweredinput)
                {

                    if (chr == letter)
                    {
                        count++;
                        break;
                    }

                }
            }
            if (count == 26) return true;
            else return false;
        }
    }
}
