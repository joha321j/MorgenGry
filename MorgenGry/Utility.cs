using System;
using MorgenGry;

namespace MorgenGry
{
    public class Utility
    {
        private static double GetValueOfBook(Book b1)
        {
            return b1.Price;
        }

        private static double GetValueOfAmulet(Amulet a11)
        {
            switch (a11.Quality)
            {
                case Level.low:
                    return 12.5;
                case Level.medium:
                    return 20.0;
                case Level.high:
                    return 27.5;
                default:
                    throw new System.Exception();
            }
        }

        public static double GetValueOfCourse(Course c111)
        {
            return Math.Ceiling(c111.DurationInMinutes / 60.0) * 875.0;
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