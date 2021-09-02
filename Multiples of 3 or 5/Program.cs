/*
 *If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0 (for languages that do have them).

Note: If the number is a multiple of both 3 and 5, only count it once.
 
Если мы перечислим все натуральные числа ниже 10, которые кратны 3 или 5, мы получим 3, 5, 6 и 9. Сумма этих кратных 23.

Завершите решение так, чтобы оно возвращало сумму всех кратных 3 или 5 ниже переданного числа. Кроме того, если число отрицательное, верните 0 (для языков, в которых они есть).

Примечание. Если число кратно 3 и 5, сосчитайте его только один раз.
 */
using System;
using System.Text;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Console.WriteLine(Kata.Solution(int.Parse(Console.ReadLine())).ToString());
            }
        }
    }

    public static class Kata
    {
        public static int Solution(int value)
        {
            if (value < 0)
                return 0;
            int sum = 0;
            for (int i = 2; i <value; i++)
            {
                if (i % 5 == 0)
                    sum += i;
                else
                    if(i%3==0)
                        sum += i;

            }

            return sum;
        }
    }
}

//return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();