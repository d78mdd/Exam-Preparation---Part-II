using System;

namespace _01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialSpeed = int.Parse(Console.ReadLine());
            int firstInterval = int.Parse(Console.ReadLine());
            int secondInterval = int.Parse(Console.ReadLine());
            int thirdInterval = int.Parse(Console.ReadLine());

            decimal minutesPerHour = 60m;

            decimal firstIntervalHours = firstInterval / minutesPerHour;
            decimal firstDistance = initialSpeed * firstIntervalHours;

            decimal speedAfterIncrease = initialSpeed + ((initialSpeed * 10) / 100m);
            decimal secondIntervalHours = secondInterval / minutesPerHour;
            decimal secondDistance = speedAfterIncrease * secondIntervalHours;

            decimal speedAfterDecrease = speedAfterIncrease - ((speedAfterIncrease * 5) / 100m);
            decimal thirdIntervalHours = thirdInterval / minutesPerHour;
            decimal thirdDistance = speedAfterDecrease * thirdIntervalHours;

            decimal finalDistance = firstDistance + secondDistance + thirdDistance;
            string finalResult = string.Format("{0:f2}", finalDistance);
            Console.WriteLine(finalResult);
        }
    }
}
