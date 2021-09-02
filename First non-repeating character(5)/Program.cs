/*Write a function named first_non_repeating_letter that takes a string input, and returns the first character that is not repeated anywhere in the string.

For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.

As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the correct case for the initial letter. For example, the input 'sTreSS' should return 'T'.

If a string contains all repeating characters, it should return an empty string ("") or None -- see sample tests.*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.FirstNonRepeatingLetter("RpRP"));
            Console.WriteLine(Kata.FirstNonRepeatingLetter("a"));
            Console.WriteLine(Kata.FirstNonRepeatingLetter("stress"));
            Console.WriteLine(Kata.FirstNonRepeatingLetter("moonmen"));
            Console.WriteLine(Kata.FirstNonRepeatingLetter("sTreSS"));
            Console.WriteLine(Kata.FirstNonRepeatingLetter("RRP"));
        }
    }
    public class Kata
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            int count = 0;
            
            string ss = s.ToUpper();
            if (s.Length == 1)
                return s;
            for (int i = 0; i < s.Length ; i++)
            {
                for (int ii = 0; ii < s.Length; ii++)
                {
                    if (i == ii)
                    {
                        continue;
                    }

                    var x = s.ToUpper()[i];
                    var y = ss[ii];

                    if (s.ToUpper()[i] == ss[ii])
                    {
                        count++;
                        break;
                    }

                    if (ii == s.Length - 1&&count!=s.Length)
                        return s.Substring(i, 1);
                }
            }

            if (count == s.Length)
                return "";
            return s.Substring(s.Length-1, 1);
        }
    }
}
