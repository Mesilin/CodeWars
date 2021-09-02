/*Complete the solution so that the function will break up camel casing, using a space between words.

Example
"camelCasingC"  =>  "camel Casing"
"identifier"   =>  "identifier"
""             =>  ""
*/
using System;
using System.Text;

namespace Break_camelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.BreakCamelCase(Console.ReadLine()));
        }
    }
    public class Kata
    {
        public static string BreakCamelCase(string str)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90&&i!=0)
                    s.Append(' ');
                s.Append(str[i]);
            }

            str = s.ToString();
            return str;
        }
    }
}
