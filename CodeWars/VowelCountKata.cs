using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class VowelCountKata
    {
        public static int GetVowelCount(string str)
        {
            // int vowelCount = 0;
            string vowels = "aeiou";

            /*  foreach(var letter in str)
              {
                  if ((letter == 'a') || (letter == 'e') || (letter == 'i') || (letter == 'o') || (letter == 'u'))
                  {
                      vowelCount++;
                  }
              }*/

            Debug.WriteLine(str.Count(x => vowels.IndexOf(x) != -1));
            return str.Count(x => vowels.IndexOf(x) != -1);
            //return vowelCount;
        }
    }
}
