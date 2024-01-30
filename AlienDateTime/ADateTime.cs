using System;

namespace AlienDateTime
{
    public class ADateTime
    {
        private int[] daysInMonth = { 44, 42, 48, 40, 48, 44, 40, 44, 42, 40, 40, 42, 44, 48, 42, 40, 44, 38 };
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public double Second { get; set; }


        // Constructor for AlienClock
        public ADateTime() { }
        public ADateTime(int year, int month, int day, int hour, int minute, double second)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        //Calculate the number of seconds between 0:0:0 and this time 
        public double Seconds2Zero()
        {
            return Hour * 90 * 90 + Minute * 90 + Second;
        }
        //Calculate the number of days between the current date and January 1st
        public int Day2Zero()
        {
            int res = 0;
            for (int i = 0; i < Month-1; i++)
            {
                res += daysInMonth[i];
            }
            return res+Day;
        }
        public int DaysOfYear()
        {
            int res = 0;
            for (int i = 0; i < daysInMonth.Length; i++)
            {
                res += daysInMonth[i];
            }
            return res;
        }
        public int CalculateDifferenceInDays(ADateTime current, ADateTime reference)
        {
            int yearsElapsed = current.Year - reference.Year;
            int daysElapsed = yearsElapsed * DaysOfYear() + (current.Day2Zero() - reference.Day2Zero());
            return daysElapsed;
        }

        // Method to add seconds to AlienClock
        public void AddSeconds(double seconds)
        {
            Second += seconds;

            // Adjust minutes, hours, days, etc. as needed
            while (Second >= 90)
            {
                Second -= 90;
                Minute++;

                if (Minute >= 90)
                {
                    Minute -= 90;
                    Hour++;

                    if (Hour >= 36)
                    {
                        Hour -= 36;
                        Day++;

                        if (Day > GetDaysInMonth(Month))
                        {
                            Day = 1;
                            Month++;

                            if (Month > 18)
                            {
                                Month = 1;
                                Year++;
                            }
                        }
                    }
                }
            }

            Second = Math.Round(Second, 0);
        }

        // Method to get the number of days in a specific month
        private int GetDaysInMonth(int month)
        {
            
            return daysInMonth[month - 1];
        }

        // Method to format AlienClock as a string
        public override string ToString()
        {
            return $"{Year}-{Month}-{Day} {Hour}:{Minute}:{Second}";
        }

        public ADateTime ConvertToAlienClock(DateTime earthTime)
        {
            // Using the starting value of extraterrestrial time to initialize the AlienClock object
            ADateTime alienTime = new ADateTime(2804, 18, 31, 2, 2, 88);

            // Calculate the time difference between Earth time and start time (in seconds)
            double earthTimeInSeconds = (earthTime - new DateTime(1970, 1, 1, 12, 0, 0)).TotalSeconds;

            // Convert to seconds of extraterrestrial time and add to AlienClock
            double alienTimeInSeconds = earthTimeInSeconds / 0.5;
            alienTime.AddSeconds(alienTimeInSeconds);

            return alienTime;
        }

        // Method to calculate the difference in seconds between two AlienClock times
        private double CalculateDifferenceInSeconds(ADateTime current, ADateTime reference)
        {
            
            int daysElapsed = current.CalculateDifferenceInDays(current, reference);
            double s1 = current.Seconds2Zero();
            double s2 = reference.Seconds2Zero();
            double seconds = current.Seconds2Zero() - reference.Seconds2Zero();
            double sc = (double)daysElapsed * 36 * 90 * 90;
            
            return seconds+sc;
        }
        /// <summary>
        /// Convert to Earth DateTime
        /// </summary>
        /// <returns></returns>
        public DateTime ToEarthTime()
        {
            // Calculate the difference in seconds between AlienClock time and a specific AlienClock time (2804-18-31 2:2:88)
            double differenceInSeconds = CalculateDifferenceInSeconds(this, new ADateTime(2804, 18, 31, 2, 2, 88));

            // Calculate the corresponding DateTime in Earth time
            DateTime earthTime = new DateTime(1970, 1, 1, 12, 0, 0).AddSeconds(differenceInSeconds * 0.5);

            return earthTime;
        }

        // Overload the equality operator (==)
        public static bool operator ==(ADateTime left, ADateTime right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (left is null || right is null)
            {
                return false;
            }

            return left.Year == right.Year &&
                   left.Month == right.Month &&
                   left.Day == right.Day &&
                   left.Hour == right.Hour &&
                   left.Minute == right.Minute &&
                   left.Second == right.Second;
        }
        // Overload the inequality operator (!=)
        public static bool operator !=(ADateTime left, ADateTime right)
        {
            return !(left == right);
        }

        // Override the Equals method
        public override bool Equals(object obj)
        {
            if (obj is ADateTime alienClock)
            {
                return this == alienClock;
            }

            return false;
        }
       
        // Override the GetHashCode method
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17; // Choose a non-zero prime number as the initial value
                hash = hash * 31 + Year.GetHashCode();
                hash = hash * 31 + Month.GetHashCode();
                hash = hash * 31 + Day.GetHashCode();
                hash = hash * 31 + Hour.GetHashCode();
                hash = hash * 31 + Minute.GetHashCode();
                hash = hash * 31 + Second.GetHashCode();
                return hash;
            }
        }

    }
}
