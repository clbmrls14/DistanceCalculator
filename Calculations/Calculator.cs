using System;

namespace Calculations
{
    public class Calculator : ICloneable
    {

        public double distance { get; set; }
        public int speed { get; set; }
        public double minutes { get; set; }
        public string distanceType { get; set; }
        public double convertedDistance { get; set; }
        public string speedType { get; set; }
        public int travelTime { get; set; }
        public string travelTimeString { get; set; }
        public double distanceTraveled { get; set; }
        public double travelRate { get; set; }

        public void CalculateAll()
        {
            travelTime = SolveForTime(distance, speed);
            travelTimeString = TimeToString(travelTime);
            distanceTraveled = SolveForDistance(speed, minutes);
            travelRate = SolveForSpeed(distance, minutes);
        }

        public static int SolveForTime(double distance, int speed)
        {
            if (distance < 0 | speed <= 0)
            {
                distance = 0;
                speed = 1;
            }
            return (int) Math.Round((distance / speed) * 60); // Returns X minutes it will take to travel Y distance at Z speed
        }

        public static double SolveForDistance(double speed, double minutes)
        {
            if (speed < 0 | minutes < 0)
            {
                speed = 0;
                minutes = 0;
            }
            return Math.Round(((speed * minutes) / 60), 2);
        }

        public static double SolveForSpeed(double distance, double minutes)
        {
            if (distance < 0 | minutes <= 0)
            {
                distance = 0;
                minutes = 1;
            }
            return Math.Round(((distance / minutes) * 60), 2);
        }

        public static string TimeToString(double travelTime)
        {
            if (travelTime < 0)
            {
                travelTime = 0;
            }
            int minutes = (int) travelTime;
            int hours = (int) travelTime / 60;
            minutes = (int)minutes % 60;
            return hours + " Hours, " + minutes + " Minutes";
        }

        public static double MilesToKilometers(double miles)
        {
            if (miles < 0)
            {
                miles = 0;
            }
            return Math.Round((miles * 1.60934), 2);
        }

        public static double KilometersToMiles(double kilometers)
        {
            if (kilometers < 0)
            {
                kilometers = 0;
            }
            return Math.Round((kilometers / 1.60934), 2);
        }

        public object Clone()
        {
            return new Calculator
            {
                distance = distance,
                speed = speed,
                minutes = minutes,
                distanceType = distanceType,
                speedType = speedType,
                travelTime = travelTime,
                travelTimeString = travelTimeString,
                travelRate = travelRate,
                distanceTraveled = distanceTraveled,
            };
        }

        public string this[string columnName]
        {
            get
            {
                switch(columnName)
                {
                    case nameof(distance):
                        if (distance < 0)
                            return "Distance must be greater than 0";
                        break;
                    case nameof(speed):
                        if (speed < 0)
                            return "Speed must be greater than 0";
                        break;
                    case nameof(minutes):
                        if (minutes < 0)
                            return "Minutes must be greater than 0;";
                        break;
                }
                return string.Empty;
            }
        }
    }
}
