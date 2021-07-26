/*Implement a method that accepts 3 integer values a, b, c. 
 * The method should return true if a triangle can be built with the sides of given length and false in any other case.

(In this case, all triangles must have surface greater than 0 to be accepted).*/
using System;
using System.Linq;

namespace Is_this_a_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Triangle.IsTriangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
    }
    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {

            int[] val = { a, b, c };
            switch (val.ToList().IndexOf(val.Max()))
            {
                case 0:
                    return (a < b + c);
                case 1:
                    return (b < a + c);
                case 2:
                    return (c < b + a);
                default:
                    return false;
            }
        }
    }
}
/*
public class Triangle
{
    public static bool IsTriangle(int a, int b, int c) => 
      a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
}
 */
