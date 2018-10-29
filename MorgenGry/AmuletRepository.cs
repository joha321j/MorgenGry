using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class AmuletRepository
    {
        private List<Amulet> amuletList = new List<Amulet>();

        public void AddAmulet(Amulet amulet)
        {
            amuletList.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            try
            {
                return amuletList.Find(Amulet => string.Equals(Amulet.ItemId, itemId));
            }
            catch (ArgumentNullException)
            {
                return null;
            }
            
        }

        public double GetTotalValue()
        {
            double totalValue = 0.0;

            foreach (Amulet amulet in amuletList)
            {
                totalValue += Utility.GetValueOfAmulet(amulet);
            }

            return totalValue;
        }
    }
}
