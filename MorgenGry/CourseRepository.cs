using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class CourseRepository
    {
        private List<Course> courseList = new List<Course>();

        public void AddCourse(Course course)
        {
            courseList.Add(course);
        }

        public Course GetCourse(string name)
        {
            try
            {
                return courseList.Find(Course => string.Equals(Course.Name, name));
            }
            catch (ArgumentNullException)
            {
                return null;
            }
            
        }

        public double GetTotalValue()
        {
            double totalValue = 0.0;

            foreach (Course course in courseList)
            {
                totalValue += Utility.GetValueOfCourse(course);
            }
            return totalValue;
        }

    }
}
