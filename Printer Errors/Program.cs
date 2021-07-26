using System;
using System.Linq;

namespace Printer_Errors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Printer.PrinterError("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"));

        }
    }
    public class Printer
    {
        public static string PrinterError(String s)
        {
            int i = 0;
            foreach (char x in s)
            {
                if (x > 'm') i++;
            }
            return i + "/" + s.Length.ToString();
        }
    }
}
/*
 using System;
using System.Text.RegularExpressions;

public class Printer 
{
    private const string pattern = @"[^a-m]";
    public static string PrinterError(String s) 
    {
        return $"{Regex.Matches(s, pattern).Count}/{s.Length}";
    }
}
 */
/*using System.Linq;

public class Printer 
{
    public static string PrinterError(string s) 
    {
        return s.Where(c => c > 'm').Count() + "/" + s.Length;
    }
}*/
/*
using System;
using System.Linq;
public class Printer 
{
    public static string PrinterError(String s) 
    {
        return s.Count(x=>x>'m')+"/"+s.Count();
    }
}*/