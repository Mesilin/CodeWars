/*
 A pangram is a sentence that contains every single letter of the alphabet at least once. 
For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, 
because it uses the letters A-Z at least once (case is irrelevant).

Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.
 */
using System;

namespace Detect_Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(Kata.IsPangram(Console.ReadLine()));

        }
        public static class Kata
        {
            public static bool IsPangram(string str)
            {
                int count = 0;
                for (int i = 65; i < 91; i++)
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str.ToUpper()[j] == i)
                        {
                            count++;
                            break;
                        }
                    }
                return count == 26;
            }
        }
    }
}
/*using System;
using System.Linq;

public static class Kata
{
  public static bool IsPangram(string str) =>
    return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
}*/
///////////////////////////////////
/*
 using System.Linq;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    return "abcdefghijklmnopqrstuvwxyz".All(x => str.ToLower().Contains(char.ToLower(x)));
  }
}
 */
/*
 using System.Linq;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    return str.ToUpper().Where(char.IsLetter).Distinct().Count() == 26;
  }
}
 */
/*
 using System.Linq;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    return !"abcdefghijklmnopqrstuvwxyz"
            .Except(str.ToLower())
            .Any();
  }
}
 */
