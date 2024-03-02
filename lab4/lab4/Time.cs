using System;

namespace lab4
{
    internal class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Time(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }

        public void DisplayTime()
        {
            Console.WriteLine($"{hours:D2}:{minutes:D2}:{seconds:D2}");
        }

        public static Time AddTime(Time t1, Time t2)
        {
            int totalSeconds = t1.seconds + t2.seconds;
            int carryMinutes = totalSeconds / 60;
            int remainingSeconds = totalSeconds % 60;

            int totalMinutes = t1.minutes + t2.minutes + carryMinutes;
            int carryHours = totalMinutes / 60;
            int remainingMinutes = totalMinutes % 60;

            int totalHours = t1.hours + t2.hours + carryHours;

            return new Time(totalHours, remainingMinutes, remainingSeconds);
        }

        public static Time SubtractTime(Time t1, Time t2)
        {
            int totalSeconds = t1.seconds - t2.seconds;
            int borrowMinutes = 0;
            if (totalSeconds < 0)
            {
                totalSeconds += 60;
                borrowMinutes = 1;
            }

            int totalMinutes = t1.minutes - t2.minutes - borrowMinutes;
            int borrowHours = 0;
            if (totalMinutes < 0)
            {
                totalMinutes += 60;
                borrowHours = 1;
            }

            int totalHours = t1.hours - t2.hours - borrowHours;

            return new Time(totalHours, totalMinutes, totalSeconds);
        }
    }

    class MyTimeApp
    {
        static void Main()
        {
            // Get user input for Time 1
            Console.WriteLine("Enter Time 1:");
            Console.Write("Hours: ");
            int hours1 = int.Parse(Console.ReadLine());

            Console.Write("Minutes: ");
            int minutes1 = int.Parse(Console.ReadLine());

            Console.Write("Seconds: ");
            int seconds1 = int.Parse(Console.ReadLine());

            // Get user input for Time 2
            Console.WriteLine("\nEnter Time 2:");
            Console.Write("Hours: ");
            int hours2 = int.Parse(Console.ReadLine());

            Console.Write("Minutes: ");
            int minutes2 = int.Parse(Console.ReadLine());

            Console.Write("Seconds: ");
            int seconds2 = int.Parse(Console.ReadLine());

            // Create Time objects using user input
            Time time1 = new Time(hours1, minutes1, seconds1);
            Time time2 = new Time(hours2, minutes2, seconds2);

            // Display user-inputted times
            Console.WriteLine("\nTime 1:");
            time1.DisplayTime();
            Console.WriteLine("Time 2:");
            time2.DisplayTime();

            // Perform addition and subtraction
            Time sumTime = Time.AddTime(time1, time2);
            Console.WriteLine("\nSum of times:");
            sumTime.DisplayTime();

            Time diffTime = Time.SubtractTime(time1, time2);
            Console.WriteLine("Difference of times:");
            diffTime.DisplayTime();
        }
    }
}
