using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodeWars;
using Microsoft.DotNet.Cli.Utils.CommandParsing;

namespace Tests
{
    class FindNextSquareProgramTest
    {
        [Test]
        [TestCase(155, ExpectedResult = -1)]
        [TestCase(121, ExpectedResult = 144)]
        [TestCase(625, ExpectedResult = 676)]
        [TestCase(319225, ExpectedResult = 320356)]
        [TestCase(15241383936, ExpectedResult = 15241630849)]
        public static long FixedTest(long num)
        {
            return FindNextSquareProgram.FindNextSquare(num);
        }
    }
}
