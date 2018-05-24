using System;
using System.Runtime.CompilerServices;
using CodeWars.Piracy;

namespace CodeWars
{

    // Don't remove this
    public class Program {


        static void Main(string[] args)
        {
            LinqMethodsUsageClass.MethodToUseWhereLinq();
            LinqMethodsUsageClass.MethodToUseSelectLinq();

            Ship titanic = new Ship(15, 10);
            Console.WriteLine(titanic.IsWorthIt());

            Ship maria = new Ship(21, 0);
            Console.WriteLine(maria.IsWorthIt());
        } 
    }
}
