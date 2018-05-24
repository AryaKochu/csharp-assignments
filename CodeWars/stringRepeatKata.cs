using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class StringRepeatKata
    {
        public static string repeatStr(int n, string s)
        {
            Console.WriteLine("The result is: " + string.Concat(Enumerable.Repeat(s, n)));
            return string.Concat(Enumerable.Repeat(s, n)); // Generates a sequence that contains one repeated value.
        }
    }
}
