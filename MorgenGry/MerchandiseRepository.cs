using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandiseList = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandiseList.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            try
            {
                return merchandiseList.Find(merchandise => string.Equals(merchandise.ItemId, itemId));
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }

        public double GetTotalValue()
        {
            double totalValue = 0.0;
            foreach (Merchandise merchandise in merchandiseList)
            {
                totalValue += Utility.GetValueOfMerchandise(merchandise);
            }

            return totalValue;
        }
    }
}
