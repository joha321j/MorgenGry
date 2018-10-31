using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public abstract class Merchandise
    {
        public string ItemId { get; set; }

        new
        public string ToString()
        {
            return "ItemId: " + ItemId;
        }
    }
}
