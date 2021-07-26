/*
 This time no story, no theory. The examples below show you how to write function accum:
accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt"

The parameter of accum is a string which includes only letters from a..z and A..Z.
 */

using System;
using System.Text;

namespace Mumbling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accumul.Accum(Console.ReadLine()));
        }
    }
    public class Accumul
    {
        public static String Accum(string s)
        {
            StringBuilder ss = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                ss.Append(Char.ToUpper(s[i]));
                ss.Append(Char.ToLower(s[i]), i);
                ss.Append('-');
            }
            //return ss.ToString(0, ss.Length - 1);
            return ss.ToString().TrimEnd('-');
        }
    }
}
/*using System;
using System.Linq;
public class Accumul 
{
  public static String Accum(string s) 
  {
     return string.Join("-",s.Select((x,i)=>char.ToUpper(x)+new string(char.ToLower(x),i)));
  }
}*/