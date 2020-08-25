using System;

namespace Calculations
{
    public class Calculator
    {
        public static int SovleForTime(double distance, int speed)
        {
            if (distance < 0 | speed <= 0)
            {
                distance = 0;
                speed = 1;
            }
            return (int) Math.Round((distance / speed) * 60); // Returns X minutes it will take to travel Y distance at Z speed
        }

        public static double SolveForTime(double speed, double minutes)
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
    }
}
