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
            Assert.AreEqual(35, Calculator.SolveForTime(distance, distancePerHour));
            distance = -0.1;
            Assert.AreEqual(0, Calculator.SolveForTime(distance, distancePerHour));
        }

        [Test]
        public void timeToString()
        {
            int distancePerHour = 30;
            double distance = 56.7;
            double travelTime = Calculator.SolveForTime(distance, distancePerHour);
            Assert.AreEqual(113, travelTime);
            Assert.AreEqual("1 Hours, 53 Minutes", Calculator.TimeToString(travelTime));
        }

        [Test]
        public void milesToKilometers()
        {
            double miles = 26.2;
            Assert.AreEqual(42.16, Calculator.MilesToKilometers(miles));
            miles = 33.6;
            Assert.AreEqual(54.07, Calculator.MilesToKilometers(miles));
            miles = -17.2;
            Assert.AreEqual(0, Calculator.MilesToKilometers(miles));
        }

        [Test]
        public void kilometersToMiles()
        {
            double kilometers = 26.2;
            Assert.AreEqual(16.28, Calculator.KilometersToMiles(kilometers));
            kilometers = 33.6;
            Assert.AreEqual(20.88, Calculator.KilometersToMiles(kilometers));
            kilometers = -44.44;
            Assert.AreEqual(0, Calculator.MilesToKilometers(kilometers));
        }

        [Test]
        public void distanceOverTime()
        {
            double speed = 45;
            double minutes = 32;
            Assert.AreEqual(24, Calculator.SolveForDistance(speed, minutes));
            speed = 66;
            minutes = 33;
            Assert.AreEqual(36.3, Calculator.SolveForDistance(speed, minutes));
            minutes = -16.2;
            Assert.AreEqual(0, Calculator.SolveForDistance(speed, minutes));
        }

        [Test]
        public void solveForSpeed()
        {
            double distance = 26.2;
            int minutes = 60;
            Assert.AreEqual(26.2, Calculator.SolveForSpeed(distance, minutes));
            minutes = 0;
            Assert.AreEqual(0, Calculator.SolveForSpeed(distance, minutes));
        }
    }
}