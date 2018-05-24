using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class VowelCountTests
    {
        [Test]
        public void VowelCountTest()
        {
            Assert.AreEqual(5, CodeWars.VowelCountKata.GetVowelCount("abracadabra"), "Nope!");
        }
    }

}
