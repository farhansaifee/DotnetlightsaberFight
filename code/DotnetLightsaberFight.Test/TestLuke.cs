using DotnetLightsaberFight.Fighter;
using DotnetLightsaberFight.Test.Fighter;
using NUnit.Framework;

namespace DotnetLightsaberFight.Test
{
    class TestLuke
    {
        [Test]
        public void IsNameLuke()
        {
            // arrange
            IFighter fighter = new Luke();
            // act
            var name = fighter.Name.Contains("Luke");
            // assert
            Assert.True(name);
        }

        [Test]
        public void TestVitality()
        {
            // arrange
            // act
            // assert
            Assert.Pass();
        }

        [Test]
        public void testChangeVitality()
        {
            // arrange
            // act
            // assert
            Assert.Pass();
        }

        [Test]
        public void TestIsDead()
        {
            // arrange
            IFighter fighter = new Luke();
            // act
            var dead = fighter.IsDead();
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
