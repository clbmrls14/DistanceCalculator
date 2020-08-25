using NUnit.Framework;
using Calculations;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void timeToTravel()
        {
            int distancePerHour = 45;
            double distance = 26.2;
            double travelTime = Calculator.TimeToTravel(distance, distancePerHour);
            Assert.AreEqual(35, travelTime);
        }

        [Test]
        public void timeToString()
        {
            int distancePerHour = 30;
            double distance = 56.7;
            double travelTime = Calculator.TimeToTravel(distance, distancePerHour);
            Assert.AreEqual(113, travelTime);
            string travelTimeString = Calculator.TimeToString(travelTime);
            Assert.AreEqual("1 Hours, 53 Minutes", travelTimeString);
        }
    }
}