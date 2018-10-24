using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class Book
    {
        public string ItemId { get; }
        public string Title { get; }
        public double Price { get; }

        public Book(string itemId) : this(itemId, "", 0)
        {
        }

        public Book(string itemId, string title) : this(itemId, title, 0)
        {
        }

        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }

        new
        public string ToString()
        {
            return "ItemId: " + ItemId + ", Title: "+ Title + ", Price: " + Price;
        }

    }
}
