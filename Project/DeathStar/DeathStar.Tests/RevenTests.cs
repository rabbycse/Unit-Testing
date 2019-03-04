using Autofac.Extras.Moq;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using Moq;
using System.Collections.Generic;
using System;
using DeathStar;

namespace Tests
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class RevenTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FireWeaponTests()  
        {
            using (var mock = AutoMock.GetLoose())
            {
                var weapon = mock.Mock<IWeapon>();
                weapon.Setup(x => x.Damage).Returns(500);

                var ship = mock.Create<Reven>();
                ship.Weapons = new List<IWeapon>() { weapon.Object,weapon.Object };
  
                var damange = ship.FireWeapon();
                weapon.VerifyAll();
                Assert.AreEqual(1000, damange);
            }
        }
    }

    
}