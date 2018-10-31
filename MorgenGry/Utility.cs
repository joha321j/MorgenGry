using System;
using MorgenGry;

namespace MorgenGry
{
    public class Utility
    {
        public static double LowQualityValue { get; set; } = 12.5;
        public static double MediumQualityValue { get; set; } = 20.0;
        public static double HighQualityValue { get; set; } = 27.5;
        public static double CourseHourValue { get; set; } = 875.0;

        private static double GetValueOfBook(Book b1)
        {
            return b1.Price;
        }

        private static double GetValueOfAmulet(Amulet a11)
        {
            switch (a11.Quality)
            {
                case Level.low:
                    return LowQualityValue;
                case Level.medium:
                    return MediumQualityValue;
                case Level.high:
                    return HighQualityValue;
                default:
                    throw new System.Exception();
            }
        }

        public static double GetValueOfCourse(Course c111)
        {
            return Math.Ceiling(c111.DurationInMinutes / 60.0) * CourseHourValue;
        }

        public static double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise is Amulet)
            {
                return GetValueOfAmulet((Amulet) merchandise);
            }
            else
            {
                return GetValueOfBook((Book) merchandise);
            }
        }
    }
}