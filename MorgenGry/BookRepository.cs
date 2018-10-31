using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    /*
    public class BookRepository
    {
        private List<Book> bookList = new List<Book>();
        public void AddBook(Book book)
        {
            bookList.Add(book);
        }

        public Book GetBook(string itemId)
        {
            try
            {
                return bookList.Find(book => string.Equals(book.ItemId, itemId));
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }

        public double GetTotalValue()
        {
            double totalValue = 0.0;
            foreach (Book book in bookList)
            {
                totalValue += Utility.GetValueOfBook(book);
            }

            return totalValue;
        }
    
    */
}
