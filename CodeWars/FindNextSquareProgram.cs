using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class FindNextSquareProgram
    {
        public static long FindNextSquare(long num)
        {
            double result = Math.Sqrt(num);
            double nextSquare = result % 1 == 0 ? Math.Pow(result + 1, 2) : -1;

            Debug.WriteLine("The next square is: " + nextSquare);
         
            long answer = Convert.ToInt64(nextSquare);
            return answer;
        }
    }
}
