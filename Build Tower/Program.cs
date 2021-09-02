/*
 Build Tower
Build Tower by the following given argument:
number of floors (integer and always greater than 0).

Tower block is represented as *

Python: return a list;
JavaScript: returns an Array;
C#: returns a string[];
PHP: returns an array;
C++: returns a vector<string>;
Haskell: returns a [String];
Ruby: returns an Array;
Lua: returns a Table;
Have fun!
for example, a tower of 3 floors looks like below

[
  '  *  ', 
  ' *** ', 
  '*****'
]
and a tower of 6 floors looks like below

[
  '     *     ', 
  '    ***    ', 
  '   *****   ', 
  '  *******  ', 
  ' ********* ', 
  '***********'
]
 */

using System;
using System.Text;

namespace Build_Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var VARIABLE in Kata.TowerBuilder(6))
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }

    public class Kata
    {
        public static string[] TowerBuilder(int nFloors)
        {
            string[] lines = new string[nFloors];

            for (int i = 0; i < nFloors; i++)
            {
                lines[i] += new string(' ', nFloors - i - 1);
                lines[i] += new string('*', i + i + 1);
                lines[i] += new string(' ', nFloors - i - 1);
            }

            return lines;
        }
    }
}

