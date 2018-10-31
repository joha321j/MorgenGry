using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public abstract class Merchandise : IValuable
    {
        public string ItemId { get; set; }

        
        public override string ToString()
        {
            return "ItemId: " + ItemId;
        }

        public abstract double GetValue();
    }
}
