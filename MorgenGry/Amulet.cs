using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{

    public class Amulet : Merchandise
    {
        public static double LowQualityValue { get; set; } = 12.5;
        public static double MediumQualityValue { get; set; } = 20.0;
        public static double HighQualityValue { get; set; } = 27.5;

        public string Design { get; set; }
        public Level Quality { get; set; }

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

        public override double GetValue()
        {
            switch (Quality)
            {
                case Level.low:
                    return LowQualityValue;
                case Level.medium:
                    return MediumQualityValue;
                case Level.high:
                    return HighQualityValue;
                default:
                    throw new System.Exception();
            }
        }

        
        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality.ToString() + ", Design: " + Design;
        }
    }
}
