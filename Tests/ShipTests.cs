using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars.Piracy;
using NUnit.Framework;

namespace Tests
{

    [TestFixture]
    public class ShipTests
    {
        [Test]
        public void ShipWithCrewTests()
        {
            Ship titanic = new Ship(15, 10);

            Assert.AreEqual(false, titanic.IsWorthIt());

            // Mutation tests
            Assert.AreEqual(15, titanic.Draft, "Do you need two eyepatches, mate? That ship is clearly 15 draft deep.");
            Assert.AreEqual(10, titanic.Crew, "Do you need two eyepatches, mate? That ship clearly has a crew of 10 people.");
        }

        [Test]
        public void ShipWithoutCrewTests()
        {
            Ship maria = new Ship(21, 0);

            Assert.AreEqual(true, maria.IsWorthIt());

            // Mutation tests
            Assert.AreEqual(21, maria.Draft, "Do you need two eyepatches, mate? That ship is clearly 15 draft deep.");
            Assert.AreEqual(0, maria.Crew, "Do you need two eyepatches, mate? That ship clearly has a crew of 10 people.");
        }
    }
}
