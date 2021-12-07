using DotnetLightsaberFight.Fighter;
using DotnetLightsaberFight.Test.Fighter;
using NUnit.Framework;

namespace DotnetLightsaberFight.Test
{
    public class FighterTest
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void TestYodaHasBlueLightsaber()
        {
            // Arrange
            IFighter fighter = new Yoda();

            // Act
            var actual = fighter.Lightsaber;
            var color = actual.Color;

            // Assert
            Assert.AreEqual(LightsaberColor.Green, color);
        }

        [Test]
        public void TestLukeHasGreenLightsaber()
        {
            // Arrange
            IFighter fighter = new Luke();

            // Act
            var actual = fighter.Lightsaber.Color;

            // Assert
            Assert.AreEqual(LightsaberColor.Blue, actual);
        }

        [Test]
        public void TestDarthVaderHasRedLightsaber()
        {
            // Arrange
            IFighter fighter = new DarthVader();

            // Act
            var actual = fighter.Lightsaber.Color;

            // Assert
            Assert.AreEqual(LightsaberColor.Red, actual);
        }

        [Test]
        public void TestUnknownHasUnknownLightsaber()
        {
            // Arrange
            IFighter fighter = new UnknownFighter();

            // Act
            var actual = fighter.Lightsaber.Color;

            // Assert
            Assert.AreEqual(LightsaberColor.Unknown, actual);
        }

    }

}