using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuableList = new List<IValuable>();

        public void AddValuable(IValuable iValuable)
        {
            valuableList.Add(iValuable);
        }

        public IValuable GetValuable(string id)
        {
            foreach (var valuable in valuableList)
            {
                if (valuable is Course && string.Equals((valuable as Course).Name, id))
                {
                    return valuable;
                }
                else if (valuable is Merchandise && string.Equals((valuable as Merchandise).ItemId, id))
                {
                    return valuable;
                }
            }

            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0.0;
            foreach (var valuable in valuableList)
            {
                totalValue += valuable.GetValue();
            }

            return totalValue;
        }

        public int Count()
        {
            return valuableList.Count();
        }

        public void Save()
        {
            SaveFile();
        }

        public void Save(string fileName)
        {
            SaveFile(fileName);
        }

        private void SaveFile(string fileName = "C:\\Users\\Johannes\\Documents\\Visual Studio 2017\\Projects\\MorgenGry\\MorgenGry\\bin\\DebugValuableRepository.txt")
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@fileName))
                {
                    foreach (IValuable valuable in valuableList)
                    {
                        if (valuable is Course course)
                        {
                            writer.WriteLine("KURSUS;{0};{1};{2}", course.Name, course.CourseHourValue, course.DurationInMinutes);
                        }

                        if (valuable is Book book)
                        {
                            writer.WriteLine("BOG;{0};{1};{2}", book.ItemId, book.Title, book.Price);
                        }

                        if (valuable is Amulet amulet)
                        {
                            writer.WriteLine("AMULET;{0};{1};{2}", amulet.ItemId, amulet.Design, amulet.Quality);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Load()
        {
            LoadFile();
        }

        public void Load(string fileName)
        {
            LoadFile(fileName);
        }

        private void LoadFile(string fileName = "C:\\Users\\Johannes\\Documents\\Visual Studio 2017\\Projects\\MorgenGry\\MorgenGry\\bin\\DebugValuableRepository.txt")
        {
            try
            {
                using (StreamReader reader = new StreamReader(@fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] elements = line.Split(';');

                        if (Equals(elements[0], "BOG"))
                        {
                            Book book = new Book(elements[1], elements[2], double.Parse(elements[3]));
                            AddValuable(book);
                        }

                        if (Equals(elements[0], "AMULET"))
                        {
                            Level level = (Level) Enum.Parse(typeof(Level), elements[3]);
                            Amulet amulet = new Amulet(elements[1], level, elements[2]);
                            AddValuable(amulet);
                        }

                        if (Equals(elements[0], "KURSUS"))
                        {
                            Course course = new Course(elements[1], int.Parse(elements[3]), double.Parse(elements[2]));
                            AddValuable(course);
                        }
                    }
                    
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
