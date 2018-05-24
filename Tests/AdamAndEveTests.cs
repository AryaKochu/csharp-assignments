using CodeWars.AdamAndEve;

namespace Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AdamAndEveTests
    {
        [Test]
        public void SampleTest()
        {
            Human[] humans = God.Create();
            Assert.That(humans[0] is Man, "The first object in the array should be a Man");
        }
    }
}