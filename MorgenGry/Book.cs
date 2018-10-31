﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class Book : Merchandise
    {
        public string Title { get; set; }
        public double Price { get; set; }

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

        public override double GetValue()
        {
            return Price;
        }

        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Title: "+ Title + ", Price: " + Price;
        }

    }
}
