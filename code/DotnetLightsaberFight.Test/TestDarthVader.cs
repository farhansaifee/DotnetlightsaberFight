using DotnetLightsaberFight.Fighter;
using DotnetLightsaberFight.Test.Fighter;
using NUnit.Framework;

namespace DotnetLightsaberFight.Test
{
    class TestDarthVader
    {
        [Test]
        public void IsNameDV()
        {
            // arrange
            IFighter fighter = new DarthVader();
            // act
            var name = fighter.Name.Contains("DarthVader");
            // assert
            Assert.True(name);
        }

        [Test]
        public void TestVitality()
        {
            // arrange

            // act
            // assert
        }

        [Test]
        public void testChangeVitality()
        {
            // arrange
            // act
            // assert
        }

        [Test]
        public void TestIsDead()
        {
            // arrange
            IFighter fighter = new DarthVader();
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
        }
    }
}
