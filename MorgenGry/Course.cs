using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class Course : IValuable
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public double CourseHourValue { get; set; }

        public Course(string name) : this(name, 0, 825.00)
        {
        }

        public Course(string name, int durationInMinutes) : this(name, durationInMinutes, 825.0)
        {
        }

        public Course(string name, int durationInMinutes, double courseHourValue)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
            CourseHourValue = courseHourValue;
        }

        public double GetValue()
        {
            return Math.Ceiling(DurationInMinutes / 60.0) * CourseHourValue;
        }

        new
        public string ToString()
        {
            return "Name: " + Name + ", Duration in Minutes: " + DurationInMinutes + ", Pris pr påbegyndt time: " + CourseHourValue;
        }
    }
}
