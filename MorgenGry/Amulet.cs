using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{

    public class Amulet
    {
        public string ItemId { get; }
        public string Design { get; }
        public Level Quality { get; }

        public Amulet(string itemId) : this(itemId, Level.medium, "")
        {
        }
        public Amulet(string itemId, Level level) : this(itemId, level, "")
        {
        }
        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Design = design;
            Quality = quality;
        }

        new
        public string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality.ToString() + ", Design: " + Design;
        }
    }
}
