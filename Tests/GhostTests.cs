using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GhostTests
    {
        [Test]
        public void MyTest()
        {
            string[] colors = { "white", "yellow", "purple", "red" };
            var ghost = new GhostKata
            {
                Colour = "Blue"
            };
            Assert.IsTrue(colors.Contains(ghost.Colour));
        }
    }
}
