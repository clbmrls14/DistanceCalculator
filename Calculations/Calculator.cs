using System;

namespace Calculations
{
    public class Calculator
    {
        public static int TimeToTravel(double distance, int speed)
        {
            return (int) Math.Round((distance / speed) * 60);
        }

        public static string TimeToString(double travelTime)
        {
            int minutes = (int) travelTime;
            int hours = (int) travelTime / 60;
            minutes = (int)minutes % 60;
            return hours + " Hours, " + minutes + " Minutes";
        }
    }
}
