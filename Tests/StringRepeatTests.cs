using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class StringRepeatTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("*********", StringRepeatKata.repeatStr(9, "*"));
        }
    }
}