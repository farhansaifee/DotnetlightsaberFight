using DotnetLightsaberFight.Fighter;
using DotnetLightsaberFight.Test.Fighter;
using NUnit.Framework;

namespace DotnetLightsaberFight.Test
{
    class TestYoda
    {
        IFighter yoda;

        [Test]
        public void IsNameYoda()
        {
            // arrange
            yoda = new Yoda();
            // act
            var name = yoda.Name.Contains("Yoda");
            // assert
            // Assert.AreEqual(Lightsaber.Equals, name);
            Assert.IsTrue(name);
        }

        [Test]
        public void TestVitality120()
        {
            // arrange
            yoda = new Yoda();
            // act
            var vit = yoda.Vitality;
            // assert
            Assert.AreEqual(vit, 120);
        }

        [Test]
        public void testChangeVitality()
        {
            // arrange
            yoda = new Yoda();
            // act
            
            // assert
            
        }

        [Test]
        public void TestIsDead()
        {
            // arrange
            yoda = new Yoda();
            // act
            var dead = yoda.IsDead();
            // assert
            Assert.AreEqual(dead, false);
            //Assert.IsTrue(dead);
        }

        [Test]
        public void TestNextAim()
        {
            // arrange
            // act
            // assert
            Assert.Pass();
        }
    }
}
