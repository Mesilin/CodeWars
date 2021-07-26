using System;

namespace Highest_and_Lowest__7_kyu_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.HighAndLow("1 9 3 4 -5"));
        }
    }
    public static class Kata
    {
        public static string HighAndLow(string numbers)
        {
            string[] splited = numbers.Split(' ');
            int min = Int32.Parse(splited[0]);
            int max = Int32.Parse(splited[0]);

            for (int i=1;i< splited.Length;i++)
            {
                if (min > Int32.Parse(splited[i])) 
                    min = Int32.Parse(splited[i]);
                if (max < Int32.Parse(splited[i]))
                    max = Int32.Parse(splited[i]);

            }
            return max.ToString()+" "+min.ToString();
        }
    }
}

/*
 using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    var parsed = numbers.Split().Select(int.Parse);
    return parsed.Max() + " " + parsed.Min();
  }
}
 */

